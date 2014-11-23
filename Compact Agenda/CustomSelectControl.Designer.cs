namespace Compact_Agenda
{
    partial class CustomSelectControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flashButton1 = new FlashButton.FlashButton();
            this.FBT_Up = new FlashButton.FlashButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(0, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(24, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "▽";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "△";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flashButton1
            // 
            this.flashButton1.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_Down_Neutral;
            this.flashButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashButton1.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_Down_Click;
            this.flashButton1.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Down_Disable;
            this.flashButton1.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_Down_Neutral;
            this.flashButton1.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_Down_Over;
            this.flashButton1.Location = new System.Drawing.Point(30, 54);
            this.flashButton1.Name = "flashButton1";
            this.flashButton1.Size = new System.Drawing.Size(22, 22);
            this.flashButton1.TabIndex = 4;
            this.flashButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FBT_Up
            // 
            this.FBT_Up.BackgroundImage = global::Compact_Agenda.Properties.Resources.ICON_Up_Neutral;
            this.FBT_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBT_Up.ImageClick = global::Compact_Agenda.Properties.Resources.ICON_Up_Click;
            this.FBT_Up.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Up_Disable;
            this.FBT_Up.ImageNeutral = global::Compact_Agenda.Properties.Resources.ICON_Up_Neutral;
            this.FBT_Up.ImageOver = global::Compact_Agenda.Properties.Resources.ICON_Up_Over;
            this.FBT_Up.Location = new System.Drawing.Point(30, 3);
            this.FBT_Up.Name = "FBT_Up";
            this.FBT_Up.Size = new System.Drawing.Size(22, 20);
            this.FBT_Up.TabIndex = 3;
            this.FBT_Up.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustomSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flashButton1);
            this.Controls.Add(this.FBT_Up);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "CustomSelectControl";
            this.Size = new System.Drawing.Size(58, 77);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FlashButton.FlashButton FBT_Up;
        private FlashButton.FlashButton flashButton1;
    }
}
