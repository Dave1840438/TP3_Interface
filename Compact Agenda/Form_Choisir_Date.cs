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
    public partial class Form_Choisir_Date : Form
    {
        public Form_Choisir_Date()
        {
            InitializeComponent();
        }
        //Cette fonction permet de bouger l'application meme si elle n'a pas de border
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
        private void Form_Choisir_Date_Load(object sender, EventArgs e)
        {

        }

        //Cette fonction s'occupe de fermer l'application de choix de semaine
        private void FBTN_IncrementWeek_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Cette fonction s'occupe d'enregistrer les modifications
        private void FlashButton_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public DateTime GetDateTime()
        {
            return DATE_Choisir_Date_Courante.Value;
        }
    }
}
