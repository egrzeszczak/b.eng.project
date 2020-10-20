namespace aogl1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.label2 = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelLaser.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitControl)).BeginInit();
            this.splitControl.Panel1.SuspendLayout();
            this.splitControl.Panel2.SuspendLayout();
            this.splitControl.SuspendLayout();
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
            this.panelSideMenu.Size = new System.Drawing.Size(64, 661);
            this.panelSideMenu.TabIndex = 0;
            // 
            // menuLeave
            // 
            this.menuLeave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuLeave.FlatAppearance.BorderSize = 0;
            this.menuLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuLeave.ForeColor = System.Drawing.Color.White;
            this.menuLeave.Image = ((System.Drawing.Image)(resources.GetObject("menuLeave.Image")));
            this.menuLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuLeave.Location = new System.Drawing.Point(0, 599);
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
            this.goTest.Dock = System.Windows.Forms.DockStyle.Top;
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
            // 
            // goDriver
            // 
            this.goDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
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
            this.goDriver.Text = "Sterownik";
            this.goDriver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goDriver.UseVisualStyleBackColor = false;
            // 
            // goConnect
            // 
            this.goConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
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
            // 
            // menuLaser
            // 
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
            // 
            // goExport
            // 
            this.goExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.goExport.Dock = System.Windows.Forms.DockStyle.Top;
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
            // 
            // goLoadGCode
            // 
            this.goLoadGCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
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
            // 
            // goLoadFile
            // 
            this.goLoadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
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
            // 
            // menuFile
            // 
            this.menuFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.panelControl.Location = new System.Drawing.Point(784, 0);
            this.panelControl.MaximumSize = new System.Drawing.Size(400, 0);
            this.panelControl.MinimumSize = new System.Drawing.Size(400, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Padding = new System.Windows.Forms.Padding(4);
            this.panelControl.Size = new System.Drawing.Size(400, 661);
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
            this.splitControl.Panel1.Controls.Add(this.label2);
            this.splitControl.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // splitControl.Panel2
            // 
            this.splitControl.Panel2.Controls.Add(this.panelStatus);
            this.splitControl.Panel2.Controls.Add(this.label1);
            this.splitControl.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitControl.Size = new System.Drawing.Size(392, 653);
            this.splitControl.SplitterDistance = 325;
            this.splitControl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Terminal";
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(4, 298);
            this.panelStatus.MaximumSize = new System.Drawing.Size(0, 20);
            this.panelStatus.MinimumSize = new System.Drawing.Size(0, 20);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(382, 20);
            this.panelStatus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel kontrolny";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(64, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(720, 661);
            this.panelMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.Text = "AOGL1";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelMain;
    }
}

