namespace AOGL
{
    partial class TestForm
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
            this.panelTests = new System.Windows.Forms.Panel();
            this.goCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.panelTests);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(10);
            this.panelContainer.Size = new System.Drawing.Size(807, 412);
            this.panelContainer.TabIndex = 0;
            // 
            // panelTests
            // 
            this.panelTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panelTests.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTests.Location = new System.Drawing.Point(10, 10);
            this.panelTests.Name = "panelTests";
            this.panelTests.Size = new System.Drawing.Size(787, 348);
            this.panelTests.TabIndex = 0;
            // 
            // goCancel
            // 
            this.goCancel.BackColor = System.Drawing.Color.Firebrick;
            this.goCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.goCancel.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.goCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goCancel.ForeColor = System.Drawing.Color.White;
            this.goCancel.Location = new System.Drawing.Point(640, 0);
            this.goCancel.Name = "goCancel";
            this.goCancel.Size = new System.Drawing.Size(147, 35);
            this.goCancel.TabIndex = 0;
            this.goCancel.Text = "Cofnij";
            this.goCancel.UseVisualStyleBackColor = false;
            this.goCancel.Click += new System.EventHandler(this.goCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.goCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 35);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grawerowanie testowe\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wybierz element do grawerowania testowego.";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(807, 412);
            this.Controls.Add(this.panelContainer);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wykonaj grawer testowy";
            this.panelContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button goCancel;
        private System.Windows.Forms.Panel panelTests;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}