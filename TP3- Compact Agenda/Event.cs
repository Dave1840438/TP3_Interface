using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Demo
{
    public class Event
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Starting { get; set; }
        public DateTime Ending { get; set; }
        public System.Windows.Forms.Panel ParentPanel { get; set; }

        public Event()
        {
            Starting = DateTime.Now;
            Ending = DateTime.Now;
        }
        public Event(string Id, string Title, string Description, DateTime Starting, DateTime Ending)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Starting = Starting;
            this.Ending = Ending;
        }
        public Event(string Id, string Title, string Description, string Starting, string Ending)
        {
            this.Id = Id;
            this.Title = TextFilter.FromSql(Title);
            this.Description = TextFilter.FromSql(Description);
            this.Starting = DateTime.Parse(Starting);
            this.Ending = DateTime.Parse(Ending);
        }

        public Event(Event copy)
        {
            Id = copy.Id;
            Title = copy.Title;
            Description = copy.Description;
            Starting = copy.Starting;
            Ending = copy.Ending;
            ParentPanel = copy.ParentPanel;
        }
        public Event Klone()
        {
            Event klone = new Event(this);
            return klone;
        }

        public static int PixelToMinutes(int Pixel, int Height)
        {
            float totalMinutesInDay = 24F * 60F;
            return (int)Math.Round((Pixel / (float)Height) * totalMinutesInDay);
        }

          
        public static int HourToPixel(int Hour, int Minute, int Height)
        {
            float minutes = Hour * 60F + Minute;
            float totalMinutesInDay = 24F * 60F;
            return (int)Math.Round((minutes / totalMinutesInDay) * Height);
        }
        public static int HourToPixel(DateTime date, int Height)
        {
            return HourToPixel(date.Hour, date.Minute, Height);
        }

        public static int DayOfWeekToPixel(int dayNum, int Width)
        {
            return (int)Math.Round(dayNum / 7F * Width);
        }

        public static int DayOfWeekToPixel(DateTime date, int Width)
        {
            return DayOfWeekToPixel((int)date.DayOfWeek, Width);
        }

        public Rectangle GetBorder()
        {
            if (ParentPanel != null)
            {
                Point Location = new Point(DayOfWeekToPixel(Starting, ParentPanel.Width), HourToPixel(Starting, ParentPanel.Height));
                int Height = HourToPixel(Ending, ParentPanel.Height) - HourToPixel(Starting, ParentPanel.Height);
                int width = (int)Math.Round(ParentPanel.Width / 7F);

                Rectangle border = new Rectangle(Location, new Size(width, Height));
                return border;
            }
            return new Rectangle();
        }
        public void Draw(Graphics DC)
        {
            DC.FillRectangle(new SolidBrush(Color.LightBlue), GetBorder());
            DC.DrawRectangle(new Pen(Color.Black, 1), GetBorder());
            DC.DrawString(Title, new Font("Arial", 10f), new SolidBrush(Color.Black), GetBorder().Location);
        }
    }
}
