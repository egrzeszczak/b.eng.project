namespace AOGL
{
    partial class WelcomeForm
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.goGRBLConfig = new System.Windows.Forms.Button();
            this.goTest = new System.Windows.Forms.Button();
            this.goConnect = new System.Windows.Forms.Button();
            this.goLoadGCode = new System.Windows.Forms.Button();
            this.goOpenFile = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewLatest = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelMain);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(20);
            this.panelContainer.Size = new System.Drawing.Size(670, 597);
            this.panelContainer.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(20, 20);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(630, 557);
            this.panelMain.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.goGRBLConfig);
            this.panel4.Controls.Add(this.goTest);
            this.panel4.Controls.Add(this.goConnect);
            this.panel4.Controls.Add(this.goLoadGCode);
            this.panel4.Controls.Add(this.goOpenFile);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 257);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(630, 188);
            this.panel4.TabIndex = 4;
            // 
            // goGRBLConfig
            // 
            this.goGRBLConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goGRBLConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.goGRBLConfig.FlatAppearance.BorderSize = 0;
            this.goGRBLConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goGRBLConfig.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goGRBLConfig.ForeColor = System.Drawing.SystemColors.Highlight;
            this.goGRBLConfig.Location = new System.Drawing.Point(0, 124);
            this.goGRBLConfig.Name = "goGRBLConfig";
            this.goGRBLConfig.Size = new System.Drawing.Size(630, 31);
            this.goGRBLConfig.TabIndex = 3;
            this.goGRBLConfig.Text = "Ustawienia GRBL";
            this.goGRBLConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goGRBLConfig.UseVisualStyleBackColor = true;
            this.goGRBLConfig.Click += new System.EventHandler(this.goGRBLConfig_Click);
            // 
            // goTest
            // 
            this.goTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.goTest.FlatAppearance.BorderSize = 0;
            this.goTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goTest.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goTest.ForeColor = System.Drawing.SystemColors.Highlight;
            this.goTest.Location = new System.Drawing.Point(0, 93);
            this.goTest.Name = "goTest";
            this.goTest.Size = new System.Drawing.Size(630, 31);
            this.goTest.TabIndex = 2;
            this.goTest.Text = "Wykonaj grawer testowy";
            this.goTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goTest.UseVisualStyleBackColor = true;
            this.goTest.Click += new System.EventHandler(this.goTest_Click);
            // 
            // goConnect
            // 
            this.goConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.goConnect.FlatAppearance.BorderSize = 0;
            this.goConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goConnect.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goConnect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.goConnect.Location = new System.Drawing.Point(0, 62);
            this.goConnect.Name = "goConnect";
            this.goConnect.Size = new System.Drawing.Size(630, 31);
            this.goConnect.TabIndex = 4;
            this.goConnect.Text = "Polacz / Rozlacz";
            this.goConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goConnect.UseVisualStyleBackColor = true;
            this.goConnect.Click += new System.EventHandler(this.goConnect_Click);
            // 
            // goLoadGCode
            // 
            this.goLoadGCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goLoadGCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.goLoadGCode.FlatAppearance.BorderSize = 0;
            this.goLoadGCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goLoadGCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLoadGCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.goLoadGCode.Location = new System.Drawing.Point(0, 31);
            this.goLoadGCode.Name = "goLoadGCode";
            this.goLoadGCode.Size = new System.Drawing.Size(630, 31);
            this.goLoadGCode.TabIndex = 1;
            this.goLoadGCode.Text = "Otworz GCode";
            this.goLoadGCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goLoadGCode.UseVisualStyleBackColor = true;
            this.goLoadGCode.Click += new System.EventHandler(this.goLoadGCode_Click);
            // 
            // goOpenFile
            // 
            this.goOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.goOpenFile.FlatAppearance.BorderSize = 0;
            this.goOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goOpenFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goOpenFile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.goOpenFile.Location = new System.Drawing.Point(0, 0);
            this.goOpenFile.Name = "goOpenFile";
            this.goOpenFile.Size = new System.Drawing.Size(630, 31);
            this.goOpenFile.TabIndex = 0;
            this.goOpenFile.Text = "Otworz plik";
            this.goOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goOpenFile.UseVisualStyleBackColor = true;
            this.goOpenFile.Click += new System.EventHandler(this.goOpenFile_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 209);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panel3.Size = new System.Drawing.Size(630, 48);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Opcje";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewLatest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 100);
            this.panel2.TabIndex = 2;
            // 
            // listViewLatest
            // 
            this.listViewLatest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.listViewLatest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewLatest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPath});
            this.listViewLatest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLatest.ForeColor = System.Drawing.Color.White;
            this.listViewLatest.FullRowSelect = true;
            this.listViewLatest.Location = new System.Drawing.Point(0, 0);
            this.listViewLatest.Name = "listViewLatest";
            this.listViewLatest.Size = new System.Drawing.Size(630, 100);
            this.listViewLatest.TabIndex = 0;
            this.listViewLatest.UseCompatibleStateImageBehavior = false;
            this.listViewLatest.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Plik";
            this.columnName.Width = 134;
            // 
            // columnPath
            // 
            this.columnPath.Text = "Sciezka";
            this.columnPath.Width = 400;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panel1.Size = new System.Drawing.Size(630, 43);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ostatnie pliki";
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(630, 66);
            this.panelTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witaj";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(670, 597);
            this.Controls.Add(this.panelContainer);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WelcomeForm";
            this.panelContainer.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button goGRBLConfig;
        private System.Windows.Forms.Button goTest;
        private System.Windows.Forms.Button goConnect;
        private System.Windows.Forms.Button goOpenFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goLoadGCode;
        public System.Windows.Forms.ListView listViewLatest;
    }
}