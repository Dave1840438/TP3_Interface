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
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.CustomUserControl1 = new Compact_Agenda.CustomSelectControl();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.customSelectControl1 = new Compact_Agenda.CustomSelectControl();
            this.customSelectControl2 = new Compact_Agenda.CustomSelectControl();
            this.BTN_Effacer = new System.Windows.Forms.Button();
            this.customSelectControl3 = new Compact_Agenda.CustomSelectControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(171, 261);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 6;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(70, 261);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 5;
            this.BTN_Cancel.TabStop = false;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // CustomUserControl1
            // 
            this.CustomUserControl1.Leap = 1;
            this.CustomUserControl1.Location = new System.Drawing.Point(54, 172);
            this.CustomUserControl1.MaximumValue = 23;
            this.CustomUserControl1.MinimumValue = 0;
            this.CustomUserControl1.Name = "CustomUserControl1";
            this.CustomUserControl1.Size = new System.Drawing.Size(25, 77);
            this.CustomUserControl1.StartValue = 0;
            this.CustomUserControl1.TabIndex = 47;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // customSelectControl1
            // 
            this.customSelectControl1.Leap = 5;
            this.customSelectControl1.Location = new System.Drawing.Point(104, 172);
            this.customSelectControl1.MaximumValue = 59;
            this.customSelectControl1.MinimumValue = 0;
            this.customSelectControl1.Name = "customSelectControl1";
            this.customSelectControl1.Size = new System.Drawing.Size(25, 77);
            this.customSelectControl1.StartValue = 0;
            this.customSelectControl1.TabIndex = 48;
            // 
            // customSelectControl2
            // 
            this.customSelectControl2.Leap = 1;
            this.customSelectControl2.Location = new System.Drawing.Point(186, 172);
            this.customSelectControl2.MaximumValue = 23;
            this.customSelectControl2.MinimumValue = 0;
            this.customSelectControl2.Name = "customSelectControl2";
            this.customSelectControl2.Size = new System.Drawing.Size(25, 77);
            this.customSelectControl2.StartValue = 0;
            this.customSelectControl2.TabIndex = 49;
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
            // customSelectControl3
            // 
            this.customSelectControl3.Leap = 5;
            this.customSelectControl3.Location = new System.Drawing.Point(236, 172);
            this.customSelectControl3.MaximumValue = 59;
            this.customSelectControl3.MinimumValue = 0;
            this.customSelectControl3.Name = "customSelectControl3";
            this.customSelectControl3.Size = new System.Drawing.Size(25, 77);
            this.customSelectControl3.StartValue = 0;
            this.customSelectControl3.TabIndex = 50;
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
            // DLG_Events
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(373, 296);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customSelectControl3);
            this.Controls.Add(this.customSelectControl2);
            this.Controls.Add(this.customSelectControl1);
            this.Controls.Add(this.BTN_Effacer);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBX_Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_Title);
            this.Controls.Add(this.CustomUserControl1);
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
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Compact_Agenda.CustomSelectControl CustomUserControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private CustomSelectControl customSelectControl3;
        private CustomSelectControl customSelectControl2;
        private CustomSelectControl customSelectControl1;
        private System.Windows.Forms.Button BTN_Effacer;
    }
}