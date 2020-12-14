namespace AOGL
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
            this.panelPadding2 = new System.Windows.Forms.Panel();
            this.panelShowcase = new System.Windows.Forms.Panel();
            this.goClose = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goGCode = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelPadding2.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPadding2
            // 
            this.panelPadding2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panelPadding2.Controls.Add(this.panelShowcase);
            this.panelPadding2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPadding2.Location = new System.Drawing.Point(0, 0);
            this.panelPadding2.Name = "panelPadding2";
            this.panelPadding2.Size = new System.Drawing.Size(817, 453);
            this.panelPadding2.TabIndex = 3;
            // 
            // panelShowcase
            // 
            this.panelShowcase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(70)))), ((int)(((byte)(124)))));
            this.panelShowcase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShowcase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowcase.Location = new System.Drawing.Point(0, 0);
            this.panelShowcase.Name = "panelShowcase";
            this.panelShowcase.Padding = new System.Windows.Forms.Padding(10);
            this.panelShowcase.Size = new System.Drawing.Size(817, 453);
            this.panelShowcase.TabIndex = 4;
            // 
            // goClose
            // 
            this.goClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.goClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.goClose.FlatAppearance.BorderSize = 0;
            this.goClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goClose.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goClose.ForeColor = System.Drawing.Color.White;
            this.goClose.Location = new System.Drawing.Point(0, 0);
            this.goClose.Name = "goClose";
            this.goClose.Size = new System.Drawing.Size(71, 24);
            this.goClose.TabIndex = 6;
            this.goClose.Text = "Zamknij";
            this.goClose.UseVisualStyleBackColor = true;
            this.goClose.Click += new System.EventHandler(this.goClose_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panelFooter.Controls.Add(this.panel1);
            this.panelFooter.Controls.Add(this.goClose);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 453);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(817, 24);
            this.panelFooter.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.goGCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(71, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 24);
            this.panel1.TabIndex = 7;
            // 
            // goGCode
            // 
            this.goGCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.goGCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.goGCode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.goGCode.FlatAppearance.BorderSize = 0;
            this.goGCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goGCode.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goGCode.ForeColor = System.Drawing.Color.White;
            this.goGCode.Location = new System.Drawing.Point(675, 0);
            this.goGCode.Name = "goGCode";
            this.goGCode.Size = new System.Drawing.Size(71, 24);
            this.goGCode.TabIndex = 6;
            this.goGCode.Text = "GCode";
            this.goGCode.UseVisualStyleBackColor = false;
            this.goGCode.Click += new System.EventHandler(this.goGCode_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelMain);
            this.panelContainer.Controls.Add(this.panelFooter);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(817, 477);
            this.panelContainer.TabIndex = 6;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelPadding2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(817, 453);
            this.panelMain.TabIndex = 6;
            // 
            // CanvasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(817, 477);
            this.Controls.Add(this.panelContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CanvasForm";
            this.Text = "CanvasForm";
            this.panelPadding2.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPadding2;
        private System.Windows.Forms.Panel panelShowcase;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button goClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button goGCode;
    }
}