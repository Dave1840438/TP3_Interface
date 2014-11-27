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

namespace Compact_Agenda
{
    public partial class Form_WeekView : Form
    {
        public string ConnexionString;
        private DateTime _CurrentWeek;
        private Events Events = new Events();
        private int minInterval = 5;

        #region PRÉFÉRENCES
        //Met tes préférences ici si t'en met
        #endregion

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
            uC_Slider1.Minimum = 600;
            uC_Slider1.Maximum = 4600;
            uC_Slider1.Value =
            PN_Hours.Height = PN_Content.Height = 2400;
            uC_Slider1.Hide();
        }
        private void Form_WeekView_Load(object sender, EventArgs e)
        {
            //////
            Form_Choisir_Date form = new Form_Choisir_Date();
            form.ShowDialog();
            //////

            PN_Scroll.Focus();
            GotoCurrentWeek();
        }

        private void PN_Scroll_MouseEnter(Object sender, EventArgs e)
        {
            // pour s'assurer que le mousewheel event sera intercepté

            PN_Scroll.Focus();

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
            Pen pen1 = new Pen(Color.LightGray, 1);
            Pen pen2 = new Pen(Color.LightGray, 1);
            pen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            for (int hour = 0; hour < 24; hour++)
            {
                DC.DrawLine(pen1, 0, Event.HourToPixel(hour + 1, 0, PN_Hours.Height), PN_Content.Width, Event.HourToPixel(hour + 1, 0, PN_Hours.Height));
                DC.DrawLine(pen2, 0, Event.HourToPixel(hour, 30, PN_Hours.Height), PN_Content.Width, Event.HourToPixel(hour, 30, PN_Hours.Height));
            }
            Point location;
            for (int dayNum = 0; dayNum < 7; dayNum++)
            {
                location = new Point((int)Math.Round(PN_DaysHeader.Width / 7f * dayNum), 0);
                DC.DrawLine(pen1, location.X, 0, location.X, PN_Content.Height);
            }
            location = new Point((int)Math.Round(PN_DaysHeader.Width / 7f * 7), 0);
            DC.DrawLine(pen1, location.X - 1, 0, location.X - 1, PN_Content.Height);
            Events.Draw(DC);
            PN_Scroll.Focus();
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

                if (date.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    Pen leGrosPen = new Pen(Color.FromArgb(179, 6, 144), 64);
                    DC.DrawLine(leGrosPen, location, new Point(location.X + (int)(PN_DaysHeader.Width / 7f), location.Y));
                }

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
            for (int hour = 0; hour <= 24; hour++)
            {
                Point location = new Point(0, Event.HourToPixel(hour, 0, PN_Hours.Height));

                if (hour == DateTime.Now.Hour)
                {
                    int Decalage = PN_Hours.Height / 24 / 2;
                    Pen leGrosPen = new Pen(Color.FromArgb(179, 6, 144), PN_Hours.Height / 24);
                    DC.DrawLine(leGrosPen, new Point(location.X, location.Y + Decalage), new Point(location.X + PN_Hours.Width, location.Y + Decalage));
                }

                String headerText = (hour < 10 ? "0" : "") + hour.ToString() + ":00";
                DC.DrawString(headerText, PN_DaysHeader.Font, brush, location);
                DC.DrawLine(pen, 0, Event.HourToPixel(hour + 1, 0, PN_Hours.Height), PN_Hours.Width, Event.HourToPixel(hour + 1, 0, PN_Hours.Height));
            }
        }

        private void PN_DaysHeader_Paint(object sender, PaintEventArgs e)
        {
            Fill_Days_Header(e.Graphics);
        }

        private void PN_Hours_Paint(object sender, PaintEventArgs e)
        {
            Fill_Hours_Header(e.Graphics);
        }

