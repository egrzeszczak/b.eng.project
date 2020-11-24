namespace aogl1
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
            this.greetingLabel = new System.Windows.Forms.Label();
            this.recentFilesLabel = new System.Windows.Forms.Label();
            this.recentFileLabel1 = new System.Windows.Forms.Label();
            this.recentFileLabel2 = new System.Windows.Forms.Label();
            this.recentFileLabel3 = new System.Windows.Forms.Label();
            this.recentFileLabel4 = new System.Windows.Forms.Label();
            this.recentFileLabel5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.greetingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.greetingLabel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greetingLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.greetingLabel.Location = new System.Drawing.Point(0, 0);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(409, 73);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "Welcome back!";
            this.greetingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recentFilesLabel
            // 
            this.recentFilesLabel.AutoSize = true;
            this.recentFilesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.recentFilesLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.recentFilesLabel.Location = new System.Drawing.Point(0, 73);
            this.recentFilesLabel.Name = "recentFilesLabel";
            this.recentFilesLabel.Size = new System.Drawing.Size(165, 37);
            this.recentFilesLabel.TabIndex = 1;
            this.recentFilesLabel.Text = " Recent files";
            // 
            // recentFileLabel1
            // 
            this.recentFileLabel1.AutoSize = true;
            this.recentFileLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.recentFileLabel1.Location = new System.Drawing.Point(0, 110);
            this.recentFileLabel1.Name = "recentFileLabel1";
            this.recentFileLabel1.Size = new System.Drawing.Size(0, 17);
            this.recentFileLabel1.TabIndex = 2;
            // 
            // recentFileLabel2
            // 
            this.recentFileLabel2.AutoSize = true;
            this.recentFileLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.recentFileLabel2.Location = new System.Drawing.Point(0, 127);
            this.recentFileLabel2.Name = "recentFileLabel2";
            this.recentFileLabel2.Size = new System.Drawing.Size(0, 17);
            this.recentFileLabel2.TabIndex = 3;
            // 
            // recentFileLabel3
            // 
            this.recentFileLabel3.AutoSize = true;
            this.recentFileLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.recentFileLabel3.Location = new System.Drawing.Point(0, 144);
            this.recentFileLabel3.Name = "recentFileLabel3";
            this.recentFileLabel3.Size = new System.Drawing.Size(0, 17);
            this.recentFileLabel3.TabIndex = 4;
            // 
            // recentFileLabel4
            // 
            this.recentFileLabel4.AutoSize = true;
            this.recentFileLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.recentFileLabel4.Location = new System.Drawing.Point(0, 161);
            this.recentFileLabel4.Name = "recentFileLabel4";
            this.recentFileLabel4.Size = new System.Drawing.Size(0, 17);
            this.recentFileLabel4.TabIndex = 5;
            // 
            // recentFileLabel5
            // 
            this.recentFileLabel5.AutoSize = true;
            this.recentFileLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.recentFileLabel5.Location = new System.Drawing.Point(0, 178);
            this.recentFileLabel5.Name = "recentFileLabel5";
            this.recentFileLabel5.Size = new System.Drawing.Size(0, 17);
            this.recentFileLabel5.TabIndex = 6;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recentFileLabel5);
            this.Controls.Add(this.recentFileLabel4);
            this.Controls.Add(this.recentFileLabel3);
            this.Controls.Add(this.recentFileLabel2);
            this.Controls.Add(this.recentFileLabel1);
            this.Controls.Add(this.recentFilesLabel);
            this.Controls.Add(this.greetingLabel);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Label recentFilesLabel;
        private System.Windows.Forms.Label recentFileLabel1;
        private System.Windows.Forms.Label recentFileLabel2;
        private System.Windows.Forms.Label recentFileLabel3;
        private System.Windows.Forms.Label recentFileLabel4;
        private System.Windows.Forms.Label recentFileLabel5;
    }
}