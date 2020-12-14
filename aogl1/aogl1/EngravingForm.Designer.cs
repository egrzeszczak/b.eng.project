namespace AOGL
{
    partial class EngravingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EngravingForm));
            this.container = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxTerminal = new System.Windows.Forms.ListBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.labelProcent = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonHold = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTopWorking = new System.Windows.Forms.Panel();
            this.panelBottomWorking = new System.Windows.Forms.Panel();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.container.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelControl.SuspendLayout();
            this.panelLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.panel1);
            this.container.Controls.Add(this.panelControl);
            this.container.Controls.Add(this.panelLabels);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Margin = new System.Windows.Forms.Padding(0);
            this.container.Name = "container";
            this.container.Padding = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.container.Size = new System.Drawing.Size(798, 526);
            this.container.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.listBoxTerminal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 391);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(231, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 72);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uwaga! Zaloz okulary ochronne. \r\nPraca z laserem moze uszkodzic twoj wzrok. \r\nNie" +
    " patrz prosto na wiazke laserowa!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxTerminal
            // 
            this.listBoxTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.listBoxTerminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTerminal.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTerminal.ForeColor = System.Drawing.Color.White;
            this.listBoxTerminal.FormattingEnabled = true;
            this.listBoxTerminal.ItemHeight = 16;
            this.listBoxTerminal.Location = new System.Drawing.Point(7, 6);
            this.listBoxTerminal.Name = "listBoxTerminal";
            this.listBoxTerminal.ScrollAlwaysVisible = true;
            this.listBoxTerminal.Size = new System.Drawing.Size(776, 304);
            this.listBoxTerminal.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.labelProcent);
            this.panelControl.Controls.Add(this.labelTime);
            this.panelControl.Controls.Add(this.buttonHold);
            this.panelControl.Controls.Add(this.buttonEnd);
            this.panelControl.Controls.Add(this.progressBar);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(4, 38);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(790, 86);
            this.panelControl.TabIndex = 1;
            // 
            // labelProcent
            // 
            this.labelProcent.AutoSize = true;
            this.labelProcent.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcent.ForeColor = System.Drawing.Color.Gray;
            this.labelProcent.Location = new System.Drawing.Point(5, 63);
            this.labelProcent.Name = "labelProcent";
            this.labelProcent.Size = new System.Drawing.Size(74, 16);
            this.labelProcent.TabIndex = 5;
            this.labelProcent.Text = "labelProcent";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Gray;
            this.labelTime.Location = new System.Drawing.Point(5, 47);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(104, 16);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Obliczanie czasu...";
            // 
            // buttonHold
            // 
            this.buttonHold.BackColor = System.Drawing.Color.Silver;
            this.buttonHold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHold.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonHold.FlatAppearance.BorderSize = 2;
            this.buttonHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHold.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHold.ForeColor = System.Drawing.Color.Black;
            this.buttonHold.Location = new System.Drawing.Point(508, 49);
            this.buttonHold.Name = "buttonHold";
            this.buttonHold.Size = new System.Drawing.Size(79, 37);
            this.buttonHold.TabIndex = 2;
            this.buttonHold.Text = "Wstrzymaj";
            this.buttonHold.UseVisualStyleBackColor = false;
            this.buttonHold.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.BackColor = System.Drawing.Color.Firebrick;
            this.buttonEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnd.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.buttonEnd.FlatAppearance.BorderSize = 2;
            this.buttonEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnd.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnd.Location = new System.Drawing.Point(593, 49);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(190, 37);
            this.buttonEnd.TabIndex = 1;
            this.buttonEnd.Text = "Zakoncz";
            this.buttonEnd.UseVisualStyleBackColor = false;
            this.buttonEnd.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(8, 6);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 38);
            this.progressBar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wstrzymano!";
            // 
            // panelLabels
            // 
            this.panelLabels.Controls.Add(this.labelInstructions);
            this.panelLabels.Controls.Add(this.labelTitle);
            this.panelLabels.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabels.Location = new System.Drawing.Point(4, 12);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(790, 26);
            this.panelLabels.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 1);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(78, 21);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "labelTitle";
            // 
            // panelTopWorking
            // 
            this.panelTopWorking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopWorking.BackgroundImage")));
            this.panelTopWorking.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopWorking.Location = new System.Drawing.Point(0, 0);
            this.panelTopWorking.Name = "panelTopWorking";
            this.panelTopWorking.Size = new System.Drawing.Size(798, 7);
            this.panelTopWorking.TabIndex = 1;
            // 
            // panelBottomWorking
            // 
            this.panelBottomWorking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBottomWorking.BackgroundImage")));
            this.panelBottomWorking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBottomWorking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomWorking.Location = new System.Drawing.Point(0, 519);
            this.panelBottomWorking.Name = "panelBottomWorking";
            this.panelBottomWorking.Size = new System.Drawing.Size(798, 7);
            this.panelBottomWorking.TabIndex = 2;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.ForeColor = System.Drawing.Color.Gray;
            this.labelInstructions.Location = new System.Drawing.Point(695, 0);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(95, 16);
            this.labelInstructions.TabIndex = 4;
            this.labelInstructions.Text = "labelInstructions";
            // 
            // EngravingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(798, 526);
            this.Controls.Add(this.panelBottomWorking);
            this.Controls.Add(this.panelTopWorking);
            this.Controls.Add(this.container);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EngravingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grawerowanie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EngravingForm_FormClosed);
            this.Leave += new System.EventHandler(this.EngravingForm_Leave);
            this.container.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Panel panelTopWorking;
        private System.Windows.Forms.Panel panelBottomWorking;
        private System.Windows.Forms.Button buttonHold;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox listBoxTerminal;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProcent;
        private System.Windows.Forms.Label labelInstructions;
    }
}