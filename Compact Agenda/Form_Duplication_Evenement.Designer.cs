namespace Compact_Agenda
{
    partial class Form_Duplication_Evenement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Duplication_Evenement));
            this.NUMUD_Qte = new System.Windows.Forms.NumericUpDown();
            this.CB_Choix_De_Saut = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FBTN_IncrementWeek = new FlashButton.FlashButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FlashButton_Ok = new FlashButton.FlashButton();
            ((System.ComponentModel.ISupportInitialize)(this.NUMUD_Qte)).BeginInit();
            this.SuspendLayout();
            // 
            // NUMUD_Qte
            // 
            this.NUMUD_Qte.Location = new System.Drawing.Point(145, 97);
            this.NUMUD_Qte.Name = "NUMUD_Qte";
            this.NUMUD_Qte.Size = new System.Drawing.Size(73, 20);
            this.NUMUD_Qte.TabIndex = 0;
            // 
            // CB_Choix_De_Saut
            // 
            this.CB_Choix_De_Saut.AutoCompleteCustomSource.AddRange(new string[] {
            "Jour",
            "Semaine",
            "Mois",
            "Année"});
            this.CB_Choix_De_Saut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Choix_De_Saut.FormattingEnabled = true;
            this.CB_Choix_De_Saut.Items.AddRange(new object[] {
            "Jour",
            "Semaine",
            "Mois",
            "Année"});
            this.CB_Choix_De_Saut.Location = new System.Drawing.Point(145, 70);
            this.CB_Choix_De_Saut.Name = "CB_Choix_De_Saut";
            this.CB_Choix_De_Saut.Size = new System.Drawing.Size(108, 21);
            this.CB_Choix_De_Saut.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisir la fréquence: ";
            // 
            // FBTN_IncrementWeek
            // 
            this.FBTN_IncrementWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FBTN_IncrementWeek.BackgroundImage = global::Compact_Agenda.Properties.Resources.Exite_Neutral_;
            this.FBTN_IncrementWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_IncrementWeek.ImageClick = global::Compact_Agenda.Properties.Resources.Exite_Click;
            this.FBTN_IncrementWeek.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Right_Disable;
            this.FBTN_IncrementWeek.ImageNeutral = global::Compact_Agenda.Properties.Resources.Exite_Neutral_;
            this.FBTN_IncrementWeek.ImageOver = global::Compact_Agenda.Properties.Resources.Exite_over;
            this.FBTN_IncrementWeek.Location = new System.Drawing.Point(262, 0);
            this.FBTN_IncrementWeek.Name = "FBTN_IncrementWeek";
            this.FBTN_IncrementWeek.Size = new System.Drawing.Size(22, 22);
            this.FBTN_IncrementWeek.TabIndex = 60;
            this.FBTN_IncrementWeek.Click += new System.EventHandler(this.FBTN_IncrementWeek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Choisir la quantité: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Dupliquer: ";
            // 
            // FlashButton_Ok
            // 
            this.FlashButton_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlashButton_Ok.BackgroundImage = global::Compact_Agenda.Properties.Resources.Ok_DLG_Neutral_2;
            this.FlashButton_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlashButton_Ok.ImageClick = global::Compact_Agenda.Properties.Resources.Ok_DLG_Click_2;
            this.FlashButton_Ok.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Right_Disable;
            this.FlashButton_Ok.ImageNeutral = global::Compact_Agenda.Properties.Resources.Ok_DLG_Neutral_2;
            this.FlashButton_Ok.ImageOver = global::Compact_Agenda.Properties.Resources.Ok_DLG_Over_2;
            this.FlashButton_Ok.Location = new System.Drawing.Point(192, 128);
            this.FlashButton_Ok.Name = "FlashButton_Ok";
            this.FlashButton_Ok.Size = new System.Drawing.Size(80, 25);
            this.FlashButton_Ok.TabIndex = 63;
            this.FlashButton_Ok.Click += new System.EventHandler(this.FlashButton_Ok_Click);
            // 
            // Form_Duplication_Evenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.FlashButton_Ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FBTN_IncrementWeek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Choix_De_Saut);
            this.Controls.Add(this.NUMUD_Qte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Duplication_Evenement";
            this.Text = "Form_Duplication_Evenement";
            this.Load += new System.EventHandler(this.Form_Duplication_Evenement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUMUD_Qte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUMUD_Qte;
        private System.Windows.Forms.ComboBox CB_Choix_De_Saut;
        private System.Windows.Forms.Label label1;
        private FlashButton.FlashButton FBTN_IncrementWeek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FlashButton.FlashButton FlashButton_Ok;

    }
}