namespace Compact_Agenda
{
    partial class FormAide
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
            this.Aide = new System.Windows.Forms.Label();
            this.FBTN_IncrementWeek = new FlashButton.FlashButton();
            this.SuspendLayout();
            // 
            // Aide
            // 
            this.Aide.AutoSize = true;
            this.Aide.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aide.ForeColor = System.Drawing.Color.White;
            this.Aide.Location = new System.Drawing.Point(93, 19);
            this.Aide.Name = "Aide";
            this.Aide.Size = new System.Drawing.Size(86, 39);
            this.Aide.TabIndex = 0;
            this.Aide.Text = "Aide";
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
            this.FBTN_IncrementWeek.Location = new System.Drawing.Point(248, 0);
            this.FBTN_IncrementWeek.Name = "FBTN_IncrementWeek";
            this.FBTN_IncrementWeek.Size = new System.Drawing.Size(22, 22);
            this.FBTN_IncrementWeek.TabIndex = 58;
            this.FBTN_IncrementWeek.Click += new System.EventHandler(this.FBTN_IncrementWeek_Click);
            // 
            // FormAide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(184)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(270, 406);
            this.Controls.Add(this.FBTN_IncrementWeek);
            this.Controls.Add(this.Aide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAide";
            this.Text = "FormAide";
            this.Load += new System.EventHandler(this.FormAide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Aide;
        private FlashButton.FlashButton FBTN_IncrementWeek;
    }
}