namespace AOGL
{
    partial class RasterOptions
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.feedRateBox = new System.Windows.Forms.NumericUpDown();
            this.powerMinBox = new System.Windows.Forms.NumericUpDown();
            this.powerMaxBox = new System.Windows.Forms.NumericUpDown();
            this.goOK = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedRateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerMinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerMaxBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(444, 234);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.goBack);
            this.panel2.Controls.Add(this.goOK);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 214);
            this.panel2.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.powerMaxBox);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 90);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(424, 45);
            this.panel9.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Moc maksymalna";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.powerMinBox);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 45);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(424, 45);
            this.panel8.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Moc minimalna";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.feedRateBox);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(424, 45);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Feedrate";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.styleBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 45);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Styl grawerowania";
            // 
            // styleBox
            // 
            this.styleBox.BackColor = System.Drawing.Color.White;
            this.styleBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.styleBox.FormattingEnabled = true;
            this.styleBox.Location = new System.Drawing.Point(0, 19);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(424, 21);
            this.styleBox.TabIndex = 1;
            this.styleBox.Text = "Horizontal";
            // 
            // feedRateBox
            // 
            this.feedRateBox.BackColor = System.Drawing.Color.White;
            this.feedRateBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.feedRateBox.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.feedRateBox.Location = new System.Drawing.Point(0, 19);
            this.feedRateBox.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.feedRateBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.feedRateBox.Name = "feedRateBox";
            this.feedRateBox.Size = new System.Drawing.Size(424, 20);
            this.feedRateBox.TabIndex = 1;
            this.feedRateBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // powerMinBox
            // 
            this.powerMinBox.BackColor = System.Drawing.Color.White;
            this.powerMinBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.powerMinBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.powerMinBox.Location = new System.Drawing.Point(0, 19);
            this.powerMinBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.powerMinBox.Name = "powerMinBox";
            this.powerMinBox.Size = new System.Drawing.Size(424, 20);
            this.powerMinBox.TabIndex = 2;
            // 
            // powerMaxBox
            // 
            this.powerMaxBox.BackColor = System.Drawing.Color.White;
            this.powerMaxBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.powerMaxBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.powerMaxBox.Location = new System.Drawing.Point(0, 19);
            this.powerMaxBox.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.powerMaxBox.Name = "powerMaxBox";
            this.powerMaxBox.Size = new System.Drawing.Size(424, 20);
            this.powerMaxBox.TabIndex = 2;
            this.powerMaxBox.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // goOK
            // 
            this.goOK.ForeColor = System.Drawing.Color.Black;
            this.goOK.Location = new System.Drawing.Point(349, 186);
            this.goOK.Name = "goOK";
            this.goOK.Size = new System.Drawing.Size(75, 23);
            this.goOK.TabIndex = 7;
            this.goOK.Text = "OK";
            this.goOK.UseVisualStyleBackColor = true;
            this.goOK.Click += new System.EventHandler(this.goOK_Click);
            // 
            // goBack
            // 
            this.goBack.ForeColor = System.Drawing.Color.Black;
            this.goBack.Location = new System.Drawing.Point(268, 186);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 23);
            this.goBack.TabIndex = 8;
            this.goBack.Text = "Cofnij";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // RasterOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(444, 234);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RasterOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RasterOptions";
            this.Load += new System.EventHandler(this.RasterOptions_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedRateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerMinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerMaxBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox styleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown powerMaxBox;
        private System.Windows.Forms.NumericUpDown powerMinBox;
        private System.Windows.Forms.NumericUpDown feedRateBox;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button goOK;
    }
}