        private void AdjustMinInterval()
        {
            minInterval = 10;
            while (Event.HourToPixel(0, minInterval, PN_Content.Height) < 10)
                minInterval += 10;
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
        bool mouseIsDown = false;
        Pen pen = new Pen(Color.Blue, 2);

        private int RoundToMinutes(int pixel, int interval)
        {
            int pixel_interval = Event.HourToPixel(0, interval, PN_Content.Height);
            if (pixel_interval > 5)
            {
                int half_interval = (int)Math.Round(pixel_interval / 2f);

                int minutes = Event.PixelToMinutes(pixel + half_interval, PN_Content.Height);
                minutes = (int)Math.Truncate((float)minutes / interval) * interval;
                int hour = (int)Math.Truncate(minutes / 60f);
                minutes = minutes - hour * 60;
                return Event.HourToPixel(hour, minutes, PN_Content.Height);
            }
            else
                return pixel;
        }
        private void PN_Content_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
            firstMouseLocation = lastMouseLocation = e.Location;
            if (Events.TargetEvent != null)
            {
                switch (Events.TargetPart)
                {
                    case TargetPart.Top:
                        firstMouseLocation.Y =
                        lastMouseLocation.Y = RoundToMinutes(Event.HourToPixel(Events.TargetEvent.Starting.Hour, Events.TargetEvent.Starting.Minute, PN_Content.Height), minInterval);
                        break;
                    case TargetPart.Bottom:
                        firstMouseLocation.Y =
                        lastMouseLocation.Y = RoundToMinutes(Event.HourToPixel(Events.TargetEvent.Ending.Hour, Events.TargetEvent.Ending.Minute, PN_Content.Height), minInterval);
                        break;
                    default: break;
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

        private void AdjustScroll(int value)
        {
            int PN_Scroll_Mouse_Location = value - PN_Scroll.VerticalScroll.Value;
            int hour_heigth = Event.HourToPixel(1, 0, PN_Scroll.Height);

            if (PN_Scroll_Mouse_Location < 0)
            {
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + hour_heigth);
                if ((PN_Scroll.VerticalScroll.Value - hour_heigth) > hour_heigth)
                    PN_Scroll.VerticalScroll.Value -= hour_heigth;
            }
            if (PN_Scroll_Mouse_Location > PN_Scroll.Height)
            {
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - hour_heigth);
                if ((PN_Scroll.VerticalScroll.Value + hour_heigth) < PN_Content.Height)
                    PN_Scroll.VerticalScroll.Value += hour_heigth;
            }
        }

        private void PN_Content_MouseMove(object sender, MouseEventArgs e)
        {
            int day;

            day = (int)Math.Truncate(firstMouseLocation.X / (PN_Content.Width / 7F));
            Point Bottom = new Point((day + 1) * (int)(PN_Content.Width / 7F), RoundToMinutes(e.Location.Y, minInterval));
            if (mouseIsDown)
            {
                AdjustScroll(e.Location.Y);
                if (Events.TargetEvent != null)
                {
                    day = (int)Math.Truncate((e.Location.X - PN_Content.Width / 14F) / (PN_Content.Width / 7F));
                    switch (Events.TargetPart)
                    {
                        case TargetPart.Top:
                            Events.TargetEvent.Starting = LocationToDateTime(Bottom);
                            if (Events.TargetEvent.Starting > Events.TargetEvent.Ending)
                            {
                                Events.TargetPart = TargetPart.Bottom;
                                DateTime d = Events.TargetEvent.Starting;
                                Events.TargetEvent.Starting = Events.TargetEvent.Ending;
                                Events.TargetEvent.Ending = d;
                            }
                            break;
                        case TargetPart.Bottom:
                            Events.TargetEvent.Ending = LocationToDateTime(Bottom);
                            if (Events.TargetEvent.Starting > Events.TargetEvent.Ending)
                            {
                                Events.TargetPart = TargetPart.Top;
                                DateTime d = Events.TargetEvent.Starting;
                                Events.TargetEvent.Starting = Events.TargetEvent.Ending;
                                Events.TargetEvent.Ending = d;
                            }
                            break;
                        case TargetPart.Inside:
                            int deltaY = RoundToMinutes(e.Location.Y, minInterval) - RoundToMinutes(lastMouseLocation.Y, minInterval);
                            Events.TargetEvent.Starting = LocationToDateTime(new Point(e.Location.X, RoundToMinutes(Event.HourToPixel(Events.TargetEvent.Starting.Hour, Events.TargetEvent.Starting.Minute, PN_Content.Height) + deltaY, minInterval)));
                            Events.TargetEvent.Ending = LocationToDateTime(new Point(e.Location.X, RoundToMinutes(Event.HourToPixel(Events.TargetEvent.Ending.Hour, Events.TargetEvent.Ending.Minute, PN_Content.Height) + deltaY, minInterval)));
                            AjustCurrentWeek();
                            break;
                        default: break;
                    }
                    PN_Content.Refresh();
                }
                else
                {
                    PN_Content.Cursor = Cursors.Cross;
                    Point top = new Point(day * (int)(PN_Content.Width / 7F), RoundToMinutes(firstMouseLocation.Y, minInterval));
                    Rectangle border = new Rectangle(top.X, (int)Math.Min(top.Y, Bottom.Y), Bottom.X - top.X, (int)Math.Abs(Bottom.Y - top.Y));
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
            int adjust = (location.X < 0 ? (int)(PN_Content.Width / 7F) : 0);
            int days = (int)(Math.Truncate((location.X - adjust) / (PN_Content.Width / 7F)));

            date = date.AddDays(days);
            int Minutes = (int)Math.Max(Event.PixelToMinutes(RoundToMinutes(location.Y, minInterval), PN_Content.Height), 0);
            int Hours = (int)Math.Min((int)Math.Truncate(Minutes / 60f), 23);
            Minutes = Minutes - Hours * 60;
            if (Minutes >= 60)
                Minutes = 59;
            return new DateTime(date.Year, date.Month, date.Day, Hours, Minutes, 0);
        }

        private void ConludeMouseEvent()
        {

            if (mouseIsDown)
            {
                mouseIsDown = false;

                if (Events.TargetEvent != null)
                {
                    if (Events.TargetEvent.Starting > Events.TargetEvent.Ending)
                    {
                        Events.TargetPart = TargetPart.Top;
                        DateTime d = Events.TargetEvent.Starting;
                        Events.TargetEvent.Starting = Events.TargetEvent.Ending;
                        Events.TargetEvent.Ending = d;
                    }

                    TimeSpan delta = Events.TargetEvent.Ending.Subtract(Events.TargetEvent.Starting);
                    if (delta.Minutes < 15 && delta.Hours == 0)
                    {
                        Events.TargetEvent.Ending = Events.TargetEvent.Starting + new TimeSpan(0, 15, 0);
                    }
                    TableEvents tableEvents = new TableEvents(ConnexionString);
                    tableEvents.UpdateEventRecord(Events.TargetEvent);
                }
                else
                {
                    DLG_Events dlg = new DLG_Events();
                    Event Event = new Event();


                    Event.Starting = LocationToDateTime(firstMouseLocation);
                    Event.Ending = LocationToDateTime(lastMouseLocation);

                    if (Event.Starting > Event.Ending)
                    {
                        Events.TargetPart = TargetPart.Top;
                        DateTime d = Event.Starting;
                        Event.Starting = Event.Ending;
                        Event.Ending = d;

                    }
                    TimeSpan delta = Event.Ending.Subtract(Event.Starting);
                    if (delta.Minutes < 15 && delta.Hours == 0)
                    {
                        Event.Ending = Event.Starting + new TimeSpan(0, 15, 0);
                    }
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

        private void GotoCurrentWeek()
        {
            CurrentWeek = DateTime.Now;
            GetWeekEvents();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
            PN_Scroll.VerticalScroll.Value = Event.HourToPixel((int)Math.Max(DateTime.Now.Hour - 3, 0), 0, PN_Hours.Height);
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
                        mouseIsDown = false;
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.OemMinus: // Incrémenter d'un mois la semaine courrante

                    // Fonction temporaire pour voir comment dézommer
                    if (!mouseIsDown)
                    {
                        if (PN_Content.Height > 600)
                        {
                            PN_Content.Height -= 200;
                            PN_Hours.Height -= 200;
                            uC_Slider1.Value = PN_Content.Height;
                            PN_Content.Refresh();
                            PN_Hours.Refresh();
                        }
                    }
                    break;
                case Keys.Right: // Incrémenter d'une semaine la semaine courrante
                    if (!mouseIsDown)
                        Increment_Week();

                    break;
                case Keys.Oemplus: // Décrémenter d'un mois la semaine courrante

                    // Fonction temporaire pour voir comment zommer
                    if (!mouseIsDown)
                    {
                        if (PN_Content.Height < 4800)
                        {
                            PN_Content.Height += 200;
                            PN_Hours.Height += 200;
                            uC_Slider1.Value = PN_Content.Height;
                            PN_Content.Refresh();
                            PN_Hours.Refresh();
                        }
                    }
                    break;


                case Keys.Left:// Décrémenter d'une semaine la semaine courrante
                    if (!mouseIsDown)
                        Decrement_Week();
                    break;
                case Keys.Up:
                    int currentMonth = CurrentWeek.Month;
                    while (currentMonth == CurrentWeek.Month)
                        Decrement_Week();
                    break;
                case Keys.Down:
                    int month = CurrentWeek.AddDays(6).Month;
                    while (month == CurrentWeek.AddDays(6).Month)
                        Increment_Week();
                    break;
                case Keys.Space:
                    if (!mouseIsDown)
                        GotoCurrentWeek();
                    break;
                case Keys.F1:
                    new FormAide().ShowDialog();
                    break;
                case (Keys.Control | Keys.Q):
                    this.Close();
                    break;
            }

            bool result = base.ProcessCmdKey(ref msg, keyData);
            PN_Scroll.Focus();
            return result;
        }

        private void PN_Content_Resize(object sender, EventArgs e)
        {
            AdjustMinInterval();
        }

        private void updateSliderZoom()
        {
            PN_Content.Height = uC_Slider1.Value;
            PN_Hours.Height = uC_Slider1.Value;
            PN_Content.Refresh();
            PN_Hours.Refresh();
        }

        private void uC_Slider1_MouseMove(object sender, MouseEventArgs e)
        {
            updateSliderZoom();
        }

        private void uC_Slider1_MouseLeave(object sender, EventArgs e)
        {
            uC_Slider1.Hide();
            pictureBox1.Visible = true;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            uC_Slider1.Show();
            pictureBox1.Visible = false;
            uC_Slider1.Focus();
        }

        private void ChoisirCouleur(ref Color couleur)
        {
            DLG_HLSColorPicker dlg = new DLG_HLSColorPicker();
            if (dlg.ShowDialog() == DialogResult.OK)
                couleur = dlg.color;
        }

        private void ChoisirFont(Font font)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                font = dlg.Font; 
        }

        private void uC_Slider1_Load(object sender, EventArgs e)
        {

        }
    }
}
