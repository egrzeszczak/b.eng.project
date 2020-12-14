namespace AOGL
{
    partial class WarningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTopWorking = new System.Windows.Forms.Panel();
            this.panelBottomWorking = new System.Windows.Forms.Panel();
            this.goBack = new System.Windows.Forms.Button();
            this.goAllow = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 72);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uwaga! Upewnij sie, ze urzadzenie jest gotowe do uzycia!\r\nZaloz okulary ochronne." +
    " Nie patrz prosto na wiazke laserowa.\r\nLasera nie mozna uzywac dluzej niz 15 min" +
    " bez przerwy.\r\n";
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
            // panelTopWorking
            // 
            this.panelTopWorking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopWorking.BackgroundImage")));
            this.panelTopWorking.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopWorking.Location = new System.Drawing.Point(0, 0);
            this.panelTopWorking.Name = "panelTopWorking";
            this.panelTopWorking.Size = new System.Drawing.Size(479, 7);
            this.panelTopWorking.TabIndex = 3;
            // 
            // panelBottomWorking
            // 
            this.panelBottomWorking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBottomWorking.BackgroundImage")));
            this.panelBottomWorking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBottomWorking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomWorking.Location = new System.Drawing.Point(0, 148);
            this.panelBottomWorking.Name = "panelBottomWorking";
            this.panelBottomWorking.Size = new System.Drawing.Size(479, 7);
            this.panelBottomWorking.TabIndex = 4;
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.Firebrick;
            this.goBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBack.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.goBack.FlatAppearance.BorderSize = 2;
            this.goBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBack.ForeColor = System.Drawing.Color.White;
            this.goBack.Location = new System.Drawing.Point(56, 100);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(190, 37);
            this.goBack.TabIndex = 5;
            this.goBack.Text = "Cofnij";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // goAllow
            // 
            this.goAllow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.goAllow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goAllow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.goAllow.FlatAppearance.BorderSize = 2;
            this.goAllow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goAllow.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goAllow.ForeColor = System.Drawing.Color.White;
            this.goAllow.Location = new System.Drawing.Point(252, 100);
            this.goAllow.Name = "goAllow";
            this.goAllow.Size = new System.Drawing.Size(190, 37);
            this.goAllow.TabIndex = 6;
            this.goAllow.Text = "Rozpocznij";
            this.goAllow.UseVisualStyleBackColor = false;
            this.goAllow.Click += new System.EventHandler(this.goAllow_Click);
            // 
            // WarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(479, 155);
            this.Controls.Add(this.goAllow);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.panelBottomWorking);
            this.Controls.Add(this.panelTopWorking);
            this.Controls.Add(this.panel2);
            this.Name = "WarningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ostrzezenie";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTopWorking;
        private System.Windows.Forms.Panel panelBottomWorking;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button goAllow;
    }
}