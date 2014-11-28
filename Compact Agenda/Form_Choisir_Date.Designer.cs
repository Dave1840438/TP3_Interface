namespace Compact_Agenda
{
    partial class Form_Choisir_Date
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Choisir_Date));
            this.DATE_Choisir_Date_Courante = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.FlashButton_Ok = new FlashButton.FlashButton();
            this.FBTN_IncrementWeek = new FlashButton.FlashButton();
            this.SuspendLayout();
            // 
            // DATE_Choisir_Date_Courante
            // 
            this.DATE_Choisir_Date_Courante.Location = new System.Drawing.Point(37, 81);
            this.DATE_Choisir_Date_Courante.Name = "DATE_Choisir_Date_Courante";
            this.DATE_Choisir_Date_Courante.Size = new System.Drawing.Size(200, 20);
            this.DATE_Choisir_Date_Courante.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisir une date: ";
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
            this.FlashButton_Ok.Location = new System.Drawing.Point(179, 115);
            this.FlashButton_Ok.Name = "FlashButton_Ok";
            this.FlashButton_Ok.Size = new System.Drawing.Size(80, 25);
            this.FlashButton_Ok.TabIndex = 60;
            this.FlashButton_Ok.Click += new System.EventHandler(this.FlashButton_Ok_Click);
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
            this.FBTN_IncrementWeek.Location = new System.Drawing.Point(249, 0);
            this.FBTN_IncrementWeek.Name = "FBTN_IncrementWeek";
            this.FBTN_IncrementWeek.Size = new System.Drawing.Size(22, 22);
            this.FBTN_IncrementWeek.TabIndex = 59;
            this.FBTN_IncrementWeek.Click += new System.EventHandler(this.FBTN_IncrementWeek_Click);
            // 
            // Form_Choisir_Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(197)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(271, 152);
            this.Controls.Add(this.FlashButton_Ok);
            this.Controls.Add(this.FBTN_IncrementWeek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DATE_Choisir_Date_Courante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Choisir_Date";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Choisir_Date";
            this.Load += new System.EventHandler(this.Form_Choisir_Date_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DATE_Choisir_Date_Courante;
        private System.Windows.Forms.Label label1;
        private FlashButton.FlashButton FBTN_IncrementWeek;
        private FlashButton.FlashButton FlashButton_Ok;
    }
}