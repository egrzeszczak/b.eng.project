namespace aogl1
{
    partial class CanvasForm
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
            this.labelFilename = new System.Windows.Forms.Label();
            this.panelCanvasPanel = new System.Windows.Forms.Panel();
            this.panelMainButtons = new System.Windows.Forms.Panel();
            this.goClose = new System.Windows.Forms.Button();
            this.goSimulate = new System.Windows.Forms.Button();
            this.goEngrave = new System.Windows.Forms.Button();
            this.panelPadding2 = new System.Windows.Forms.Panel();
            this.panelShowcase = new System.Windows.Forms.Panel();
            this.panelCanvasPanel.SuspendLayout();
            this.panelMainButtons.SuspendLayout();
            this.panelPadding2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFilename
            // 
            this.labelFilename.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilename.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFilename.Location = new System.Drawing.Point(7, 9);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(466, 22);
            this.labelFilename.TabIndex = 0;
            this.labelFilename.Text = "random_image.png";
            // 
            // panelCanvasPanel
            // 
            this.panelCanvasPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelCanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCanvasPanel.Controls.Add(this.panelMainButtons);
            this.panelCanvasPanel.Controls.Add(this.labelFilename);
            this.panelCanvasPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCanvasPanel.Location = new System.Drawing.Point(0, 613);
            this.panelCanvasPanel.MaximumSize = new System.Drawing.Size(1500, 40);
            this.panelCanvasPanel.Name = "panelCanvasPanel";
            this.panelCanvasPanel.Padding = new System.Windows.Forms.Padding(4);
            this.panelCanvasPanel.Size = new System.Drawing.Size(887, 40);
            this.panelCanvasPanel.TabIndex = 2;
            // 
            // panelMainButtons
            // 
            this.panelMainButtons.Controls.Add(this.goClose);
            this.panelMainButtons.Controls.Add(this.goSimulate);
            this.panelMainButtons.Controls.Add(this.goEngrave);
            this.panelMainButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMainButtons.Location = new System.Drawing.Point(479, 4);
            this.panelMainButtons.Name = "panelMainButtons";
            this.panelMainButtons.Size = new System.Drawing.Size(402, 30);
            this.panelMainButtons.TabIndex = 2;
            // 
            // goClose
            // 
            this.goClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.goClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.goClose.FlatAppearance.BorderSize = 2;
            this.goClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.goClose.Location = new System.Drawing.Point(2, 0);
            this.goClose.Margin = new System.Windows.Forms.Padding(10);
            this.goClose.Name = "goClose";
            this.goClose.Size = new System.Drawing.Size(100, 30);
            this.goClose.TabIndex = 4;
            this.goClose.Text = "Zamknij";
            this.goClose.UseVisualStyleBackColor = true;
            this.goClose.Click += new System.EventHandler(this.goClose_Click);
            // 
            // goSimulate
            // 
            this.goSimulate.BackColor = System.Drawing.Color.ForestGreen;
            this.goSimulate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goSimulate.Dock = System.Windows.Forms.DockStyle.Right;
            this.goSimulate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.goSimulate.FlatAppearance.BorderSize = 2;
            this.goSimulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goSimulate.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goSimulate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.goSimulate.Location = new System.Drawing.Point(102, 0);
            this.goSimulate.Margin = new System.Windows.Forms.Padding(10);
            this.goSimulate.Name = "goSimulate";
            this.goSimulate.Size = new System.Drawing.Size(150, 30);
            this.goSimulate.TabIndex = 3;
            this.goSimulate.Text = "Symuluj";
            this.goSimulate.UseVisualStyleBackColor = false;
            this.goSimulate.Click += new System.EventHandler(this.goSimulate_Click);
            // 
            // goEngrave
            // 
            this.goEngrave.BackColor = System.Drawing.Color.DodgerBlue;
            this.goEngrave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goEngrave.Dock = System.Windows.Forms.DockStyle.Right;
            this.goEngrave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.goEngrave.FlatAppearance.BorderSize = 2;
            this.goEngrave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goEngrave.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goEngrave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.goEngrave.Location = new System.Drawing.Point(252, 0);
            this.goEngrave.Margin = new System.Windows.Forms.Padding(10);
            this.goEngrave.Name = "goEngrave";
            this.goEngrave.Size = new System.Drawing.Size(150, 30);
            this.goEngrave.TabIndex = 2;
            this.goEngrave.Text = "Graweruj";
            this.goEngrave.UseVisualStyleBackColor = false;
            this.goEngrave.Click += new System.EventHandler(this.goEngrave_Click);
            // 
            // panelPadding2
            // 
            this.panelPadding2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelPadding2.Controls.Add(this.panelShowcase);
            this.panelPadding2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPadding2.Location = new System.Drawing.Point(0, 0);
            this.panelPadding2.Name = "panelPadding2";
            this.panelPadding2.Padding = new System.Windows.Forms.Padding(8);
            this.panelPadding2.Size = new System.Drawing.Size(887, 613);
            this.panelPadding2.TabIndex = 3;
            // 
            // panelShowcase
            // 
            this.panelShowcase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelShowcase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowcase.Location = new System.Drawing.Point(8, 8);
            this.panelShowcase.Name = "panelShowcase";
            this.panelShowcase.Padding = new System.Windows.Forms.Padding(10);
            this.panelShowcase.Size = new System.Drawing.Size(871, 597);
            this.panelShowcase.TabIndex = 4;
            // 
            // CanvasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(887, 653);
            this.Controls.Add(this.panelPadding2);
            this.Controls.Add(this.panelCanvasPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CanvasForm";
            this.Text = "CanvasForm";
            this.panelCanvasPanel.ResumeLayout(false);
            this.panelMainButtons.ResumeLayout(false);
            this.panelPadding2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Panel panelCanvasPanel;
        private System.Windows.Forms.Panel panelMainButtons;
        private System.Windows.Forms.Button goClose;
        private System.Windows.Forms.Button goSimulate;
        private System.Windows.Forms.Button goEngrave;
        private System.Windows.Forms.Panel panelPadding2;
        private System.Windows.Forms.Panel panelShowcase;
    }
}