namespace aogl1
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.menuLeave = new System.Windows.Forms.Button();
            this.panelLaser = new System.Windows.Forms.Panel();
            this.goTest = new System.Windows.Forms.Button();
            this.goDriver = new System.Windows.Forms.Button();
            this.goConnect = new System.Windows.Forms.Button();
            this.menuLaser = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.goGrbl = new System.Windows.Forms.Button();
            this.goSettings = new System.Windows.Forms.Button();
            this.menuSettings = new System.Windows.Forms.Button();
            this.panelFile = new System.Windows.Forms.Panel();
            this.goLeave = new System.Windows.Forms.Button();
            this.goExport = new System.Windows.Forms.Button();
            this.goLoadGCode = new System.Windows.Forms.Button();
            this.goLoadFile = new System.Windows.Forms.Button();
            this.menuFile = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.splitControl = new System.Windows.Forms.SplitContainer();
            this.panelTerminal = new System.Windows.Forms.Panel();
            this.panelTerminalWindow = new System.Windows.Forms.Panel();
            this.listBoxTerminal = new System.Windows.Forms.ListBox();
            this.panelCommandLine = new System.Windows.Forms.Panel();
            this.commandLine = new System.Windows.Forms.TextBox();
            this.panelCaret = new System.Windows.Forms.Panel();
            this.labelCaret = new System.Windows.Forms.Label();
            this.labelTerminal = new System.Windows.Forms.Label();
            this.panelControlSliders = new System.Windows.Forms.Panel();
            this.panelControlButtons = new System.Windows.Forms.Panel();
            this.buttonLaserOff = new System.Windows.Forms.Button();
            this.laserPower = new System.Windows.Forms.NumericUpDown();
            this.buttonLaserOn = new System.Windows.Forms.Button();
            this.buttonDOWNRIGHT = new System.Windows.Forms.Button();
            this.buttonDOWN = new System.Windows.Forms.Button();
            this.buttonDOWNLEFT = new System.Windows.Forms.Button();
            this.buttonRIGHT = new System.Windows.Forms.Button();
            this.buttonHOME = new System.Windows.Forms.Button();
            this.buttonLEFT = new System.Windows.Forms.Button();
            this.buttonUPRIGHT = new System.Windows.Forms.Button();
            this.buttonUP = new System.Windows.Forms.Button();
            this.buttonUPLEFT = new System.Windows.Forms.Button();
            this.panelSliders = new System.Windows.Forms.Panel();
            this.sliderFeedrate = new System.Windows.Forms.TrackBar();
            this.sliderStep = new System.Windows.Forms.TrackBar();
            this.labelControl = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.textStatusBox = new System.Windows.Forms.TextBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelForForms = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelLaser.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitControl)).BeginInit();
            this.splitControl.Panel1.SuspendLayout();
            this.splitControl.Panel2.SuspendLayout();
            this.splitControl.SuspendLayout();
            this.panelTerminal.SuspendLayout();
            this.panelTerminalWindow.SuspendLayout();
            this.panelCommandLine.SuspendLayout();
            this.panelCaret.SuspendLayout();
            this.panelControlSliders.SuspendLayout();
            this.panelControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laserPower)).BeginInit();
            this.panelSliders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFeedrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderStep)).BeginInit();
            this.panelStatus.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.panelSideMenu.Controls.Add(this.menuLeave);
            this.panelSideMenu.Controls.Add(this.panelLaser);
            this.panelSideMenu.Controls.Add(this.menuLaser);
            this.panelSideMenu.Controls.Add(this.panelSettings);
            this.panelSideMenu.Controls.Add(this.menuSettings);
            this.panelSideMenu.Controls.Add(this.panelFile);
            this.panelSideMenu.Controls.Add(this.menuFile);
            this.panelSideMenu.Controls.Add(this.panelTop);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(64, 745);
            this.panelSideMenu.TabIndex = 0;
            // 
            // menuLeave
            // 
            this.menuLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuLeave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuLeave.FlatAppearance.BorderSize = 0;
            this.menuLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuLeave.ForeColor = System.Drawing.Color.White;
            this.menuLeave.Image = ((System.Drawing.Image)(resources.GetObject("menuLeave.Image")));
            this.menuLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuLeave.Location = new System.Drawing.Point(0, 683);
            this.menuLeave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuLeave.Name = "menuLeave";
            this.menuLeave.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.menuLeave.Size = new System.Drawing.Size(64, 62);
            this.menuLeave.TabIndex = 7;
            this.menuLeave.Text = "Wyjdź";
            this.menuLeave.UseVisualStyleBackColor = true;
            this.menuLeave.Click += new System.EventHandler(this.menuLeave_Click);
            // 
            // panelLaser
            // 
            this.panelLaser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelLaser.Controls.Add(this.goTest);
            this.panelLaser.Controls.Add(this.goDriver);
            this.panelLaser.Controls.Add(this.goConnect);
            this.panelLaser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLaser.Location = new System.Drawing.Point(0, 450);
            this.panelLaser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLaser.Name = "panelLaser";
            this.panelLaser.Size = new System.Drawing.Size(64, 111);
            this.panelLaser.TabIndex = 6;
            // 
            // goTest
            // 
            this.goTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.goTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.goTest.Enabled = false;
            this.goTest.FlatAppearance.BorderSize = 0;
            this.goTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goTest.ForeColor = System.Drawing.Color.White;
            this.goTest.Location = new System.Drawing.Point(0, 74);
            this.goTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goTest.Name = "goTest";
            this.goTest.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goTest.Size = new System.Drawing.Size(64, 37);
            this.goTest.TabIndex = 5;
            this.goTest.Text = "Wykonaj grawer testowy";
            this.goTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goTest.UseVisualStyleBackColor = false;
            this.goTest.Click += new System.EventHandler(this.goTest_Click);
            // 
            // goDriver
            // 
            this.goDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.goDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.goDriver.FlatAppearance.BorderSize = 0;
            this.goDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goDriver.ForeColor = System.Drawing.Color.White;
            this.goDriver.Location = new System.Drawing.Point(0, 37);
            this.goDriver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goDriver.Name = "goDriver";
            this.goDriver.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goDriver.Size = new System.Drawing.Size(64, 37);
            this.goDriver.TabIndex = 4;
            this.goDriver.Text = "Instaluj sterownik";
            this.goDriver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goDriver.UseVisualStyleBackColor = false;
            this.goDriver.Click += new System.EventHandler(this.goDriver_Click);
            // 
            // goConnect
            // 
            this.goConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.goConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.goConnect.FlatAppearance.BorderSize = 0;
            this.goConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goConnect.ForeColor = System.Drawing.Color.White;
            this.goConnect.Location = new System.Drawing.Point(0, 0);
            this.goConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goConnect.Name = "goConnect";
            this.goConnect.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goConnect.Size = new System.Drawing.Size(64, 37);
            this.goConnect.TabIndex = 3;
            this.goConnect.Text = "Połącz";
            this.goConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goConnect.UseVisualStyleBackColor = false;
            this.goConnect.Click += new System.EventHandler(this.goConnect_Click);
            // 
            // menuLaser
            // 
            this.menuLaser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuLaser.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuLaser.FlatAppearance.BorderSize = 0;
            this.menuLaser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuLaser.ForeColor = System.Drawing.Color.White;
            this.menuLaser.Image = ((System.Drawing.Image)(resources.GetObject("menuLaser.Image")));
            this.menuLaser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuLaser.Location = new System.Drawing.Point(0, 388);
            this.menuLaser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuLaser.Name = "menuLaser";
            this.menuLaser.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.menuLaser.Size = new System.Drawing.Size(64, 62);
            this.menuLaser.TabIndex = 5;
            this.menuLaser.Text = "Laser";
            this.menuLaser.UseVisualStyleBackColor = true;
            this.menuLaser.Click += new System.EventHandler(this.menuLaser_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelSettings.Controls.Add(this.goGrbl);
            this.panelSettings.Controls.Add(this.goSettings);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettings.Location = new System.Drawing.Point(0, 314);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(64, 74);
            this.panelSettings.TabIndex = 4;
            // 
            // goGrbl
            // 
            this.goGrbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.goGrbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goGrbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.goGrbl.FlatAppearance.BorderSize = 0;
            this.goGrbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goGrbl.ForeColor = System.Drawing.Color.White;
            this.goGrbl.Location = new System.Drawing.Point(0, 37);
            this.goGrbl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goGrbl.Name = "goGrbl";
            this.goGrbl.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goGrbl.Size = new System.Drawing.Size(64, 37);
            this.goGrbl.TabIndex = 4;
            this.goGrbl.Text = "Konfiguracja grbl";
            this.goGrbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goGrbl.UseVisualStyleBackColor = false;
            // 
            // goSettings
            // 
            this.goSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.goSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.goSettings.FlatAppearance.BorderSize = 0;
            this.goSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goSettings.ForeColor = System.Drawing.Color.White;
            this.goSettings.Location = new System.Drawing.Point(0, 0);
            this.goSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goSettings.Name = "goSettings";
            this.goSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goSettings.Size = new System.Drawing.Size(64, 37);
            this.goSettings.TabIndex = 3;
            this.goSettings.Text = "Ustawienia";
            this.goSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goSettings.UseVisualStyleBackColor = false;
            // 
            // menuSettings
            // 
            this.menuSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuSettings.FlatAppearance.BorderSize = 0;
            this.menuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuSettings.ForeColor = System.Drawing.Color.White;
            this.menuSettings.Image = ((System.Drawing.Image)(resources.GetObject("menuSettings.Image")));
            this.menuSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuSettings.Location = new System.Drawing.Point(0, 252);
            this.menuSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.menuSettings.Size = new System.Drawing.Size(64, 62);
            this.menuSettings.TabIndex = 3;
            this.menuSettings.Text = "Opcje";
            this.menuSettings.UseVisualStyleBackColor = true;
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // panelFile
            // 
            this.panelFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelFile.Controls.Add(this.goLeave);
            this.panelFile.Controls.Add(this.goExport);
            this.panelFile.Controls.Add(this.goLoadGCode);
            this.panelFile.Controls.Add(this.goLoadFile);
            this.panelFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFile.Location = new System.Drawing.Point(0, 104);
            this.panelFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(64, 148);
            this.panelFile.TabIndex = 2;
            // 
            // goLeave
            // 
            this.goLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.goLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.goLeave.FlatAppearance.BorderSize = 0;
            this.goLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goLeave.ForeColor = System.Drawing.Color.White;
            this.goLeave.Location = new System.Drawing.Point(0, 111);
            this.goLeave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goLeave.Name = "goLeave";
            this.goLeave.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goLeave.Size = new System.Drawing.Size(64, 37);
            this.goLeave.TabIndex = 3;
            this.goLeave.Text = "Wyjdź";
            this.goLeave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goLeave.UseVisualStyleBackColor = false;
            this.goLeave.Click += new System.EventHandler(this.goLeave_Click);
            // 
            // goExport
            // 
            this.goExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.goExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.goExport.Enabled = false;
            this.goExport.FlatAppearance.BorderSize = 0;
            this.goExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goExport.ForeColor = System.Drawing.Color.White;
            this.goExport.Location = new System.Drawing.Point(0, 74);
            this.goExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goExport.Name = "goExport";
            this.goExport.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goExport.Size = new System.Drawing.Size(64, 37);
            this.goExport.TabIndex = 2;
            this.goExport.Text = "Eksportuj...";
            this.goExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goExport.UseVisualStyleBackColor = false;
            this.goExport.Click += new System.EventHandler(this.goExport_Click);
            // 
            // goLoadGCode
            // 
            this.goLoadGCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.goLoadGCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goLoadGCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.goLoadGCode.FlatAppearance.BorderSize = 0;
            this.goLoadGCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goLoadGCode.ForeColor = System.Drawing.Color.White;
            this.goLoadGCode.Location = new System.Drawing.Point(0, 37);
            this.goLoadGCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goLoadGCode.Name = "goLoadGCode";
            this.goLoadGCode.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goLoadGCode.Size = new System.Drawing.Size(64, 37);
            this.goLoadGCode.TabIndex = 1;
            this.goLoadGCode.Text = "Wczytaj GCode...";
            this.goLoadGCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goLoadGCode.UseVisualStyleBackColor = false;
            this.goLoadGCode.Click += new System.EventHandler(this.goLoadGCode_Click);
            // 
            // goLoadFile
            // 
            this.goLoadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.goLoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goLoadFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.goLoadFile.FlatAppearance.BorderSize = 0;
            this.goLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goLoadFile.ForeColor = System.Drawing.Color.White;
            this.goLoadFile.Location = new System.Drawing.Point(0, 0);
            this.goLoadFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goLoadFile.Name = "goLoadFile";
            this.goLoadFile.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goLoadFile.Size = new System.Drawing.Size(64, 37);
            this.goLoadFile.TabIndex = 0;
            this.goLoadFile.Text = "Wczytaj obraz...";
            this.goLoadFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goLoadFile.UseVisualStyleBackColor = false;
            this.goLoadFile.Click += new System.EventHandler(this.goLoadFile_Click);
            // 
            // menuFile
            // 
            this.menuFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuFile.FlatAppearance.BorderSize = 0;
            this.menuFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuFile.ForeColor = System.Drawing.Color.White;
            this.menuFile.Image = ((System.Drawing.Image)(resources.GetObject("menuFile.Image")));
            this.menuFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuFile.Location = new System.Drawing.Point(0, 42);
            this.menuFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuFile.Name = "menuFile";
            this.menuFile.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.menuFile.Size = new System.Drawing.Size(64, 62);
            this.menuFile.TabIndex = 1;
            this.menuFile.Text = "Plik";
            this.menuFile.UseVisualStyleBackColor = true;
            this.menuFile.Click += new System.EventHandler(this.menuFile_Click);
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(64, 42);
            this.panelTop.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.panelControl.Controls.Add(this.splitControl);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl.Location = new System.Drawing.Point(1052, 0);
            this.panelControl.MaximumSize = new System.Drawing.Size(400, 0);
            this.panelControl.MinimumSize = new System.Drawing.Size(400, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Padding = new System.Windows.Forms.Padding(4);
            this.panelControl.Size = new System.Drawing.Size(400, 745);
            this.panelControl.TabIndex = 1;
            // 
            // splitControl
            // 
            this.splitControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitControl.Location = new System.Drawing.Point(4, 4);
            this.splitControl.Name = "splitControl";
            this.splitControl.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitControl.Panel1
            // 
            this.splitControl.Panel1.Controls.Add(this.panelTerminal);
            this.splitControl.Panel1.Controls.Add(this.labelTerminal);
            this.splitControl.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // splitControl.Panel2
            // 
            this.splitControl.Panel2.Controls.Add(this.panelControlSliders);
            this.splitControl.Panel2.Controls.Add(this.labelControl);
            this.splitControl.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitControl.Size = new System.Drawing.Size(392, 737);
            this.splitControl.SplitterDistance = 439;
            this.splitControl.TabIndex = 0;
            // 
            // panelTerminal
            // 
            this.panelTerminal.Controls.Add(this.panelTerminalWindow);
            this.panelTerminal.Controls.Add(this.panelCommandLine);
            this.panelTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTerminal.Location = new System.Drawing.Point(4, 20);
            this.panelTerminal.Name = "panelTerminal";
            this.panelTerminal.Size = new System.Drawing.Size(382, 413);
            this.panelTerminal.TabIndex = 1;
            // 
            // panelTerminalWindow
            // 
            this.panelTerminalWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelTerminalWindow.Controls.Add(this.listBoxTerminal);
            this.panelTerminalWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTerminalWindow.Location = new System.Drawing.Point(0, 0);
            this.panelTerminalWindow.Name = "panelTerminalWindow";
            this.panelTerminalWindow.Padding = new System.Windows.Forms.Padding(2);
            this.panelTerminalWindow.Size = new System.Drawing.Size(382, 387);
            this.panelTerminalWindow.TabIndex = 3;
            // 
            // listBoxTerminal
            // 
            this.listBoxTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listBoxTerminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTerminal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxTerminal.ForeColor = System.Drawing.Color.White;
            this.listBoxTerminal.FormattingEnabled = true;
            this.listBoxTerminal.ItemHeight = 15;
            this.listBoxTerminal.Location = new System.Drawing.Point(2, 2);
            this.listBoxTerminal.Name = "listBoxTerminal";
            this.listBoxTerminal.Size = new System.Drawing.Size(378, 383);
            this.listBoxTerminal.TabIndex = 0;
            // 
            // panelCommandLine
            // 
            this.panelCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelCommandLine.Controls.Add(this.commandLine);
            this.panelCommandLine.Controls.Add(this.panelCaret);
            this.panelCommandLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCommandLine.Location = new System.Drawing.Point(0, 387);
            this.panelCommandLine.Name = "panelCommandLine";
            this.panelCommandLine.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCommandLine.Size = new System.Drawing.Size(382, 26);
            this.panelCommandLine.TabIndex = 2;
            // 
            // commandLine
            // 
            this.commandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.commandLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commandLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandLine.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commandLine.ForeColor = System.Drawing.Color.White;
            this.commandLine.Location = new System.Drawing.Point(18, 5);
            this.commandLine.Name = "commandLine";
            this.commandLine.Size = new System.Drawing.Size(360, 16);
            this.commandLine.TabIndex = 1;
            this.commandLine.WordWrap = false;
            // 
            // panelCaret
            // 
            this.panelCaret.Controls.Add(this.labelCaret);
            this.panelCaret.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCaret.Location = new System.Drawing.Point(4, 5);
            this.panelCaret.Name = "panelCaret";
            this.panelCaret.Size = new System.Drawing.Size(14, 16);
            this.panelCaret.TabIndex = 3;
            // 
            // labelCaret
            // 
            this.labelCaret.AutoSize = true;
            this.labelCaret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCaret.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelCaret.ForeColor = System.Drawing.Color.White;
            this.labelCaret.Location = new System.Drawing.Point(0, 0);
            this.labelCaret.Name = "labelCaret";
            this.labelCaret.Size = new System.Drawing.Size(14, 15);
            this.labelCaret.TabIndex = 0;
            this.labelCaret.Text = ">";
            // 
            // labelTerminal
            // 
            this.labelTerminal.AutoSize = true;
            this.labelTerminal.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTerminal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.labelTerminal.Location = new System.Drawing.Point(4, 4);
            this.labelTerminal.Name = "labelTerminal";
            this.labelTerminal.Size = new System.Drawing.Size(53, 16);
            this.labelTerminal.TabIndex = 0;
            this.labelTerminal.Text = "Terminal";
            // 
            // panelControlSliders
            // 
            this.panelControlSliders.Controls.Add(this.panelControlButtons);
            this.panelControlSliders.Controls.Add(this.panelSliders);
            this.panelControlSliders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlSliders.Location = new System.Drawing.Point(4, 20);
            this.panelControlSliders.Name = "panelControlSliders";
            this.panelControlSliders.Padding = new System.Windows.Forms.Padding(4);
            this.panelControlSliders.Size = new System.Drawing.Size(382, 268);
            this.panelControlSliders.TabIndex = 2;
            // 
            // panelControlButtons
            // 
            this.panelControlButtons.Controls.Add(this.buttonLaserOff);
            this.panelControlButtons.Controls.Add(this.laserPower);
            this.panelControlButtons.Controls.Add(this.buttonLaserOn);
            this.panelControlButtons.Controls.Add(this.buttonDOWNRIGHT);
            this.panelControlButtons.Controls.Add(this.buttonDOWN);
            this.panelControlButtons.Controls.Add(this.buttonDOWNLEFT);
            this.panelControlButtons.Controls.Add(this.buttonRIGHT);
            this.panelControlButtons.Controls.Add(this.buttonHOME);
            this.panelControlButtons.Controls.Add(this.buttonLEFT);
            this.panelControlButtons.Controls.Add(this.buttonUPRIGHT);
            this.panelControlButtons.Controls.Add(this.buttonUP);
            this.panelControlButtons.Controls.Add(this.buttonUPLEFT);
            this.panelControlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlButtons.Location = new System.Drawing.Point(4, 96);
            this.panelControlButtons.Name = "panelControlButtons";
            this.panelControlButtons.Size = new System.Drawing.Size(374, 168);
            this.panelControlButtons.TabIndex = 1;
            // 
            // buttonLaserOff
            // 
            this.buttonLaserOff.BackColor = System.Drawing.Color.Firebrick;
            this.buttonLaserOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLaserOff.FlatAppearance.BorderSize = 2;
            this.buttonLaserOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLaserOff.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLaserOff.ForeColor = System.Drawing.Color.White;
            this.buttonLaserOff.Location = new System.Drawing.Point(171, 115);
            this.buttonLaserOff.Name = "buttonLaserOff";
            this.buttonLaserOff.Size = new System.Drawing.Size(203, 50);
            this.buttonLaserOff.TabIndex = 11;
            this.buttonLaserOff.Text = "Laser OFF";
            this.buttonLaserOff.UseVisualStyleBackColor = false;
            // 
            // laserPower
            // 
            this.laserPower.Location = new System.Drawing.Point(274, 86);
            this.laserPower.Name = "laserPower";
            this.laserPower.Size = new System.Drawing.Size(100, 22);
            this.laserPower.TabIndex = 10;
            // 
            // buttonLaserOn
            // 
            this.buttonLaserOn.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLaserOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLaserOn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonLaserOn.FlatAppearance.BorderSize = 2;
            this.buttonLaserOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLaserOn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLaserOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonLaserOn.Location = new System.Drawing.Point(171, 84);
            this.buttonLaserOn.Name = "buttonLaserOn";
            this.buttonLaserOn.Size = new System.Drawing.Size(100, 25);
            this.buttonLaserOn.TabIndex = 9;
            this.buttonLaserOn.Text = "Laser ON";
            this.buttonLaserOn.UseVisualStyleBackColor = false;
            // 
            // buttonDOWNRIGHT
            // 
            this.buttonDOWNRIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonDOWNRIGHT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDOWNRIGHT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonDOWNRIGHT.FlatAppearance.BorderSize = 2;
            this.buttonDOWNRIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDOWNRIGHT.Location = new System.Drawing.Point(115, 115);
            this.buttonDOWNRIGHT.Name = "buttonDOWNRIGHT";
            this.buttonDOWNRIGHT.Size = new System.Drawing.Size(50, 50);
            this.buttonDOWNRIGHT.TabIndex = 8;
            this.buttonDOWNRIGHT.Text = "SE";
            this.buttonDOWNRIGHT.UseVisualStyleBackColor = false;
            // 
            // buttonDOWN
            // 
            this.buttonDOWN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonDOWN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDOWN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonDOWN.FlatAppearance.BorderSize = 2;
            this.buttonDOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDOWN.Location = new System.Drawing.Point(59, 115);
            this.buttonDOWN.Name = "buttonDOWN";
            this.buttonDOWN.Size = new System.Drawing.Size(50, 50);
            this.buttonDOWN.TabIndex = 7;
            this.buttonDOWN.Text = "S";
            this.buttonDOWN.UseVisualStyleBackColor = false;
            // 
            // buttonDOWNLEFT
            // 
            this.buttonDOWNLEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonDOWNLEFT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDOWNLEFT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonDOWNLEFT.FlatAppearance.BorderSize = 2;
            this.buttonDOWNLEFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDOWNLEFT.Location = new System.Drawing.Point(3, 115);
            this.buttonDOWNLEFT.Name = "buttonDOWNLEFT";
            this.buttonDOWNLEFT.Size = new System.Drawing.Size(50, 50);
            this.buttonDOWNLEFT.TabIndex = 6;
            this.buttonDOWNLEFT.Text = "SW";
            this.buttonDOWNLEFT.UseVisualStyleBackColor = false;
            // 
            // buttonRIGHT
            // 
            this.buttonRIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonRIGHT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRIGHT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonRIGHT.FlatAppearance.BorderSize = 2;
            this.buttonRIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRIGHT.Location = new System.Drawing.Point(115, 59);
            this.buttonRIGHT.Name = "buttonRIGHT";
            this.buttonRIGHT.Size = new System.Drawing.Size(50, 50);
            this.buttonRIGHT.TabIndex = 5;
            this.buttonRIGHT.Text = "E";
            this.buttonRIGHT.UseVisualStyleBackColor = false;
            // 
            // buttonHOME
            // 
            this.buttonHOME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonHOME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHOME.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonHOME.FlatAppearance.BorderSize = 2;
            this.buttonHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHOME.Location = new System.Drawing.Point(59, 59);
            this.buttonHOME.Name = "buttonHOME";
            this.buttonHOME.Size = new System.Drawing.Size(50, 50);
            this.buttonHOME.TabIndex = 4;
            this.buttonHOME.Text = "HOM";
            this.buttonHOME.UseVisualStyleBackColor = false;
            // 
            // buttonLEFT
            // 
            this.buttonLEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonLEFT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLEFT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonLEFT.FlatAppearance.BorderSize = 2;
            this.buttonLEFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLEFT.Location = new System.Drawing.Point(3, 59);
            this.buttonLEFT.Name = "buttonLEFT";
            this.buttonLEFT.Size = new System.Drawing.Size(50, 50);
            this.buttonLEFT.TabIndex = 3;
            this.buttonLEFT.Text = "W";
            this.buttonLEFT.UseVisualStyleBackColor = false;
            // 
            // buttonUPRIGHT
            // 
            this.buttonUPRIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonUPRIGHT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUPRIGHT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonUPRIGHT.FlatAppearance.BorderSize = 2;
            this.buttonUPRIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUPRIGHT.Location = new System.Drawing.Point(115, 3);
            this.buttonUPRIGHT.Name = "buttonUPRIGHT";
            this.buttonUPRIGHT.Size = new System.Drawing.Size(50, 50);
            this.buttonUPRIGHT.TabIndex = 2;
            this.buttonUPRIGHT.Text = "NE";
            this.buttonUPRIGHT.UseVisualStyleBackColor = false;
            // 
            // buttonUP
            // 
            this.buttonUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonUP.FlatAppearance.BorderSize = 2;
            this.buttonUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUP.Location = new System.Drawing.Point(59, 3);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(50, 50);
            this.buttonUP.TabIndex = 1;
            this.buttonUP.Text = "N";
            this.buttonUP.UseVisualStyleBackColor = false;
            // 
            // buttonUPLEFT
            // 
            this.buttonUPLEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonUPLEFT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUPLEFT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonUPLEFT.FlatAppearance.BorderSize = 2;
            this.buttonUPLEFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUPLEFT.Location = new System.Drawing.Point(3, 3);
            this.buttonUPLEFT.Name = "buttonUPLEFT";
            this.buttonUPLEFT.Size = new System.Drawing.Size(50, 50);
            this.buttonUPLEFT.TabIndex = 0;
            this.buttonUPLEFT.Text = "NW";
            this.buttonUPLEFT.UseVisualStyleBackColor = false;
            // 
            // panelSliders
            // 
            this.panelSliders.Controls.Add(this.sliderFeedrate);
            this.panelSliders.Controls.Add(this.sliderStep);
            this.panelSliders.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSliders.Location = new System.Drawing.Point(4, 4);
            this.panelSliders.Name = "panelSliders";
            this.panelSliders.Size = new System.Drawing.Size(374, 92);
            this.panelSliders.TabIndex = 0;
            // 
            // sliderFeedrate
            // 
            this.sliderFeedrate.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderFeedrate.Location = new System.Drawing.Point(0, 0);
            this.sliderFeedrate.Maximum = 1000;
            this.sliderFeedrate.Name = "sliderFeedrate";
            this.sliderFeedrate.Size = new System.Drawing.Size(374, 45);
            this.sliderFeedrate.TabIndex = 1;
            this.sliderFeedrate.Tag = "Feedrate";
            this.sliderFeedrate.TickFrequency = 20;
            // 
            // sliderStep
            // 
            this.sliderStep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sliderStep.Location = new System.Drawing.Point(0, 47);
            this.sliderStep.Maximum = 100;
            this.sliderStep.Name = "sliderStep";
            this.sliderStep.Size = new System.Drawing.Size(374, 45);
            this.sliderStep.TabIndex = 0;
            this.sliderStep.Tag = "Step";
            this.sliderStep.TickFrequency = 5;
            // 
            // labelControl
            // 
            this.labelControl.AutoSize = true;
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.labelControl.Location = new System.Drawing.Point(4, 4);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(91, 16);
            this.labelControl.TabIndex = 0;
            this.labelControl.Text = "Panel kontrolny";
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.panelStatus.Controls.Add(this.textStatusBox);
            this.panelStatus.Controls.Add(this.textStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 723);
            this.panelStatus.MaximumSize = new System.Drawing.Size(0, 15);
            this.panelStatus.MinimumSize = new System.Drawing.Size(0, 22);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Padding = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.panelStatus.Size = new System.Drawing.Size(988, 22);
            this.panelStatus.TabIndex = 1;
            // 
            // textStatusBox
            // 
            this.textStatusBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textStatusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStatusBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textStatusBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.textStatusBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textStatusBox.Location = new System.Drawing.Point(909, 4);
            this.textStatusBox.Name = "textStatusBox";
            this.textStatusBox.ReadOnly = true;
            this.textStatusBox.Size = new System.Drawing.Size(75, 15);
            this.textStatusBox.TabIndex = 1;
            this.textStatusBox.Text = "STATUS";
            this.textStatusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textStatus
            // 
            this.textStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textStatus.ForeColor = System.Drawing.Color.DarkGray;
            this.textStatus.Location = new System.Drawing.Point(8, 4);
            this.textStatus.Name = "textStatus";
            this.textStatus.ReadOnly = true;
            this.textStatus.Size = new System.Drawing.Size(976, 15);
            this.textStatus.TabIndex = 0;
            this.textStatus.Text = "STATUS_BAR_MESSAGE";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelForForms);
            this.panelMain.Controls.Add(this.panelStatus);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(64, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(988, 745);
            this.panelMain.TabIndex = 2;
            // 
            // panelForForms
            // 
            this.panelForForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForForms.Location = new System.Drawing.Point(0, 0);
            this.panelForForms.Name = "panelForForms";
            this.panelForForms.Size = new System.Drawing.Size(988, 723);
            this.panelForForms.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1452, 745);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "MainForm";
            this.Text = "AOGL";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelLaser.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelFile.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.splitControl.Panel1.ResumeLayout(false);
            this.splitControl.Panel1.PerformLayout();
            this.splitControl.Panel2.ResumeLayout(false);
            this.splitControl.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitControl)).EndInit();
            this.splitControl.ResumeLayout(false);
            this.panelTerminal.ResumeLayout(false);
            this.panelTerminalWindow.ResumeLayout(false);
            this.panelCommandLine.ResumeLayout(false);
            this.panelCommandLine.PerformLayout();
            this.panelCaret.ResumeLayout(false);
            this.panelCaret.PerformLayout();
            this.panelControlSliders.ResumeLayout(false);
            this.panelControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.laserPower)).EndInit();
            this.panelSliders.ResumeLayout(false);
            this.panelSliders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFeedrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderStep)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelFile;
        private System.Windows.Forms.Button goLoadFile;
        private System.Windows.Forms.Button menuFile;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button menuLeave;
        private System.Windows.Forms.Panel panelLaser;
        private System.Windows.Forms.Button goTest;
        private System.Windows.Forms.Button goDriver;
        private System.Windows.Forms.Button goConnect;
        private System.Windows.Forms.Button menuLaser;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button goGrbl;
        private System.Windows.Forms.Button goSettings;
        private System.Windows.Forms.Button menuSettings;
        private System.Windows.Forms.Button goLeave;
        private System.Windows.Forms.Button goExport;
        private System.Windows.Forms.Button goLoadGCode;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.SplitContainer splitControl;
        private System.Windows.Forms.Label labelTerminal;
        private System.Windows.Forms.Label labelControl;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTerminal;
        private System.Windows.Forms.TextBox commandLine;
        private System.Windows.Forms.ListBox listBoxTerminal;
        private System.Windows.Forms.Panel panelCommandLine;
        private System.Windows.Forms.Panel panelCaret;
        private System.Windows.Forms.Label labelCaret;
        private System.Windows.Forms.Panel panelControlSliders;
        private System.Windows.Forms.Panel panelSliders;
        private System.Windows.Forms.TrackBar sliderFeedrate;
        private System.Windows.Forms.TrackBar sliderStep;
        private System.Windows.Forms.Panel panelControlButtons;
        private System.Windows.Forms.Button buttonLaserOff;
        private System.Windows.Forms.NumericUpDown laserPower;
        private System.Windows.Forms.Button buttonLaserOn;
        private System.Windows.Forms.Button buttonDOWNRIGHT;
        private System.Windows.Forms.Button buttonDOWN;
        private System.Windows.Forms.Button buttonDOWNLEFT;
        private System.Windows.Forms.Button buttonRIGHT;
        private System.Windows.Forms.Button buttonHOME;
        private System.Windows.Forms.Button buttonLEFT;
        private System.Windows.Forms.Button buttonUPRIGHT;
        private System.Windows.Forms.Button buttonUP;
        private System.Windows.Forms.Button buttonUPLEFT;
        private System.Windows.Forms.TextBox textStatusBox;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Panel panelTerminalWindow;
        private System.Windows.Forms.Panel panelForForms;
    }
}

