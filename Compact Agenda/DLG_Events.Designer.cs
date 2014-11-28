namespace Compact_Agenda
{
    partial class DLG_Events
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLG_Events));
            this.TBX_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_Description = new System.Windows.Forms.TextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_ChoixEvent = new System.Windows.Forms.ComboBox();
            this.FlashButton_Ok = new FlashButton.FlashButton();
            this.FBTN_IncrementWeek = new FlashButton.FlashButton();
            this.CSC_StartingHour = new Compact_Agenda.CustomSelectControl();
            this.CSC_StartingMinutes = new Compact_Agenda.CustomSelectControl();
            this.CSC_FinishingHour = new Compact_Agenda.CustomSelectControl();
            this.CSC_FinishingMinutes = new Compact_Agenda.CustomSelectControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TBX_Title
            // 
            this.TBX_Title.Location = new System.Drawing.Point(86, 32);
            this.TBX_Title.Name = "TBX_Title";
            this.TBX_Title.Size = new System.Drawing.Size(100, 20);
            this.TBX_Title.TabIndex = 0;
            this.TBX_Title.TextChanged += new System.EventHandler(this.TBX_Title_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description: ";
            // 
            // TBX_Description
            // 
            this.TBX_Description.Location = new System.Drawing.Point(86, 58);
            this.TBX_Description.Multiline = true;
            this.TBX_Description.Name = "TBX_Description";
            this.TBX_Description.Size = new System.Drawing.Size(252, 85);
            this.TBX_Description.TabIndex = 1;
            this.TBX_Description.TextChanged += new System.EventHandler(this.TBX_Description_TextChanged);
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(86, 149);
            this.DTP_Date.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.DTP_Date.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(125, 20);
            this.DTP_Date.TabIndex = 3;
            this.DTP_Date.ValueChanged += new System.EventHandler(this.DTP_Date_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Début :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(85, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fin :";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(192, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "h";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(192, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "h";
            // 
            // CB_ChoixEvent
            // 
            this.CB_ChoixEvent.FormattingEnabled = true;
            this.CB_ChoixEvent.Location = new System.Drawing.Point(218, 32);
            this.CB_ChoixEvent.Name = "CB_ChoixEvent";
            this.CB_ChoixEvent.Size = new System.Drawing.Size(78, 21);
            this.CB_ChoixEvent.TabIndex = 56;
            this.CB_ChoixEvent.SelectedValueChanged += new System.EventHandler(this.CB_ChoixEvent_SelectedValueChanged);
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
            this.FlashButton_Ok.Location = new System.Drawing.Point(283, 306);
            this.FlashButton_Ok.Name = "FlashButton_Ok";
            this.FlashButton_Ok.Size = new System.Drawing.Size(80, 25);
            this.FlashButton_Ok.TabIndex = 59;
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
            this.FBTN_IncrementWeek.Location = new System.Drawing.Point(353, 0);
            this.FBTN_IncrementWeek.Name = "FBTN_IncrementWeek";
            this.FBTN_IncrementWeek.Size = new System.Drawing.Size(22, 22);
            this.FBTN_IncrementWeek.TabIndex = 57;
            this.FBTN_IncrementWeek.Click += new System.EventHandler(this.FBTN_IncrementWeek_Click);
            // 
            // CSC_StartingHour
            // 
            this.CSC_StartingHour.Leap = 1;
            this.CSC_StartingHour.Location = new System.Drawing.Point(128, 195);
            this.CSC_StartingHour.MaximumValue = 0;
            this.CSC_StartingHour.MinimumValue = 0;
            this.CSC_StartingHour.Name = "CSC_StartingHour";
            this.CSC_StartingHour.Size = new System.Drawing.Size(58, 57);
            this.CSC_StartingHour.StartValue = 0;
            this.CSC_StartingHour.TabIndex = 60;
            this.CSC_StartingHour.Value = 0;
            this.CSC_StartingHour.ValueChanged += new System.EventHandler(this.DTP_Starting_ValueChanged);
            // 
            // CSC_StartingMinutes
            // 
            this.CSC_StartingMinutes.Leap = 1;
            this.CSC_StartingMinutes.Location = new System.Drawing.Point(211, 195);
            this.CSC_StartingMinutes.MaximumValue = 0;
            this.CSC_StartingMinutes.MinimumValue = 0;
            this.CSC_StartingMinutes.Name = "CSC_StartingMinutes";
            this.CSC_StartingMinutes.Size = new System.Drawing.Size(58, 57);
            this.CSC_StartingMinutes.StartValue = 0;
            this.CSC_StartingMinutes.TabIndex = 61;
            this.CSC_StartingMinutes.Value = 0;
            this.CSC_StartingMinutes.ValueChanged += new System.EventHandler(this.DTP_Starting_ValueChanged);
            // 
            // CSC_FinishingHour
            // 
            this.CSC_FinishingHour.Leap = 1;
            this.CSC_FinishingHour.Location = new System.Drawing.Point(128, 258);
            this.CSC_FinishingHour.MaximumValue = 0;
            this.CSC_FinishingHour.MinimumValue = 0;
            this.CSC_FinishingHour.Name = "CSC_FinishingHour";
            this.CSC_FinishingHour.Size = new System.Drawing.Size(58, 57);
            this.CSC_FinishingHour.StartValue = 0;
            this.CSC_FinishingHour.TabIndex = 62;
            this.CSC_FinishingHour.Value = 0;
            this.CSC_FinishingHour.ValueChanged += new System.EventHandler(this.DTP_Ending_ValueChanged);
            // 
            // CSC_FinishingMinutes
            // 
            this.CSC_FinishingMinutes.Leap = 1;
            this.CSC_FinishingMinutes.Location = new System.Drawing.Point(211, 258);
            this.CSC_FinishingMinutes.MaximumValue = 0;
            this.CSC_FinishingMinutes.MinimumValue = 0;
            this.CSC_FinishingMinutes.Name = "CSC_FinishingMinutes";
            this.CSC_FinishingMinutes.Size = new System.Drawing.Size(58, 57);
            this.CSC_FinishingMinutes.StartValue = 0;
            this.CSC_FinishingMinutes.TabIndex = 63;
            this.CSC_FinishingMinutes.Value = 0;
            this.CSC_FinishingMinutes.ValueChanged += new System.EventHandler(this.DTP_Ending_ValueChanged);
            // 
            // DLG_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(83)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(375, 343);
            this.Controls.Add(this.CSC_FinishingMinutes);
            this.Controls.Add(this.CSC_FinishingHour);
            this.Controls.Add(this.CSC_StartingMinutes);
            this.Controls.Add(this.CSC_StartingHour);
            this.Controls.Add(this.FlashButton_Ok);
            this.Controls.Add(this.FBTN_IncrementWeek);
            this.Controls.Add(this.CB_ChoixEvent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBX_Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DLG_Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DLG_Events";
            this.Load += new System.EventHandler(this.DLG_Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBX_Description;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_ChoixEvent;
        private FlashButton.FlashButton FBTN_IncrementWeek;
        private FlashButton.FlashButton FlashButton_Ok;
        private CustomSelectControl CSC_StartingHour;
        private CustomSelectControl CSC_StartingMinutes;
        private CustomSelectControl CSC_FinishingMinutes;
        private CustomSelectControl CSC_FinishingHour;
    }
}