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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_WeekView));
            this.PN_Frame = new System.Windows.Forms.Panel();
            this.CMENU_Semaine_courante = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changerLaCouleurDuFondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duFondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desLignesPleinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desLignesPointilléesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDesCaractèresDesÉvènementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeEtCouleurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMENU_Heures = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.deLaCouleurDeSurlignementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.FBTN_DecrementWeek = new FlashButton.FlashButton();
            this.FBTN_IncrementWeek = new FlashButton.FlashButton();
            this.CMENU_Jour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.choisirLaJourneeCouranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDeFondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDeFondToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurDePoliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deLaCouleurDeSurlignementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerLaPoliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uC_Slider1 = new UC_Slider.UC_Slider();
            this.CMENU_Evenement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporterDuneSemaineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dupliquerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PN_Scroll = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Content = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Hours = new Compact_Agenda.DoubleBufferPanel();
            this.PN_DaysHeader = new Compact_Agenda.DoubleBufferPanel();
            this.PN_Frame.SuspendLayout();
            this.CMENU_Semaine_courante.SuspendLayout();
            this.CMENU_Heures.SuspendLayout();
            this.CMENU_Jour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CMENU_Evenement.SuspendLayout();
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
            this.policeEtCouleurToolStripMenuItem});
            this.CMENU_Semaine_courante.Name = "CMENU_Semaine_courante";
            this.CMENU_Semaine_courante.Size = new System.Drawing.Size(317, 48);
            // 
            // changerLaCouleurDuFondToolStripMenuItem
            // 
            this.changerLaCouleurDuFondToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duFondToolStripMenuItem,
            this.desLignesPleinesToolStripMenuItem,
            this.desLignesPointilléesToolStripMenuItem,
            this.couleurDesCaractèresDesÉvènementsToolStripMenuItem});
            this.changerLaCouleurDuFondToolStripMenuItem.Name = "changerLaCouleurDuFondToolStripMenuItem";
            this.changerLaCouleurDuFondToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.changerLaCouleurDuFondToolStripMenuItem.Text = "Changer la couleur";
            // 
            // duFondToolStripMenuItem
            // 
            this.duFondToolStripMenuItem.Name = "duFondToolStripMenuItem";
            this.duFondToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.duFondToolStripMenuItem.Text = "Du fond...";
            this.duFondToolStripMenuItem.Click += new System.EventHandler(this.duFondToolStripMenuItem_Click);
            // 
            // desLignesPleinesToolStripMenuItem
            // 
            this.desLignesPleinesToolStripMenuItem.Name = "desLignesPleinesToolStripMenuItem";
            this.desLignesPleinesToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.desLignesPleinesToolStripMenuItem.Text = "Des lignes pleines...";
            this.desLignesPleinesToolStripMenuItem.Click += new System.EventHandler(this.desLignesPleinesToolStripMenuItem_Click);
            // 
            // desLignesPointilléesToolStripMenuItem
            // 
            this.desLignesPointilléesToolStripMenuItem.Name = "desLignesPointilléesToolStripMenuItem";
            this.desLignesPointilléesToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.desLignesPointilléesToolStripMenuItem.Text = "Des lignes pointillées...";
            this.desLignesPointilléesToolStripMenuItem.Click += new System.EventHandler(this.desLignesPointilléesToolStripMenuItem_Click);
            // 
            // couleurDesCaractèresDesÉvènementsToolStripMenuItem
            // 
            this.couleurDesCaractèresDesÉvènementsToolStripMenuItem.Name = "couleurDesCaractèresDesÉvènementsToolStripMenuItem";
            this.couleurDesCaractèresDesÉvènementsToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.couleurDesCaractèresDesÉvènementsToolStripMenuItem.Text = "Couleur des caractères des évènements...";
            this.couleurDesCaractèresDesÉvènementsToolStripMenuItem.Click += new System.EventHandler(this.couleurDesCaractèresDesÉvènementsToolStripMenuItem_Click);
            // 
            // policeEtCouleurToolStripMenuItem
            // 
            this.policeEtCouleurToolStripMenuItem.Name = "policeEtCouleurToolStripMenuItem";
            this.policeEtCouleurToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.policeEtCouleurToolStripMenuItem.Text = "Changer la police d\'écriture des évènements...";
            this.policeEtCouleurToolStripMenuItem.Click += new System.EventHandler(this.policeEtCouleurToolStripMenuItem_Click);
            // 
            // CMENU_Heures
            // 
            this.CMENU_Heures.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem5});
            this.CMENU_Heures.Name = "CMENU_Jour";
            this.CMENU_Heures.Size = new System.Drawing.Size(175, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.deLaCouleurDeSurlignementToolStripMenuItem1});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem2.Text = "Changer la couleur";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(241, 22);
            this.toolStripMenuItem3.Text = "De Fond...";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(241, 22);
            this.toolStripMenuItem4.Text = "De la police...";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // deLaCouleurDeSurlignementToolStripMenuItem1
            // 
            this.deLaCouleurDeSurlignementToolStripMenuItem1.Name = "deLaCouleurDeSurlignementToolStripMenuItem1";
            this.deLaCouleurDeSurlignementToolStripMenuItem1.Size = new System.Drawing.Size(241, 22);
            this.deLaCouleurDeSurlignementToolStripMenuItem1.Text = "De la couleur de surlignement...";
            this.deLaCouleurDeSurlignementToolStripMenuItem1.Click += new System.EventHandler(this.deLaCouleurDeSurlignementToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem5.Text = "Changer la police";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
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
            // CMENU_Jour
            // 
            this.CMENU_Jour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choisirLaJourneeCouranteToolStripMenuItem,
            this.couleurDeFondToolStripMenuItem,
            this.changerLaPoliceToolStripMenuItem});
            this.CMENU_Jour.Name = "CMENU_Jour";
            this.CMENU_Jour.Size = new System.Drawing.Size(230, 70);
            // 
            // choisirLaJourneeCouranteToolStripMenuItem
            // 
            this.choisirLaJourneeCouranteToolStripMenuItem.Name = "choisirLaJourneeCouranteToolStripMenuItem";
            this.choisirLaJourneeCouranteToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.choisirLaJourneeCouranteToolStripMenuItem.Text = "Choisir la semaine courante...";
            this.choisirLaJourneeCouranteToolStripMenuItem.Click += new System.EventHandler(this.choisirLaJourneeCouranteToolStripMenuItem_Click);
            // 
            // couleurDeFondToolStripMenuItem
            // 
            this.couleurDeFondToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couleurDeFondToolStripMenuItem1,
            this.couleurDePoliceToolStripMenuItem,
            this.deLaCouleurDeSurlignementToolStripMenuItem});
            this.couleurDeFondToolStripMenuItem.Name = "couleurDeFondToolStripMenuItem";
            this.couleurDeFondToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.couleurDeFondToolStripMenuItem.Text = "Changer la couleur";
            // 
            // couleurDeFondToolStripMenuItem1
            // 
            this.couleurDeFondToolStripMenuItem1.Name = "couleurDeFondToolStripMenuItem1";
            this.couleurDeFondToolStripMenuItem1.Size = new System.Drawing.Size(241, 22);
            this.couleurDeFondToolStripMenuItem1.Text = "De Fond...";
            this.couleurDeFondToolStripMenuItem1.Click += new System.EventHandler(this.couleurDeFondToolStripMenuItem1_Click);
            // 
            // couleurDePoliceToolStripMenuItem
            // 
            this.couleurDePoliceToolStripMenuItem.Name = "couleurDePoliceToolStripMenuItem";
            this.couleurDePoliceToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.couleurDePoliceToolStripMenuItem.Text = "De la police...";
            this.couleurDePoliceToolStripMenuItem.Click += new System.EventHandler(this.couleurDePoliceToolStripMenuItem_Click);
            // 
            // deLaCouleurDeSurlignementToolStripMenuItem
            // 
            this.deLaCouleurDeSurlignementToolStripMenuItem.Name = "deLaCouleurDeSurlignementToolStripMenuItem";
            this.deLaCouleurDeSurlignementToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.deLaCouleurDeSurlignementToolStripMenuItem.Text = "De la couleur de surlignement...";
            this.deLaCouleurDeSurlignementToolStripMenuItem.Click += new System.EventHandler(this.deLaCouleurDeSurlignementToolStripMenuItem_Click);
            // 
            // changerLaPoliceToolStripMenuItem
            // 
            this.changerLaPoliceToolStripMenuItem.Name = "changerLaPoliceToolStripMenuItem";
            this.changerLaPoliceToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.changerLaPoliceToolStripMenuItem.Text = "Changer la police";
            this.changerLaPoliceToolStripMenuItem.Click += new System.EventHandler(this.changerLaPoliceToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(87)))), ((int)(((byte)(83)))));
            this.pictureBox1.BackgroundImage = global::Compact_Agenda.Properties.Resources.Loupe_Neutre;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(705, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // uC_Slider1
            // 
            this.uC_Slider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Slider1.BarDisableImage = ((System.Drawing.Image)(resources.GetObject("uC_Slider1.BarDisableImage")));
            this.uC_Slider1.BarEnableImage = ((System.Drawing.Image)(resources.GetObject("uC_Slider1.BarEnableImage")));
            this.uC_Slider1.CursorDisableImage = ((System.Drawing.Image)(resources.GetObject("uC_Slider1.CursorDisableImage")));
            this.uC_Slider1.CursorEnableImage = ((System.Drawing.Image)(resources.GetObject("uC_Slider1.CursorEnableImage")));
            this.uC_Slider1.CursorOverImage = ((System.Drawing.Image)(resources.GetObject("uC_Slider1.CursorOverImage")));
            this.uC_Slider1.Location = new System.Drawing.Point(705, 34);
            this.uC_Slider1.Maximum = 100;
            this.uC_Slider1.Minimum = -100;
            this.uC_Slider1.Name = "uC_Slider1";
            this.uC_Slider1.Size = new System.Drawing.Size(20, 296);
            this.uC_Slider1.TabIndex = 2;
            this.uC_Slider1.Value = 100;
            this.uC_Slider1.MouseLeave += new System.EventHandler(this.uC_Slider1_MouseLeave);
            this.uC_Slider1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uC_Slider1_MouseMove);
            // 
            // CMENU_Evenement
            // 
            this.CMENU_Evenement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.effacerToolStripMenuItem,
            this.reporterDuneSemaineToolStripMenuItem,
            this.dupliquerToolStripMenuItem});
            this.CMENU_Evenement.Name = "CMENU_Evenement";
            this.CMENU_Evenement.Size = new System.Drawing.Size(209, 92);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.modifierToolStripMenuItem.Text = "Modifier...";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // effacerToolStripMenuItem
            // 
            this.effacerToolStripMenuItem.Name = "effacerToolStripMenuItem";
            this.effacerToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.effacerToolStripMenuItem.Text = "Effacer...";
            this.effacerToolStripMenuItem.Click += new System.EventHandler(this.effacerToolStripMenuItem_Click);
            // 
            // reporterDuneSemaineToolStripMenuItem
            // 
            this.reporterDuneSemaineToolStripMenuItem.Name = "reporterDuneSemaineToolStripMenuItem";
            this.reporterDuneSemaineToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.reporterDuneSemaineToolStripMenuItem.Text = "Reporter d\'une semaine...";
            this.reporterDuneSemaineToolStripMenuItem.Click += new System.EventHandler(this.reporterDuneSemaineToolStripMenuItem_Click);
            // 
            // dupliquerToolStripMenuItem
            // 
            this.dupliquerToolStripMenuItem.Name = "dupliquerToolStripMenuItem";
            this.dupliquerToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.dupliquerToolStripMenuItem.Text = "Dupliquer...";
            this.dupliquerToolStripMenuItem.Click += new System.EventHandler(this.dupliquerToolStripMenuItem_Click);
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
            this.PN_Hours.ContextMenuStrip = this.CMENU_Heures;
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uC_Slider1);
            this.Controls.Add(this.PN_Frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form_WeekView";
            this.Text = "Agenda compacte...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_WeekView_FormClosing);
            this.Load += new System.EventHandler(this.Form_WeekView_Load);
            this.Resize += new System.EventHandler(this.Form_WeekView_Resize);
            this.PN_Frame.ResumeLayout(false);
            this.CMENU_Semaine_courante.ResumeLayout(false);
            this.CMENU_Heures.ResumeLayout(false);
            this.CMENU_Jour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CMENU_Evenement.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem policeEtCouleurToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMENU_Jour;
        private System.Windows.Forms.ToolStripMenuItem choisirLaJourneeCouranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurDeFondToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UC_Slider.UC_Slider uC_Slider1;
        private System.Windows.Forms.ToolStripMenuItem couleurDeFondToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem couleurDePoliceToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMENU_Evenement;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporterDuneSemaineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dupliquerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duFondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desLignesPleinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desLignesPointilléesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurDesCaractèresDesÉvènementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerLaPoliceToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMENU_Heures;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem deLaCouleurDeSurlignementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deLaCouleurDeSurlignementToolStripMenuItem;

    }
}