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
            this.TBX_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_Description = new System.Windows.Forms.TextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTN_Effacer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FBT_Accepter = new FlashButton.FlashButton();
            this.flashButton1 = new FlashButton.FlashButton();
            this.CB_ChoixEvent = new System.Windows.Forms.ComboBox();
            this.customSelectControl1 = new Compact_Agenda.CustomSelectControl();
            this.CSC_FinishingMinutes = new Compact_Agenda.CustomSelectControl();
            this.CSC_FinishingHour = new Compact_Agenda.CustomSelectControl();
            this.CSC_StartingMinutes = new Compact_Agenda.CustomSelectControl();
            this.CSC_StartingHour = new Compact_Agenda.CustomSelectControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TBX_Title
            // 
            this.TBX_Title.Location = new System.Drawing.Point(70, 12);
            this.TBX_Title.Name = "TBX_Title";
            this.TBX_Title.Size = new System.Drawing.Size(100, 20);
            this.TBX_Title.TabIndex = 0;
            this.TBX_Title.TextChanged += new System.EventHandler(this.TBX_Title_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // TBX_Description
            // 
            this.TBX_Description.Location = new System.Drawing.Point(70, 38);
            this.TBX_Description.Multiline = true;
            this.TBX_Description.Name = "TBX_Description";
            this.TBX_Description.Size = new System.Drawing.Size(290, 85);
            this.TBX_Description.TabIndex = 1;
            this.TBX_Description.TextChanged += new System.EventHandler(this.TBX_Description_TextChanged);
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(70, 129);
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
            this.label3.Location = new System.Drawing.Point(42, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Début :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fin :";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // BTN_Effacer
            // 
            this.BTN_Effacer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Effacer.Location = new System.Drawing.Point(286, 261);
            this.BTN_Effacer.Name = "BTN_Effacer";
            this.BTN_Effacer.Size = new System.Drawing.Size(74, 23);
            this.BTN_Effacer.TabIndex = 46;
            this.BTN_Effacer.Text = "Effacer";
            this.BTN_Effacer.UseVisualStyleBackColor = true;
            this.BTN_Effacer.Click += new System.EventHandler(this.BTN_Effacer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "h";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "h";
            // 
            // FBT_Accepter
            // 
            this.FBT_Accepter.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Neutral;
            this.FBT_Accepter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBT_Accepter.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Click;
            this.FBT_Accepter.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Disable;
            this.FBT_Accepter.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Neutral;
            this.FBT_Accepter.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_Accepter_Over;
            this.FBT_Accepter.Location = new System.Drawing.Point(208, 255);
            this.FBT_Accepter.Name = "FBT_Accepter";
            this.FBT_Accepter.Size = new System.Drawing.Size(35, 29);
            this.FBT_Accepter.TabIndex = 53;
            this.FBT_Accepter.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Neutral;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton1.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Click;
            this.flashButton1.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Disable;
            this.flashButton1.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Neutral;
            this.flashButton1.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_Annuler_Over;
            this.flashButton1.Location = new System.Drawing.Point(137, 253);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.Size = new System.Drawing.Size(33, 31);
            this.flashButton1.TabIndex = 54;
            this.flashButton1.Click += new System.EventHandler(this.flashButton1_Click);
            // 
            // CB_ChoixEvent
            // 
            this.CB_ChoixEvent.FormattingEnabled = true;
            this.CB_ChoixEvent.Location = new System.Drawing.Point(12, 76);
            this.CB_ChoixEvent.Name = "CB_ChoixEvent";
            this.CB_ChoixEvent.Size = new System.Drawing.Size(51, 21);
            this.CB_ChoixEvent.TabIndex = 56;
            this.CB_ChoixEvent.SelectedValueChanged += new System.EventHandler(this.CB_ChoixEvent_SelectedValueChanged);
            // 
            // customSelectControl1
            // 
            this.customSelectControl1.Leap = 2;
            this.customSelectControl1.Location = new System.Drawing.Point(277, 141);
            this.customSelectControl1.MaximumValue = 23;
            this.customSelectControl1.MinimumValue = 0;
            this.customSelectControl1.Name = "customSelectControl1";
            this.customSelectControl1.Size = new System.Drawing.Size(58, 77);
            this.customSelectControl1.StartValue = 3;
            this.customSelectControl1.TabIndex = 55;
            this.customSelectControl1.Value = 0;
            // 
            // CSC_FinishingMinutes
            // 
            this.CSC_FinishingMinutes.Leap = 5;
            this.CSC_FinishingMinutes.Location = new System.Drawing.Point(236, 172);
            this.CSC_FinishingMinutes.MaximumValue = 59;
            this.CSC_FinishingMinutes.MinimumValue = 0;
            this.CSC_FinishingMinutes.Name = "CSC_FinishingMinutes";
            this.CSC_FinishingMinutes.Size = new System.Drawing.Size(25, 77);
            this.CSC_FinishingMinutes.StartValue = 0;
            this.CSC_FinishingMinutes.TabIndex = 50;
            this.CSC_FinishingMinutes.Value = 0;
            this.CSC_FinishingMinutes.ValueChanged += new System.EventHandler(this.DTP_Ending_ValueChanged);
            // 
            // CSC_FinishingHour
            // 
            this.CSC_FinishingHour.Leap = 1;
            this.CSC_FinishingHour.Location = new System.Drawing.Point(186, 172);
            this.CSC_FinishingHour.MaximumValue = 23;
            this.CSC_FinishingHour.MinimumValue = 0;
            this.CSC_FinishingHour.Name = "CSC_FinishingHour";
            this.CSC_FinishingHour.Size = new System.Drawing.Size(25, 77);
            this.CSC_FinishingHour.StartValue = 0;
            this.CSC_FinishingHour.TabIndex = 49;
            this.CSC_FinishingHour.Value = 0;
            this.CSC_FinishingHour.ValueChanged += new System.EventHandler(this.DTP_Ending_ValueChanged);
            // 
            // CSC_StartingMinutes
            // 
            this.CSC_StartingMinutes.Leap = 5;
            this.CSC_StartingMinutes.Location = new System.Drawing.Point(104, 172);
            this.CSC_StartingMinutes.MaximumValue = 59;
            this.CSC_StartingMinutes.MinimumValue = 0;
            this.CSC_StartingMinutes.Name = "CSC_StartingMinutes";
            this.CSC_StartingMinutes.Size = new System.Drawing.Size(25, 77);
            this.CSC_StartingMinutes.StartValue = 0;
            this.CSC_StartingMinutes.TabIndex = 48;
            this.CSC_StartingMinutes.Value = 0;
            this.CSC_StartingMinutes.ValueChanged += new System.EventHandler(this.DTP_Starting_ValueChanged);
            // 
            // CSC_StartingHour
            // 
            this.CSC_StartingHour.Leap = 1;
            this.CSC_StartingHour.Location = new System.Drawing.Point(54, 172);
            this.CSC_StartingHour.MaximumValue = 23;
            this.CSC_StartingHour.MinimumValue = 0;
            this.CSC_StartingHour.Name = "CSC_StartingHour";
            this.CSC_StartingHour.Size = new System.Drawing.Size(25, 77);
            this.CSC_StartingHour.StartValue = 0;
            this.CSC_StartingHour.TabIndex = 47;
            this.CSC_StartingHour.Value = 0;
            this.CSC_StartingHour.ValueChanged += new System.EventHandler(this.DTP_Starting_ValueChanged);
            // 
            // DLG_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 296);
            this.Controls.Add(this.CB_ChoixEvent);
            this.Controls.Add(this.customSelectControl1);
            this.Controls.Add(this.flashButton1);
            this.Controls.Add(this.FBT_Accepter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CSC_FinishingMinutes);
            this.Controls.Add(this.CSC_FinishingHour);
            this.Controls.Add(this.CSC_StartingMinutes);
            this.Controls.Add(this.BTN_Effacer);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBX_Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Title);
            this.Controls.Add(this.CSC_StartingHour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private Compact_Agenda.CustomSelectControl CSC_StartingHour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private CustomSelectControl CSC_FinishingMinutes;
        private CustomSelectControl CSC_FinishingHour;
        private CustomSelectControl CSC_StartingMinutes;
        private System.Windows.Forms.Button BTN_Effacer;
        private FlashButton.FlashButton FBT_Accepter;
        private FlashButton.FlashButton flashButton1;
        private CustomSelectControl customSelectControl1;
        private System.Windows.Forms.ComboBox CB_ChoixEvent;
    }
}