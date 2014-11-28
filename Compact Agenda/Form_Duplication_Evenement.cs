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
    public partial class Form_Duplication_Evenement : Form
    {
        public Form_Duplication_Evenement()
        {
            InitializeComponent();
            CB_Choix_De_Saut.SelectedIndex = 0;
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

        private void Form_Duplication_Evenement_Load(object sender, EventArgs e)
        {

        }

        //Cette Fonction permet de quitter l'application
        private void FBTN_IncrementWeek_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //retourne le choix de l'utilisateur 
        public string GetInterval()
        {
            return CB_Choix_De_Saut.SelectedItem.ToString();
        }

        //retourne le choix de l'utilisateur 
        public int GetNbFois()
        {
            return (int)NUMUD_Qte.Value;
        }
        //Cette Fonction Enregistre les infromations choisi par l'utilisateur
        private void FlashButton_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
