﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compact_Agenda
{
    public enum choixEvents
    {
        Général = 0, Travail, Loisir, Santé, Important, Autre
    }


    public class Event
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Starting { get; set; }
        public DateTime Ending { get; set; }
        public System.Windows.Forms.Panel ParentPanel { get; set; }
        public choixEvents typeEvent { get; set; }

        public Event()
        {
            Starting = DateTime.Now;
            Ending = DateTime.Now;
            typeEvent = choixEvents.Général;
        }
        public Event(string Id, string Title, string Description, DateTime Starting, DateTime Ending, int eventType)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Starting = Starting;
            this.Ending = Ending;
            this.typeEvent = (choixEvents)eventType;
        }
        public Event(string Id, string Title, string Description, string Starting, string Ending, string eventType)
        {
            this.Id = Id;
            this.Title = TextFilter.FromSql(Title);
            this.Description = TextFilter.FromSql(Description);
            this.Starting = DateTime.Parse(Starting);
            this.Ending = DateTime.Parse(Ending);
            this.typeEvent = (choixEvents)Enum.Parse(typeof(choixEvents), eventType);
        }

        public Event(Event copy)
        {
            Id = copy.Id;
            Title = copy.Title;
            Description = copy.Description;
            Starting = copy.Starting;
            Ending = copy.Ending;
            ParentPanel = copy.ParentPanel;
            typeEvent = copy.typeEvent;
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
                Point Location = new Point(DayOfWeekToPixel(Starting, ParentPanel.Width) + 2, HourToPixel(Starting, ParentPanel.Height));
                int Height = HourToPixel(Ending, ParentPanel.Height) - HourToPixel(Starting, ParentPanel.Height);
                int width = (int)Math.Round(ParentPanel.Width / 7F);

                Rectangle border = new Rectangle(Location, new Size(width - 3, Height));
                return border;
            }
            return new Rectangle();
        }

        public static string TwoDigits(int n)
        {
            return (n < 10 ? "0" : "") + n.ToString();
        }
        public static string TimeToString(DateTime date)
        {
            return TwoDigits(date.Hour) + ":" + TwoDigits(date.Minute);
        }
        public void Draw(Graphics DC)
        {
            Color couleur = Color.Black;

            switch (typeEvent)
            {
                case choixEvents.Général:
                    couleur = Color.FromArgb(107, 184, 230);
                    break;
                case choixEvents.Important:
                    couleur = Color.FromArgb(236, 87, 83);
                    break;
                case choixEvents.Autre:
                    couleur = Color.FromArgb(243, 167, 91);
                    break;
                case choixEvents.Loisir:
                    couleur = Color.FromArgb(139, 197, 61);
                    break;
                case choixEvents.Santé:
                    couleur = Color.FromArgb(243, 116, 202);
                    break;
                case choixEvents.Travail:
                    couleur = Color.FromArgb(243, 231, 61);
                    break;
                default:
                    couleur = Color.Black;
                    break;
            }

            DC.FillRectangle(new SolidBrush(couleur), GetBorder());
            DC.DrawRectangle(new Pen(Color.Black, 1), GetBorder());
            string time = TimeToString(Starting) + "-" + TimeToString(Ending);
            Pen lignePointillee = new Pen(Color.Red, 40);
            lignePointillee.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            int fontSize = 8;

            using (Font font2 = new Font("Arial", fontSize + 1, FontStyle.Bold, GraphicsUnit.Point))
            {
                System.Windows.Forms.TextFormatFlags flags = System.Windows.Forms.TextFormatFlags.WordEllipsis | System.Windows.Forms.TextFormatFlags.HorizontalCenter |
                    System.Windows.Forms.TextFormatFlags.WordBreak;
                Rectangle border = GetBorder();
                fontSize += 6;

                System.Windows.Forms.TextRenderer.DrawText(DC, time, Form_WeekView.policeEvenements, border, Form_WeekView.couleurPoliceEvenements, flags);
                border = new Rectangle(border.Location.X, border.Location.Y + fontSize, border.Width, border.Height - fontSize);

                System.Windows.Forms.TextRenderer.DrawText(DC, "---------------------", font2, border, Form_WeekView.couleurPoliceEvenements, flags);
                border = new Rectangle(border.Location.X, border.Location.Y + fontSize, border.Width, border.Height - fontSize);

                System.Windows.Forms.TextRenderer.DrawText(DC, Title, Form_WeekView.policeEvenements, border, Form_WeekView.couleurPoliceEvenements, flags);
                border = new Rectangle(border.Location.X, border.Location.Y + (fontSize), border.Width, border.Height - fontSize);

                System.Windows.Forms.TextRenderer.DrawText(DC, "---------------------", font2, border, Form_WeekView.couleurPoliceEvenements, flags);
                border = new Rectangle(border.Location.X, border.Location.Y + (fontSize), border.Width, border.Height - fontSize);

                flags = System.Windows.Forms.TextFormatFlags.WordBreak;
                System.Windows.Forms.TextRenderer.DrawText(DC, Description, Form_WeekView.policeEvenements, border, Form_WeekView.couleurPoliceEvenements, flags);


            }
        }
    }
}
