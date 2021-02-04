namespace AOGL
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
            this.goTerminalPosition = new System.Windows.Forms.Button();
            this.goTerminalCommands = new System.Windows.Forms.Button();
            this.goTerminalConfig = new System.Windows.Forms.Button();
            this.goTerminalClear = new System.Windows.Forms.Button();
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
            this.labelStep = new System.Windows.Forms.Label();
            this.labelFeedrate = new System.Windows.Forms.Label();
            this.labelSliderStepValue = new System.Windows.Forms.Label();
            this.labelSliderFeedRateValue = new System.Windows.Forms.Label();
            this.sliderFeedrate = new System.Windows.Forms.TrackBar();
            this.sliderStep = new System.Windows.Forms.TrackBar();
            this.labelControl = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.panelStatusBoxPadding = new System.Windows.Forms.Panel();
            this.textStatusBox = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelForForms = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.panel1.SuspendLayout();
            this.panelStatusBoxPadding.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelForForms.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
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
            this.panelSideMenu.Size = new System.Drawing.Size(32, 754);
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
            this.menuLeave.Location = new System.Drawing.Point(0, 692);
            this.menuLeave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuLeave.Name = "menuLeave";
            this.menuLeave.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.menuLeave.Size = new System.Drawing.Size(32, 62);
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
            this.panelLaser.Location = new System.Drawing.Point(0, 413);
            this.panelLaser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLaser.Name = "panelLaser";
            this.panelLaser.Size = new System.Drawing.Size(32, 111);
            this.panelLaser.TabIndex = 6;
            // 
            // goTest
            // 
            this.goTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
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
            this.goTest.Size = new System.Drawing.Size(32, 37);
            this.goTest.TabIndex = 5;
            this.goTest.Text = "Wykonaj grawer testowy";
            this.goTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goTest.UseVisualStyleBackColor = false;
            this.goTest.Click += new System.EventHandler(this.goTest_Click);
            // 
            // goDriver
            // 
            this.goDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.goDriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.goDriver.FlatAppearance.BorderSize = 0;
            this.goDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goDriver.ForeColor = System.Drawing.Color.White;
            this.goDriver.Location = new System.Drawing.Point(0, 37);
            this.goDriver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goDriver.Name = "goDriver";
            this.goDriver.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goDriver.Size = new System.Drawing.Size(32, 37);
            this.goDriver.TabIndex = 4;
            this.goDriver.Text = "Instaluj sterownik";
            this.goDriver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goDriver.UseVisualStyleBackColor = false;
            this.goDriver.Click += new System.EventHandler(this.goDriver_Click);
            // 
            // goConnect
            // 
            this.goConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.goConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.goConnect.FlatAppearance.BorderSize = 0;
            this.goConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goConnect.ForeColor = System.Drawing.Color.White;
            this.goConnect.Location = new System.Drawing.Point(0, 0);
            this.goConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goConnect.Name = "goConnect";
            this.goConnect.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goConnect.Size = new System.Drawing.Size(32, 37);
            this.goConnect.TabIndex = 3;
            this.goConnect.Text = "Połącz";
            this.goConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goConnect.UseVisualStyleBackColor = false;
            this.goConnect.Click += new System.EventHandler(this.goConnect_Click);
            // 
            // menuLaser
            // 
            this.menuLaser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.menuLaser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuLaser.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuLaser.FlatAppearance.BorderSize = 0;
            this.menuLaser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuLaser.ForeColor = System.Drawing.Color.White;
            this.menuLaser.Image = ((System.Drawing.Image)(resources.GetObject("menuLaser.Image")));
            this.menuLaser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuLaser.Location = new System.Drawing.Point(0, 351);
            this.menuLaser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuLaser.Name = "menuLaser";
            this.menuLaser.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.menuLaser.Size = new System.Drawing.Size(32, 62);
            this.menuLaser.TabIndex = 5;
            this.menuLaser.Text = "Laser";
            this.menuLaser.UseVisualStyleBackColor = false;
            this.menuLaser.Click += new System.EventHandler(this.menuLaser_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelSettings.Controls.Add(this.goGrbl);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettings.Location = new System.Drawing.Point(0, 314);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(32, 37);
            this.panelSettings.TabIndex = 4;
            // 
            // goGrbl
            // 
            this.goGrbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.goGrbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goGrbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.goGrbl.FlatAppearance.BorderSize = 0;
            this.goGrbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goGrbl.ForeColor = System.Drawing.Color.White;
            this.goGrbl.Location = new System.Drawing.Point(0, 0);
            this.goGrbl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goGrbl.Name = "goGrbl";
            this.goGrbl.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goGrbl.Size = new System.Drawing.Size(32, 37);
            this.goGrbl.TabIndex = 4;
            this.goGrbl.Text = "Konfiguracja GRBL";
            this.goGrbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goGrbl.UseVisualStyleBackColor = false;
            this.goGrbl.Click += new System.EventHandler(this.goGrbl_Click);
            // 
            // menuSettings
            // 
            this.menuSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
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
            this.menuSettings.Size = new System.Drawing.Size(32, 62);
            this.menuSettings.TabIndex = 3;
            this.menuSettings.Text = "Opcje";
            this.menuSettings.UseVisualStyleBackColor = false;
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
            this.panelFile.Size = new System.Drawing.Size(32, 148);
            this.panelFile.TabIndex = 2;
            // 
            // goLeave
            // 
            this.goLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.goLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.goLeave.FlatAppearance.BorderSize = 0;
            this.goLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goLeave.ForeColor = System.Drawing.Color.White;
            this.goLeave.Location = new System.Drawing.Point(0, 111);
            this.goLeave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goLeave.Name = "goLeave";
            this.goLeave.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goLeave.Size = new System.Drawing.Size(32, 37);
            this.goLeave.TabIndex = 3;
            this.goLeave.Text = "Wyjdź";
            this.goLeave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goLeave.UseVisualStyleBackColor = false;
            this.goLeave.Click += new System.EventHandler(this.goLeave_Click);
            // 
            // goExport
            // 
            this.goExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
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
            this.goExport.Size = new System.Drawing.Size(32, 37);
            this.goExport.TabIndex = 2;
            this.goExport.Text = "Eksportuj...";
            this.goExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goExport.UseVisualStyleBackColor = false;
            this.goExport.Click += new System.EventHandler(this.goExport_Click);
            // 
            // goLoadGCode
            // 
            this.goLoadGCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.goLoadGCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goLoadGCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.goLoadGCode.FlatAppearance.BorderSize = 0;
            this.goLoadGCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goLoadGCode.ForeColor = System.Drawing.Color.White;
            this.goLoadGCode.Location = new System.Drawing.Point(0, 37);
            this.goLoadGCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goLoadGCode.Name = "goLoadGCode";
            this.goLoadGCode.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goLoadGCode.Size = new System.Drawing.Size(32, 37);
            this.goLoadGCode.TabIndex = 1;
            this.goLoadGCode.Text = "Wczytaj GCode...";
            this.goLoadGCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goLoadGCode.UseVisualStyleBackColor = false;
            this.goLoadGCode.Click += new System.EventHandler(this.goLoadGCode_Click);
            // 
            // goLoadFile
            // 
            this.goLoadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.goLoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goLoadFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.goLoadFile.FlatAppearance.BorderSize = 0;
            this.goLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goLoadFile.ForeColor = System.Drawing.Color.White;
            this.goLoadFile.Location = new System.Drawing.Point(0, 0);
            this.goLoadFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goLoadFile.Name = "goLoadFile";
            this.goLoadFile.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.goLoadFile.Size = new System.Drawing.Size(32, 37);
            this.goLoadFile.TabIndex = 0;
            this.goLoadFile.Text = "Wczytaj obraz...";
            this.goLoadFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goLoadFile.UseVisualStyleBackColor = false;
            this.goLoadFile.Click += new System.EventHandler(this.goLoadFile_Click);
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
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
            this.menuFile.Size = new System.Drawing.Size(32, 62);
            this.menuFile.TabIndex = 1;
            this.menuFile.Text = "Plik";
            this.menuFile.UseVisualStyleBackColor = false;
            this.menuFile.Click += new System.EventHandler(this.menuFile_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(32, 42);
            this.panelTop.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panelControl.Controls.Add(this.splitControl);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl.Location = new System.Drawing.Point(937, 0);
            this.panelControl.MaximumSize = new System.Drawing.Size(400, 0);
            this.panelControl.MinimumSize = new System.Drawing.Size(400, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Padding = new System.Windows.Forms.Padding(4);
            this.panelControl.Size = new System.Drawing.Size(400, 754);
            this.panelControl.TabIndex = 1;
            // 
            // splitControl
            // 
            this.splitControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.splitControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitControl.Location = new System.Drawing.Point(4, 4);
            this.splitControl.Name = "splitControl";
            this.splitControl.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitControl.Panel1
            // 
            this.splitControl.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.splitControl.Panel1.Controls.Add(this.panelTerminal);
            this.splitControl.Panel1.Controls.Add(this.labelTerminal);
            this.splitControl.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // splitControl.Panel2
            // 
            this.splitControl.Panel2.Controls.Add(this.panelControlSliders);
            this.splitControl.Panel2.Controls.Add(this.labelControl);
            this.splitControl.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitControl.Size = new System.Drawing.Size(392, 746);
            this.splitControl.SplitterDistance = 437;
            this.splitControl.SplitterWidth = 8;
            this.splitControl.TabIndex = 0;
            // 
            // panelTerminal
            // 
            this.panelTerminal.Controls.Add(this.panelTerminalWindow);
            this.panelTerminal.Controls.Add(this.panelCommandLine);
            this.panelTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTerminal.Location = new System.Drawing.Point(4, 20);
            this.panelTerminal.Name = "panelTerminal";
            this.panelTerminal.Size = new System.Drawing.Size(384, 413);
            this.panelTerminal.TabIndex = 1;
            // 
            // panelTerminalWindow
            // 
            this.panelTerminalWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.panelTerminalWindow.Controls.Add(this.listBoxTerminal);
            this.panelTerminalWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTerminalWindow.Location = new System.Drawing.Point(0, 0);
            this.panelTerminalWindow.Name = "panelTerminalWindow";
            this.panelTerminalWindow.Padding = new System.Windows.Forms.Padding(2);
            this.panelTerminalWindow.Size = new System.Drawing.Size(384, 387);
            this.panelTerminalWindow.TabIndex = 3;
            // 
            // listBoxTerminal
            // 
            this.listBoxTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.listBoxTerminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTerminal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxTerminal.ForeColor = System.Drawing.Color.White;
            this.listBoxTerminal.FormattingEnabled = true;
            this.listBoxTerminal.ItemHeight = 15;
            this.listBoxTerminal.Location = new System.Drawing.Point(2, 2);
            this.listBoxTerminal.Name = "listBoxTerminal";
            this.listBoxTerminal.Size = new System.Drawing.Size(380, 383);
            this.listBoxTerminal.TabIndex = 0;
            // 
            // panelCommandLine
            // 
            this.panelCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.panelCommandLine.Controls.Add(this.goTerminalPosition);
            this.panelCommandLine.Controls.Add(this.goTerminalCommands);
            this.panelCommandLine.Controls.Add(this.goTerminalConfig);
            this.panelCommandLine.Controls.Add(this.goTerminalClear);
            this.panelCommandLine.Controls.Add(this.commandLine);
            this.panelCommandLine.Controls.Add(this.panelCaret);
            this.panelCommandLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCommandLine.Location = new System.Drawing.Point(0, 387);
            this.panelCommandLine.Name = "panelCommandLine";
            this.panelCommandLine.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCommandLine.Size = new System.Drawing.Size(384, 26);
            this.panelCommandLine.TabIndex = 2;
            // 
            // goTerminalPosition
            // 
            this.goTerminalPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.goTerminalPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goTerminalPosition.Dock = System.Windows.Forms.DockStyle.Right;
            this.goTerminalPosition.FlatAppearance.BorderSize = 0;
            this.goTerminalPosition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(156)))), ((int)(((byte)(167)))));
            this.goTerminalPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goTerminalPosition.Font = new System.Drawing.Font("Microsoft YaHei", 4.75F);
            this.goTerminalPosition.ForeColor = System.Drawing.Color.White;
            this.goTerminalPosition.Location = new System.Drawing.Point(276, 5);
            this.goTerminalPosition.Name = "goTerminalPosition";
            this.goTerminalPosition.Size = new System.Drawing.Size(26, 16);
            this.goTerminalPosition.TabIndex = 7;
            this.goTerminalPosition.Text = "?";
            this.goTerminalPosition.UseVisualStyleBackColor = false;
            this.goTerminalPosition.Click += new System.EventHandler(this.goTerminalPosition_Click);
            // 
            // goTerminalCommands
            // 
            this.goTerminalCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.goTerminalCommands.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goTerminalCommands.Dock = System.Windows.Forms.DockStyle.Right;
            this.goTerminalCommands.FlatAppearance.BorderSize = 0;
            this.goTerminalCommands.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(156)))), ((int)(((byte)(167)))));
            this.goTerminalCommands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goTerminalCommands.Font = new System.Drawing.Font("Microsoft YaHei", 4.75F);
            this.goTerminalCommands.ForeColor = System.Drawing.Color.White;
            this.goTerminalCommands.Location = new System.Drawing.Point(302, 5);
            this.goTerminalCommands.Name = "goTerminalCommands";
            this.goTerminalCommands.Size = new System.Drawing.Size(26, 16);
            this.goTerminalCommands.TabIndex = 6;
            this.goTerminalCommands.Text = "$";
            this.goTerminalCommands.UseVisualStyleBackColor = false;
            this.goTerminalCommands.Click += new System.EventHandler(this.goTerminalCommands_Click);
            // 
            // goTerminalConfig
            // 
            this.goTerminalConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.goTerminalConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goTerminalConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.goTerminalConfig.FlatAppearance.BorderSize = 0;
            this.goTerminalConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(156)))), ((int)(((byte)(167)))));
            this.goTerminalConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goTerminalConfig.Font = new System.Drawing.Font("Microsoft YaHei", 4.75F);
            this.goTerminalConfig.ForeColor = System.Drawing.Color.White;
            this.goTerminalConfig.Location = new System.Drawing.Point(328, 5);
            this.goTerminalConfig.Name = "goTerminalConfig";
            this.goTerminalConfig.Size = new System.Drawing.Size(26, 16);
            this.goTerminalConfig.TabIndex = 5;
            this.goTerminalConfig.Text = "$$";
            this.goTerminalConfig.UseVisualStyleBackColor = false;
            this.goTerminalConfig.Click += new System.EventHandler(this.goTerminalConfig_Click);
            // 
            // goTerminalClear
            // 
            this.goTerminalClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.goTerminalClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goTerminalClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.goTerminalClear.FlatAppearance.BorderSize = 0;
            this.goTerminalClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(156)))), ((int)(((byte)(167)))));
            this.goTerminalClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goTerminalClear.Font = new System.Drawing.Font("Microsoft YaHei", 4.75F);
            this.goTerminalClear.ForeColor = System.Drawing.Color.White;
            this.goTerminalClear.Location = new System.Drawing.Point(354, 5);
            this.goTerminalClear.Name = "goTerminalClear";
            this.goTerminalClear.Size = new System.Drawing.Size(26, 16);
            this.goTerminalClear.TabIndex = 4;
            this.goTerminalClear.Text = "CLS";
            this.goTerminalClear.UseVisualStyleBackColor = false;
            this.goTerminalClear.Click += new System.EventHandler(this.goTerminalClear_Click);
            // 
            // commandLine
            // 
            this.commandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.commandLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commandLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.commandLine.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commandLine.ForeColor = System.Drawing.Color.White;
            this.commandLine.Location = new System.Drawing.Point(18, 5);
            this.commandLine.Name = "commandLine";
            this.commandLine.Size = new System.Drawing.Size(228, 16);
            this.commandLine.TabIndex = 1;
            this.commandLine.WordWrap = false;
            this.commandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandLine_KeyDown);
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
            this.panelControlSliders.Size = new System.Drawing.Size(384, 277);
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
            this.panelControlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlButtons.Location = new System.Drawing.Point(4, 104);
            this.panelControlButtons.Name = "panelControlButtons";
            this.panelControlButtons.Size = new System.Drawing.Size(376, 169);
            this.panelControlButtons.TabIndex = 1;
            // 
            // buttonLaserOff
            // 
            this.buttonLaserOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLaserOff.BackColor = System.Drawing.Color.Firebrick;
            this.buttonLaserOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLaserOff.FlatAppearance.BorderSize = 2;
            this.buttonLaserOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLaserOff.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLaserOff.ForeColor = System.Drawing.Color.White;
            this.buttonLaserOff.Location = new System.Drawing.Point(171, 116);
            this.buttonLaserOff.Name = "buttonLaserOff";
            this.buttonLaserOff.Size = new System.Drawing.Size(203, 50);
            this.buttonLaserOff.TabIndex = 11;
            this.buttonLaserOff.Text = "Laser OFF";
            this.buttonLaserOff.UseVisualStyleBackColor = false;
            this.buttonLaserOff.Click += new System.EventHandler(this.buttonLaserOff_Click);
            // 
            // laserPower
            // 
            this.laserPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.laserPower.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.laserPower.Location = new System.Drawing.Point(271, 50);
            this.laserPower.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.laserPower.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.laserPower.Name = "laserPower";
            this.laserPower.Size = new System.Drawing.Size(100, 22);
            this.laserPower.TabIndex = 10;
            this.laserPower.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.laserPower.ValueChanged += new System.EventHandler(this.laserPower_ValueChanged);
            // 
            // buttonLaserOn
            // 
            this.buttonLaserOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLaserOn.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLaserOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLaserOn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonLaserOn.FlatAppearance.BorderSize = 2;
            this.buttonLaserOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLaserOn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLaserOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonLaserOn.Location = new System.Drawing.Point(271, 78);
            this.buttonLaserOn.Name = "buttonLaserOn";
            this.buttonLaserOn.Size = new System.Drawing.Size(100, 32);
            this.buttonLaserOn.TabIndex = 9;
            this.buttonLaserOn.Text = "Laser ON";
            this.buttonLaserOn.UseVisualStyleBackColor = false;
            this.buttonLaserOn.Click += new System.EventHandler(this.buttonLaserOn_Click);
            // 
            // buttonDOWNRIGHT
            // 
            this.buttonDOWNRIGHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDOWNRIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonDOWNRIGHT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDOWNRIGHT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonDOWNRIGHT.FlatAppearance.BorderSize = 2;
            this.buttonDOWNRIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDOWNRIGHT.Image = ((System.Drawing.Image)(resources.GetObject("buttonDOWNRIGHT.Image")));
            this.buttonDOWNRIGHT.Location = new System.Drawing.Point(115, 116);
            this.buttonDOWNRIGHT.Name = "buttonDOWNRIGHT";
            this.buttonDOWNRIGHT.Size = new System.Drawing.Size(50, 50);
            this.buttonDOWNRIGHT.TabIndex = 8;
            this.buttonDOWNRIGHT.UseVisualStyleBackColor = false;
            this.buttonDOWNRIGHT.Click += new System.EventHandler(this.buttonDOWNRIGHT_Click);
            // 
            // buttonDOWN
            // 
            this.buttonDOWN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDOWN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonDOWN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDOWN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonDOWN.FlatAppearance.BorderSize = 2;
            this.buttonDOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDOWN.Image = ((System.Drawing.Image)(resources.GetObject("buttonDOWN.Image")));
            this.buttonDOWN.Location = new System.Drawing.Point(59, 116);
            this.buttonDOWN.Name = "buttonDOWN";
            this.buttonDOWN.Size = new System.Drawing.Size(50, 50);
            this.buttonDOWN.TabIndex = 7;
            this.buttonDOWN.UseVisualStyleBackColor = false;
            this.buttonDOWN.Click += new System.EventHandler(this.buttonDOWN_Click);
            // 
            // buttonDOWNLEFT
            // 
            this.buttonDOWNLEFT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDOWNLEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonDOWNLEFT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDOWNLEFT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonDOWNLEFT.FlatAppearance.BorderSize = 2;
            this.buttonDOWNLEFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDOWNLEFT.Image = ((System.Drawing.Image)(resources.GetObject("buttonDOWNLEFT.Image")));
            this.buttonDOWNLEFT.Location = new System.Drawing.Point(3, 116);
            this.buttonDOWNLEFT.Name = "buttonDOWNLEFT";
            this.buttonDOWNLEFT.Size = new System.Drawing.Size(50, 50);
            this.buttonDOWNLEFT.TabIndex = 6;
            this.buttonDOWNLEFT.UseVisualStyleBackColor = false;
            this.buttonDOWNLEFT.Click += new System.EventHandler(this.buttonDOWNLEFT_Click);
            // 
            // buttonRIGHT
            // 
            this.buttonRIGHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonRIGHT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRIGHT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonRIGHT.FlatAppearance.BorderSize = 2;
            this.buttonRIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRIGHT.Image = ((System.Drawing.Image)(resources.GetObject("buttonRIGHT.Image")));
            this.buttonRIGHT.Location = new System.Drawing.Point(115, 60);
            this.buttonRIGHT.Name = "buttonRIGHT";
            this.buttonRIGHT.Size = new System.Drawing.Size(50, 50);
            this.buttonRIGHT.TabIndex = 5;
            this.buttonRIGHT.UseVisualStyleBackColor = false;
            this.buttonRIGHT.Click += new System.EventHandler(this.buttonRIGHT_Click);
            // 
            // buttonHOME
            // 
            this.buttonHOME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHOME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonHOME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHOME.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonHOME.FlatAppearance.BorderSize = 2;
            this.buttonHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHOME.Image = ((System.Drawing.Image)(resources.GetObject("buttonHOME.Image")));
            this.buttonHOME.Location = new System.Drawing.Point(59, 60);
            this.buttonHOME.Name = "buttonHOME";
            this.buttonHOME.Size = new System.Drawing.Size(50, 50);
            this.buttonHOME.TabIndex = 4;
            this.buttonHOME.UseVisualStyleBackColor = false;
            this.buttonHOME.Click += new System.EventHandler(this.buttonHOME_Click);
            // 
            // buttonLEFT
            // 
            this.buttonLEFT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonLEFT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLEFT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonLEFT.FlatAppearance.BorderSize = 2;
            this.buttonLEFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLEFT.Image = ((System.Drawing.Image)(resources.GetObject("buttonLEFT.Image")));
            this.buttonLEFT.Location = new System.Drawing.Point(3, 60);
            this.buttonLEFT.Name = "buttonLEFT";
            this.buttonLEFT.Size = new System.Drawing.Size(50, 50);
            this.buttonLEFT.TabIndex = 3;
            this.buttonLEFT.UseVisualStyleBackColor = false;
            this.buttonLEFT.Click += new System.EventHandler(this.buttonLEFT_Click);
            // 
            // buttonUPRIGHT
            // 
            this.buttonUPRIGHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUPRIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonUPRIGHT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUPRIGHT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonUPRIGHT.FlatAppearance.BorderSize = 2;
            this.buttonUPRIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUPRIGHT.Image = ((System.Drawing.Image)(resources.GetObject("buttonUPRIGHT.Image")));
            this.buttonUPRIGHT.Location = new System.Drawing.Point(115, 4);
            this.buttonUPRIGHT.Name = "buttonUPRIGHT";
            this.buttonUPRIGHT.Size = new System.Drawing.Size(50, 50);
            this.buttonUPRIGHT.TabIndex = 2;
            this.buttonUPRIGHT.UseVisualStyleBackColor = false;
            this.buttonUPRIGHT.Click += new System.EventHandler(this.buttonUPRIGHT_Click);
            // 
            // buttonUP
            // 
            this.buttonUP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonUP.FlatAppearance.BorderSize = 2;
            this.buttonUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUP.Image = ((System.Drawing.Image)(resources.GetObject("buttonUP.Image")));
            this.buttonUP.Location = new System.Drawing.Point(59, 4);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(50, 50);
            this.buttonUP.TabIndex = 1;
            this.buttonUP.UseVisualStyleBackColor = false;
            this.buttonUP.Click += new System.EventHandler(this.buttonUP_Click);
            // 
            // buttonUPLEFT
            // 
            this.buttonUPLEFT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUPLEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.buttonUPLEFT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUPLEFT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.buttonUPLEFT.FlatAppearance.BorderSize = 2;
            this.buttonUPLEFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUPLEFT.Image = ((System.Drawing.Image)(resources.GetObject("buttonUPLEFT.Image")));
            this.buttonUPLEFT.Location = new System.Drawing.Point(3, 4);
            this.buttonUPLEFT.Name = "buttonUPLEFT";
            this.buttonUPLEFT.Size = new System.Drawing.Size(50, 50);
            this.buttonUPLEFT.TabIndex = 0;
            this.buttonUPLEFT.UseVisualStyleBackColor = false;
            this.buttonUPLEFT.Click += new System.EventHandler(this.buttonUPLEFT_Click);
            // 
            // panelSliders
            // 
            this.panelSliders.Controls.Add(this.labelStep);
            this.panelSliders.Controls.Add(this.labelFeedrate);
            this.panelSliders.Controls.Add(this.labelSliderStepValue);
            this.panelSliders.Controls.Add(this.labelSliderFeedRateValue);
            this.panelSliders.Controls.Add(this.sliderFeedrate);
            this.panelSliders.Controls.Add(this.sliderStep);
            this.panelSliders.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSliders.Location = new System.Drawing.Point(4, 4);
            this.panelSliders.Name = "panelSliders";
            this.panelSliders.Size = new System.Drawing.Size(376, 92);
            this.panelSliders.TabIndex = 0;
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.labelStep.ForeColor = System.Drawing.Color.White;
            this.labelStep.Location = new System.Drawing.Point(343, 76);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(31, 16);
            this.labelStep.TabIndex = 5;
            this.labelStep.Text = "Step";
            // 
            // labelFeedrate
            // 
            this.labelFeedrate.AutoSize = true;
            this.labelFeedrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.labelFeedrate.ForeColor = System.Drawing.Color.White;
            this.labelFeedrate.Location = new System.Drawing.Point(321, 29);
            this.labelFeedrate.Name = "labelFeedrate";
            this.labelFeedrate.Size = new System.Drawing.Size(53, 16);
            this.labelFeedrate.TabIndex = 4;
            this.labelFeedrate.Text = "Feedrate";
            // 
            // labelSliderStepValue
            // 
            this.labelSliderStepValue.AutoSize = true;
            this.labelSliderStepValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.labelSliderStepValue.ForeColor = System.Drawing.Color.White;
            this.labelSliderStepValue.Location = new System.Drawing.Point(0, 76);
            this.labelSliderStepValue.Name = "labelSliderStepValue";
            this.labelSliderStepValue.Size = new System.Drawing.Size(114, 16);
            this.labelSliderStepValue.TabIndex = 3;
            this.labelSliderStepValue.Text = "labelSliderStepValue";
            // 
            // labelSliderFeedRateValue
            // 
            this.labelSliderFeedRateValue.AutoSize = true;
            this.labelSliderFeedRateValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.labelSliderFeedRateValue.ForeColor = System.Drawing.Color.White;
            this.labelSliderFeedRateValue.Location = new System.Drawing.Point(0, 29);
            this.labelSliderFeedRateValue.Name = "labelSliderFeedRateValue";
            this.labelSliderFeedRateValue.Size = new System.Drawing.Size(139, 16);
            this.labelSliderFeedRateValue.TabIndex = 2;
            this.labelSliderFeedRateValue.Text = "labelSliderFeedRateValue";
            // 
            // sliderFeedrate
            // 
            this.sliderFeedrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.sliderFeedrate.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderFeedrate.LargeChange = 1;
            this.sliderFeedrate.Location = new System.Drawing.Point(0, 0);
            this.sliderFeedrate.Maximum = 20;
            this.sliderFeedrate.Minimum = 1;
            this.sliderFeedrate.Name = "sliderFeedrate";
            this.sliderFeedrate.Size = new System.Drawing.Size(376, 45);
            this.sliderFeedrate.TabIndex = 1;
            this.sliderFeedrate.Tag = "Feedrate";
            this.sliderFeedrate.Value = 10;
            this.sliderFeedrate.Scroll += new System.EventHandler(this.sliderFeedrate_Scroll);
            // 
            // sliderStep
            // 
            this.sliderStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.sliderStep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sliderStep.LargeChange = 1;
            this.sliderStep.Location = new System.Drawing.Point(0, 47);
            this.sliderStep.Maximum = 16;
            this.sliderStep.Minimum = 1;
            this.sliderStep.Name = "sliderStep";
            this.sliderStep.Size = new System.Drawing.Size(376, 45);
            this.sliderStep.TabIndex = 0;
            this.sliderStep.Tag = "Step";
            this.sliderStep.Value = 5;
            this.sliderStep.Scroll += new System.EventHandler(this.sliderStep_Scroll);
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
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panelStatus.Controls.Add(this.panel1);
            this.panelStatus.Controls.Add(this.panelStatusBoxPadding);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 734);
            this.panelStatus.MaximumSize = new System.Drawing.Size(0, 20);
            this.panelStatus.MinimumSize = new System.Drawing.Size(0, 20);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(905, 20);
            this.panelStatus.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.textStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(90, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.panel1.Size = new System.Drawing.Size(815, 20);
            this.panel1.TabIndex = 1;
            // 
            // textStatus
            // 
            this.textStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.textStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textStatus.ForeColor = System.Drawing.Color.White;
            this.textStatus.Location = new System.Drawing.Point(6, 2);
            this.textStatus.Name = "textStatus";
            this.textStatus.ReadOnly = true;
            this.textStatus.Size = new System.Drawing.Size(807, 15);
            this.textStatus.TabIndex = 0;
            this.textStatus.Text = "STATUS_BAR_MESSAGE";
            // 
            // panelStatusBoxPadding
            // 
            this.panelStatusBoxPadding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelStatusBoxPadding.Controls.Add(this.textStatusBox);
            this.panelStatusBoxPadding.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStatusBoxPadding.Location = new System.Drawing.Point(0, 0);
            this.panelStatusBoxPadding.Name = "panelStatusBoxPadding";
            this.panelStatusBoxPadding.Padding = new System.Windows.Forms.Padding(3);
            this.panelStatusBoxPadding.Size = new System.Drawing.Size(90, 20);
            this.panelStatusBoxPadding.TabIndex = 2;
            // 
            // textStatusBox
            // 
            this.textStatusBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textStatusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStatusBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textStatusBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textStatusBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatusBox.ForeColor = System.Drawing.Color.White;
            this.textStatusBox.Location = new System.Drawing.Point(3, 3);
            this.textStatusBox.Name = "textStatusBox";
            this.textStatusBox.ReadOnly = true;
            this.textStatusBox.Size = new System.Drawing.Size(84, 14);
            this.textStatusBox.TabIndex = 1;
            this.textStatusBox.Text = "STATUS";
            this.textStatusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelForForms);
            this.panelMain.Controls.Add(this.panelStatus);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(32, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(905, 754);
            this.panelMain.TabIndex = 2;
            // 
            // panelForForms
            // 
            this.panelForForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panelForForms.Controls.Add(this.tabControl);
            this.panelForForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForForms.Location = new System.Drawing.Point(0, 0);
            this.panelForForms.Margin = new System.Windows.Forms.Padding(0);
            this.panelForForms.Name = "panelForForms";
            this.panelForForms.Size = new System.Drawing.Size(905, 734);
            this.panelForForms.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(905, 734);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(897, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1337, 754);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelStatusBoxPadding.ResumeLayout(false);
            this.panelStatusBoxPadding.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelForForms.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelSliderStepValue;
        private System.Windows.Forms.Label labelSliderFeedRateValue;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.Label labelFeedrate;
        private System.Windows.Forms.Panel panelStatusBoxPadding;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button goTerminalClear;
        private System.Windows.Forms.Button goTerminalCommands;
        private System.Windows.Forms.Button goTerminalConfig;
        private System.Windows.Forms.Button goTerminalPosition;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.ListBox listBoxTerminal;
        public System.Windows.Forms.TabControl tabControl;
    }
}

