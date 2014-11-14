using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Agenda Compacte:
//
//  Auteur: Nicolas Chourot
//  Date:   Novembre 2014
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Ce source constitution la plate forme de déaprt pour le TP#3
//  INTIALEZ LES PORTIONS DE CODE QUE VOUS AVEZ MODIFIÉ ET/OU AJOUTÉ
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace DB_Demo
{
    public partial class Form_WeekView : Form
    {
        public string ConnexionString;
        private DateTime _CurrentWeek;
        private Events Events = new Events();
       
        public DateTime CurrentWeek
        {
            set 
            { 
                // calculer la date du dimanche de la semaine courante
                _CurrentWeek = value.AddDays(-(int)value.DayOfWeek);
            }
            get { return _CurrentWeek; }
        }

        public Form_WeekView()
        {
            InitializeComponent();
            // Ici on assume que la BD est dans le même répertoire que l'éxécutable
            // faire attention de copier la bd dans le répertoire release et/ou debug selon le cas
            string DB_URL = System.IO.Path.GetFullPath(@"DB_AGENDA.MDF");
            ConnexionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='" + DB_URL + "';Integrated Security=True";
            CurrentWeek = DateTime.Now;
            PN_Hours.Height = PN_Content.Height = 1500;
        }
        private void Form_WeekView_Load(object sender, EventArgs e)
        {
            PN_Scroll.VerticalScroll.Value = Event.HourToPixel(DateTime.Now.Hour, 0, PN_Hours.Height);
            GetWeekEvents();
        }

        private void GetWeekEvents()
        {
            TableEvents tableEvents = new TableEvents(ConnexionString);
            DateTime date = _CurrentWeek;
            Events.Clear();
            for (int day = 0; day < 7; day++)
            {
                tableEvents.GetDateEvents(date);
                while (tableEvents.NextEventRecord())
                {
                    tableEvents.currentEventRecord.ParentPanel = PN_Content;
                    Events.Add(tableEvents.currentEventRecord);
                }
                tableEvents.EndQuerySQL();
                date = date.AddDays(1);
            }
        }

        private void Fill_Agenda(Graphics DC)
        {
           
            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.LightGray, 1);
            for (int hour = 0; hour < 24; hour++)
            {
                DC.DrawLine(pen, 0, Event.HourToPixel(hour + 1, 0, PN_Hours.Height), PN_Content.Width, Event.HourToPixel(hour + 1, 0, PN_Hours.Height));
            }
            Events.Draw(DC);
        }

        private void PN_Content_Paint(object sender, PaintEventArgs e)
        {
            Fill_Agenda(e.Graphics);
        }

        private void Fill_Days_Header(Graphics DC)
        {
            DateTime date = _CurrentWeek;
            string[] dayNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.DayNames;//[col].Substring(0, 3).ToUpper();
            Brush brush = new SolidBrush(Color.White);
            for (int dayNum = 0; dayNum < 7; dayNum++) 
            {
                Point location = new Point((int)Math.Round(PN_DaysHeader.Width / 7f * dayNum), 0);
                String headerText = dayNames[dayNum];
                String headerDate = date.ToShortDateString();

                DC.DrawString(headerText, PN_DaysHeader.Font, brush, location);
                DC.DrawString(headerDate, PN_DaysHeader.Font, brush, location.X, location.Y + 14);
                date = date.AddDays(1);
            }
        }

        private void Fill_Hours_Header(Graphics DC)
        {
            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.LightGray, 1);
            for (int hour = 0; hour < 24; hour++)
            {
                Point location = new Point(0, Event.HourToPixel(hour, 0, PN_Hours.Height));
                String headerText = (hour < 10? "0": "") + hour.ToString() + ":00";
                DC.DrawString(headerText, PN_DaysHeader.Font, brush, location); 
                DC.DrawLine(pen, 0,Event.HourToPixel(hour + 1, 0, PN_Hours.Height), PN_Hours.Width, Event.HourToPixel(hour + 1, 0, PN_Hours.Height));
            }
        }

        private void Form_WeekView_Resize(object sender, EventArgs e)
        {
        }

        private void PN_Scroll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PN_DaysHeader_Paint(object sender, PaintEventArgs e)
        {
            Fill_Days_Header(e.Graphics);
        }

        private void PN_Hours_Paint(object sender, PaintEventArgs e)
        {
            Fill_Hours_Header(e.Graphics);
        }

        private void PN_Scroll_Resize(object sender, EventArgs e)
        {
            PN_Content.Width = PN_Scroll.Width - 70;
            PN_DaysHeader.Width = PN_Content.Width;
            PN_DaysHeader.Width = PN_Content.Width;
            PN_DaysHeader.Refresh();
            PN_Content.Refresh();

        }

        private void PN_Scroll_Scroll(object sender, ScrollEventArgs e)
        {
            PN_DaysHeader.Refresh();
            PN_Content.Refresh();
        }


        Point lastMouseLocation;
        Point firstMouseLocation; 
        bool mousIsDown = false;
        Pen pen = new Pen(Color.Blue, 2);

        private int RoundToMinutes(int pixel, int interval)
        {
            int minutes = Event.PixelToMinutes(pixel + (int)Math.Round(interval/2f), PN_Content.Height);
            minutes = (int)Math.Truncate((float)minutes / interval) * interval;
            int hour = (int)Math.Truncate(minutes / 60f);
            minutes = minutes - hour * 60;
            return Event.HourToPixel(hour, minutes, PN_Content.Height); 
        }
        private void PN_Content_MouseDown(object sender, MouseEventArgs e)
        {
            mousIsDown = true;
            firstMouseLocation = lastMouseLocation = e.Location;
            if (Events.TargetEvent != null)
            {
                switch (Events.TargetPart)
                {
                    case TargetPart.Top:
                        firstMouseLocation.Y = 
                        lastMouseLocation.Y = Event.HourToPixel(Events.TargetEvent.Starting.Hour, Events.TargetEvent.Starting.Minute, PN_Content.Height);
                        break;
                    case TargetPart.Bottom:
                        firstMouseLocation.Y = 
                        lastMouseLocation.Y = Event.HourToPixel(Events.TargetEvent.Ending.Hour, Events.TargetEvent.Ending.Minute, PN_Content.Height);
                        break;
                    default:  break;
                }
            }
        }

        private void AjustCurrentWeek()
        {
            DateTime Target = new DateTime(Events.TargetEvent.Starting.Year, Events.TargetEvent.Starting.Month, Events.TargetEvent.Starting.Day, 0, 0, 0);
            DateTime CW = new DateTime(_CurrentWeek.Year, _CurrentWeek.Month, _CurrentWeek.Day, 0, 0, 0);
            int delta = (int)(Target - CW).TotalDays;
            if (delta > 6)
            {
                Event currentTarget = Events.TargetEvent.Klone();
                Increment_Week();
                Events.Add(currentTarget);
                currentTarget.Draw(PN_Content.CreateGraphics());
                Events.TargetEvent = currentTarget;
                Cursor.Position = new Point(Cursor.Position.X - 7 * (int)(PN_Content.Width / 7F), Cursor.Position.Y);
            }
            if (delta < 0)
            {
                Event currentTarget = Events.TargetEvent.Klone();
                Decrement_Week();
                Events.Add(currentTarget);
                currentTarget.Draw(PN_Content.CreateGraphics());
                Events.TargetEvent = currentTarget;
                Cursor.Position = new Point(Cursor.Position.X + 7 * (int)(PN_Content.Width / 7F), Cursor.Position.Y);
            }
        }

        private void PN_Content_MouseMove(object sender, MouseEventArgs e)
        {
            int day;

            day = (int)Math.Truncate(firstMouseLocation.X / (PN_Content.Width / 7F));
            Point Bottom = new Point((day + 1) * (int)(PN_Content.Width / 7F), RoundToMinutes(e.Location.Y, 5));
            if (mousIsDown)
            {
                              
                if (Events.TargetEvent != null)
                {
                    day = (int)Math.Truncate((e.Location.X - PN_Content.Width / 14F) / (PN_Content.Width / 7F));
                    switch (Events.TargetPart)
                    {
                        case TargetPart.Top:
                            Events.TargetEvent.Starting = LocationToDateTime(Bottom);
                            break;
                        case TargetPart.Bottom:
                            Events.TargetEvent.Ending = LocationToDateTime(Bottom);
                            break;
                        case TargetPart.Inside:
                            int deltaY = RoundToMinutes(e.Location.Y, 5) - RoundToMinutes(lastMouseLocation.Y, 5);
                            Events.TargetEvent.Starting = LocationToDateTime(new Point(e.Location.X, Event.HourToPixel(Events.TargetEvent.Starting.Hour, Events.TargetEvent.Starting.Minute, PN_Content.Height) + deltaY));
                            Events.TargetEvent.Ending = LocationToDateTime(new Point(e.Location.X, Event.HourToPixel(Events.TargetEvent.Ending.Hour, Events.TargetEvent.Ending.Minute, PN_Content.Height) + deltaY));
                            AjustCurrentWeek();
                            break;
                        default: break;
                    }
                    PN_Content.Refresh(); 
                }
                else
                {
                    PN_Content.Cursor = Cursors.Cross;
                    Point top = new Point(day * (int)(PN_Content.Width / 7F), RoundToMinutes(firstMouseLocation.Y, 5));
                    Rectangle border = new Rectangle(top.X, top.Y, Bottom.X - top.X, Bottom.Y - top.Y);
                    PN_Content.Refresh();
                    PN_Content.CreateGraphics().DrawRectangle(pen, border);
                }
            }
            else
                Events.UpdateTarget(e.Location);
            lastMouseLocation = e.Location;
        }

        private DateTime LocationToDateTime(Point location)
        {
            DateTime date = new DateTime(_CurrentWeek.Year, _CurrentWeek.Month, _CurrentWeek.Day);
            int adjust = (location.X < 0? (int)(PN_Content.Width / 7F) : 0);
            int days = (int)(Math.Truncate((location.X - adjust) / (PN_Content.Width / 7F)));

            date = date.AddDays(days);
            int Minutes = Event.PixelToMinutes(RoundToMinutes(location.Y, 5), PN_Content.Height);
            int Hours = (int)Math.Truncate(Minutes / 60f);
            Minutes = Minutes - Hours * 60;
            return new DateTime(date.Year, date.Month, date.Day, Hours, Minutes, 0); ;
        }

        private void ConludeMouseEvent()
        {
            if (mousIsDown)
            {
                mousIsDown = false;

                if (Events.TargetEvent != null)
                {
                    TableEvents tableEvents = new TableEvents(ConnexionString);
                    tableEvents.UpdateEventRecord(Events.TargetEvent);
                }
                else
                {
                    DLG_Events dlg = new DLG_Events();
                    Event Event = new Event();

                    Event.Starting = LocationToDateTime(firstMouseLocation);
                    Event.Ending = LocationToDateTime(lastMouseLocation);
                    dlg.Event = Event.Klone();
                    if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        TableEvents tableEvents = new TableEvents(ConnexionString);
                        tableEvents.AddEvent(dlg.Event);
                    }
                }
                GetWeekEvents();
                PN_Content.Refresh();
            }
        }

        private void PN_Content_MouseUp(object sender, MouseEventArgs e)
        {
            ConludeMouseEvent();
        }

        private void Decrement_Week()
        {
            _CurrentWeek = _CurrentWeek.AddDays(-7);
            GetWeekEvents();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
        }
        private void Increment_Week()
        {
            _CurrentWeek = _CurrentWeek.AddDays(7);
            GetWeekEvents();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
        }

        private void FBTN_DecrementWeek_Click(object sender, EventArgs e)
        {
            Decrement_Week();
        }

        private void FBTN_IncrementWeek_Click(object sender, EventArgs e)
        {
            Increment_Week();
        }

        private void PN_Content_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((Events.TargetEvent != null) && (Events.TargetPart == TargetPart.Inside))
            {
                DLG_Events dlg = new DLG_Events();
                dlg.Event = Events.TargetEvent;
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (dlg.delete)
                    {
                        TableEvents tableEvents = new TableEvents(ConnexionString);
                        tableEvents.DeleteEvent(dlg.Event);
                        Events.TargetEvent = null;
                        mousIsDown = false;
                    }
                    else
                    {
                        TableEvents tableEvents = new TableEvents(ConnexionString);
                        tableEvents.UpdateEventRecord(dlg.Event);
                    }
                    GetWeekEvents();
                    PN_Content.Refresh();
                }
            }
        }
    }
}
