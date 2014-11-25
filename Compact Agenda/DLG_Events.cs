using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compact_Agenda
{
    public partial class DLG_Events : Form
    {
        public Event Event { get; set; }
        private bool blockUpdate;
        public bool delete = false;
        public DLG_Events()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void lel(object sender, EventArgs e)
        {
            MessageBox.Show("lel");
        }

        private void DLG_Events_Load(object sender, EventArgs e)
        {
            delete = false;

            foreach (Enum ev in Enum.GetValues(typeof(choixEvents)))
                CB_ChoixEvent.Items.Add(ev);

            EventToDLG();
        }

        public static DateTime Klone(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0);
        }

        private void EventToDLG()
        {
            if (Event != null)
            {
                TBX_Title.Text = Event.Title;
                TBX_Description.Text = Event.Description;
                blockUpdate = true;
                DTP_Date.Value = Klone(Event.Starting);
                CSC_StartingHour.Value = Klone(Event.Starting).Hour;
                CSC_StartingMinutes.Value = Klone(Event.Starting).Minute;
                CSC_FinishingHour.Value = Klone(Event.Ending).Hour;
                CSC_FinishingMinutes.Value = Klone(Event.Ending).Minute;
                CB_ChoixEvent.SelectedItem = CB_ChoixEvent.Items[(int)Event.typeEvent];
                blockUpdate = false;
            }
            else
            {
                CB_ChoixEvent.SelectedItem = CB_ChoixEvent.Items[0];
                Event = new Event();
            }
        }

        private void TBX_Title_TextChanged(object sender, EventArgs e)
        {
            Event.Title = TBX_Title.Text;
        }

        private void TBX_Description_TextChanged(object sender, EventArgs e)
        {
            Event.Description = TBX_Description.Text;
        }

        private void DTP_Date_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                DTP_Date.Value.Month,
                                                DTP_Date.Value.Day,
                                                CSC_StartingHour.Value,
                                                CSC_StartingMinutes.Value,
                                                0);

                Event.Ending = new DateTime(DTP_Date.Value.Year,
                                            DTP_Date.Value.Month,
                                            DTP_Date.Value.Day,
                                            CSC_FinishingHour.Value,
                                            CSC_FinishingMinutes.Value,
                                            0);
            }
        }

        private void DTP_Starting_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                 DTP_Date.Value.Month,
                                                 DTP_Date.Value.Day,
                                                 CSC_StartingHour.Value,
                                                 CSC_StartingMinutes.Value,
                                                 0);
            }
        }

        private void DTP_Ending_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {

                Event.Ending = new DateTime(DTP_Date.Value.Year,
                                            DTP_Date.Value.Month,
                                            DTP_Date.Value.Day,
                                            CSC_FinishingHour.Value,
                                            CSC_FinishingMinutes.Value,
                                            0);
            }
        }

        private void BTN_Effacer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment effacer cet événement ?") == System.Windows.Forms.DialogResult.OK)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                delete = true;
                this.Close();
            }
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            if (CSC_FinishingHour.Value < CSC_StartingHour.Value ||
                (CSC_StartingHour.Value == CSC_FinishingHour.Value &&
                CSC_FinishingMinutes.Value <= CSC_StartingMinutes.Value))
                errorProvider.SetError(CSC_FinishingMinutes, "Heures incohérentes");
            else if (TBX_Title.Text == "")
                errorProvider.SetError(TBX_Title, "Le champs est vide");
            else if (TBX_Description.Text == "")
                errorProvider.SetError(TBX_Description, "Le champs est vide");
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CB_ChoixEvent_SelectedValueChanged(object sender, EventArgs e)
        {
            Event.typeEvent = (choixEvents)CB_ChoixEvent.SelectedItem;
        }

        private void FBTN_IncrementWeek_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FlashButton_Ok_Click(object sender, EventArgs e)
        {
            if (CSC_FinishingHour.Value < CSC_StartingHour.Value ||
                (CSC_StartingHour.Value == CSC_FinishingHour.Value &&
                CSC_FinishingMinutes.Value <= CSC_StartingMinutes.Value))
                errorProvider.SetError(CSC_FinishingMinutes, "Heures incohérentes");
            else if (TBX_Title.Text == "")
                errorProvider.SetError(TBX_Title, "Le champs est vide");
            else if (TBX_Description.Text == "")
                errorProvider.SetError(TBX_Description, "Le champs est vide");
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FlashButton_Effacer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment effacer cet événement ?") == System.Windows.Forms.DialogResult.OK)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                delete = true;
                this.Close();
            }
        }
    }
}
