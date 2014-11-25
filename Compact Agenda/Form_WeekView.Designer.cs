namespace Compact_Agenda
{
    partial class Form_WeekView
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
            this.PN_Frame = new System.Windows.Forms.Panel();
            this.CMENU_Semaine_courante = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changerLaCouleurDuFondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerLaCouleurDesLignesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeEtCouleurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMENU_Jour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.choisirLaJourneeCouranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDeFondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeEtCouleurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FBTN_DecrementWeek = new FlashButton.FlashButton();
            this.FBTN_IncrementWeek = new FlashButton.FlashButton();
            this.PN_Scroll = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Content = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Hours = new Compact_Agenda.DoubleBufferPanel();
            this.PN_DaysHeader = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Frame.SuspendLayout();
            this.CMENU_Semaine_courante.SuspendLayout();
            this.CMENU_Jour.SuspendLayout();
            this.PN_Scroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // PN_Frame
            // 
            this.PN_Frame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Frame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(6)))), ((int)(((byte)(179)))));
            this.PN_Frame.Controls.Add(this.PN_Scroll);
            this.PN_Frame.Controls.Add(this.FBTN_DecrementWeek);
            this.PN_Frame.Controls.Add(this.FBTN_IncrementWeek);
            this.PN_Frame.Controls.Add(this.PN_DaysHeader);
            this.PN_Frame.Location = new System.Drawing.Point(0, 0);
            this.PN_Frame.Name = "PN_Frame";
            this.PN_Frame.Size = new System.Drawing.Size(743, 589);
            this.PN_Frame.TabIndex = 4;
            // 
            // CMENU_Semaine_courante
            // 
            this.CMENU_Semaine_courante.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerLaCouleurDuFondToolStripMenuItem,
            this.changerLaCouleurDesLignesToolStripMenuItem,
            this.policeEtCouleurToolStripMenuItem});
            this.CMENU_Semaine_courante.Name = "CMENU_Semaine_courante";
            this.CMENU_Semaine_courante.Size = new System.Drawing.Size(239, 70);
            // 
            // changerLaCouleurDuFondToolStripMenuItem
            // 
            this.changerLaCouleurDuFondToolStripMenuItem.Name = "changerLaCouleurDuFondToolStripMenuItem";
            this.changerLaCouleurDuFondToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.changerLaCouleurDuFondToolStripMenuItem.Text = "Changer la couleur du fond...";
            // 
            // changerLaCouleurDesLignesToolStripMenuItem
            // 
            this.changerLaCouleurDesLignesToolStripMenuItem.Name = "changerLaCouleurDesLignesToolStripMenuItem";
            this.changerLaCouleurDesLignesToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.changerLaCouleurDesLignesToolStripMenuItem.Text = "Changer la couleur des lignes...";
            // 
            // policeEtCouleurToolStripMenuItem
            // 
            this.policeEtCouleurToolStripMenuItem.Name = "policeEtCouleurToolStripMenuItem";
            this.policeEtCouleurToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.policeEtCouleurToolStripMenuItem.Text = "Police et Couleur...";
            // 
            // CMENU_Jour
            // 
            this.CMENU_Jour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choisirLaJourneeCouranteToolStripMenuItem,
            this.couleurDeFondToolStripMenuItem,
            this.policeEtCouleurToolStripMenuItem1});
            this.CMENU_Jour.Name = "CMENU_Jour";
            this.CMENU_Jour.Size = new System.Drawing.Size(230, 70);
            // 
            // choisirLaJourneeCouranteToolStripMenuItem
            // 
            this.choisirLaJourneeCouranteToolStripMenuItem.Name = "choisirLaJourneeCouranteToolStripMenuItem";
            this.choisirLaJourneeCouranteToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.choisirLaJourneeCouranteToolStripMenuItem.Text = "Choisir la semaine courante...";
            // 
            // couleurDeFondToolStripMenuItem
            // 
            this.couleurDeFondToolStripMenuItem.Name = "couleurDeFondToolStripMenuItem";
            this.couleurDeFondToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.couleurDeFondToolStripMenuItem.Text = "Couleur de fond...";
            // 
            // policeEtCouleurToolStripMenuItem1
            // 
            this.policeEtCouleurToolStripMenuItem1.Name = "policeEtCouleurToolStripMenuItem1";
            this.policeEtCouleurToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.policeEtCouleurToolStripMenuItem1.Text = "Police et couleur...";
            // 
            // FBTN_DecrementWeek
            // 
            this.FBTN_DecrementWeek.BackgroundImage = global::Compact_Agenda.Properties.Resources.ARROW_Neutre1;
            this.FBTN_DecrementWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_DecrementWeek.ImageClick = global::Compact_Agenda.Properties.Resources.ARROW_CLICK_2;
            this.FBTN_DecrementWeek.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Left_Disable;
            this.FBTN_DecrementWeek.ImageNeutral = global::Compact_Agenda.Properties.Resources.ARROW_Neutre1;
            this.FBTN_DecrementWeek.ImageOver = global::Compact_Agenda.Properties.Resources.ARROW_OVER_2;
            this.FBTN_DecrementWeek.Location = new System.Drawing.Point(3, 2);
            this.FBTN_DecrementWeek.Name = "FBTN_DecrementWeek";
            this.FBTN_DecrementWeek.Size = new System.Drawing.Size(32, 32);
            this.FBTN_DecrementWeek.TabIndex = 2;
            this.FBTN_DecrementWeek.Click += new System.EventHandler(this.FBTN_DecrementWeek_Click);
            // 
            // FBTN_IncrementWeek
            // 
            this.FBTN_IncrementWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FBTN_IncrementWeek.BackgroundImage = global::Compact_Agenda.Properties.Resources.ARROW_Neutre2;
            this.FBTN_IncrementWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_IncrementWeek.ImageClick = global::Compact_Agenda.Properties.Resources.ARROW_CLICK;
            this.FBTN_IncrementWeek.ImageDisable = global::Compact_Agenda.Properties.Resources.ICON_Right_Disable;
            this.FBTN_IncrementWeek.ImageNeutral = global::Compact_Agenda.Properties.Resources.ARROW_Neutre2;
            this.FBTN_IncrementWeek.ImageOver = global::Compact_Agenda.Properties.Resources.ARROW_OVER;
            this.FBTN_IncrementWeek.Location = new System.Drawing.Point(708, 2);
            this.FBTN_IncrementWeek.Name = "FBTN_IncrementWeek";
            this.FBTN_IncrementWeek.Size = new System.Drawing.Size(32, 32);
            this.FBTN_IncrementWeek.TabIndex = 3;
            this.FBTN_IncrementWeek.Click += new System.EventHandler(this.FBTN_IncrementWeek_Click);
            // 
            // PN_Scroll
            // 
            this.PN_Scroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Scroll.AutoScroll = true;
            this.PN_Scroll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PN_Scroll.Controls.Add(this.PN_Content);
            this.PN_Scroll.Controls.Add(this.PN_Hours);
            this.PN_Scroll.Location = new System.Drawing.Point(3, 34);
            this.PN_Scroll.Margin = new System.Windows.Forms.Padding(0);
            this.PN_Scroll.Name = "PN_Scroll";
            this.PN_Scroll.Size = new System.Drawing.Size(737, 552);
            this.PN_Scroll.TabIndex = 1;
            this.PN_Scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PN_Scroll_Scroll);
            this.PN_Scroll.Resize += new System.EventHandler(this.PN_Scroll_Resize);
            // 
            // PN_Content
            // 
            this.PN_Content.ContextMenuStrip = this.CMENU_Semaine_courante;
            this.PN_Content.Location = new System.Drawing.Point(35, -1);
            this.PN_Content.Name = "PN_Content";
            this.PN_Content.Size = new System.Drawing.Size(628, 522);
            this.PN_Content.TabIndex = 0;
            this.PN_Content.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Content_Paint);
            this.PN_Content.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseDoubleClick);
            this.PN_Content.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseDown);
            this.PN_Content.MouseEnter += new System.EventHandler(this.PN_Scroll_MouseEnter);
            this.PN_Content.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseMove);
            this.PN_Content.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PN_Content_MouseUp);
            this.PN_Content.Resize += new System.EventHandler(this.PN_Content_Resize);
            // 
            // PN_Hours
            // 
            this.PN_Hours.Location = new System.Drawing.Point(0, -1);
            this.PN_Hours.Name = "PN_Hours";
            this.PN_Hours.Size = new System.Drawing.Size(36, 518);
            this.PN_Hours.TabIndex = 1;
            this.PN_Hours.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Hours_Paint);
            // 
            // PN_DaysHeader
            // 
            this.PN_DaysHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(6)))), ((int)(((byte)(179)))));
            this.PN_DaysHeader.ContextMenuStrip = this.CMENU_Jour;
            this.PN_DaysHeader.Location = new System.Drawing.Point(38, 2);
            this.PN_DaysHeader.Margin = new System.Windows.Forms.Padding(0);
            this.PN_DaysHeader.Name = "PN_DaysHeader";
            this.PN_DaysHeader.Size = new System.Drawing.Size(628, 32);
            this.PN_DaysHeader.TabIndex = 0;
            this.PN_DaysHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_DaysHeader_Paint);
            // 
            // Form_WeekView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 589);
            this.Controls.Add(this.PN_Frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form_WeekView";
            this.Text = "Agenda compacte...";
            this.Load += new System.EventHandler(this.Form_WeekView_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_WeekView_KeyUp);
            this.PN_Frame.ResumeLayout(false);
            this.CMENU_Semaine_courante.ResumeLayout(false);
            this.CMENU_Jour.ResumeLayout(false);
            this.PN_Scroll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferPanel PN_DaysHeader;
        private DoubleBufferPanel PN_Scroll;
        private DoubleBufferPanel PN_Content;
        private DoubleBufferPanel PN_Hours;
        private FlashButton.FlashButton FBTN_DecrementWeek;
        private FlashButton.FlashButton FBTN_IncrementWeek;
        private System.Windows.Forms.Panel PN_Frame;
        private System.Windows.Forms.ContextMenuStrip CMENU_Semaine_courante;
        private System.Windows.Forms.ToolStripMenuItem changerLaCouleurDuFondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerLaCouleurDesLignesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policeEtCouleurToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMENU_Jour;
        private System.Windows.Forms.ToolStripMenuItem choisirLaJourneeCouranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurDeFondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policeEtCouleurToolStripMenuItem1;

    }
}