namespace AOGL
{
    partial class GRBLConfigEditForm
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
            this.inputOption = new System.Windows.Forms.TextBox();
            this.labelOption = new System.Windows.Forms.Label();
            this.goOK = new System.Windows.Forms.Button();
            this.goCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputOption
            // 
            this.inputOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.inputOption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputOption.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputOption.ForeColor = System.Drawing.Color.White;
            this.inputOption.Location = new System.Drawing.Point(12, 31);
            this.inputOption.Name = "inputOption";
            this.inputOption.Size = new System.Drawing.Size(273, 17);
            this.inputOption.TabIndex = 0;
            this.inputOption.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputOption_KeyDown);
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption.ForeColor = System.Drawing.Color.White;
            this.labelOption.Location = new System.Drawing.Point(8, 9);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(80, 19);
            this.labelOption.TabIndex = 1;
            this.labelOption.Text = "labelOption";
            // 
            // goOK
            // 
            this.goOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.goOK.FlatAppearance.BorderSize = 0;
            this.goOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goOK.ForeColor = System.Drawing.Color.White;
            this.goOK.Location = new System.Drawing.Point(210, 56);
            this.goOK.Name = "goOK";
            this.goOK.Size = new System.Drawing.Size(75, 23);
            this.goOK.TabIndex = 2;
            this.goOK.Text = "OK";
            this.goOK.UseVisualStyleBackColor = false;
            this.goOK.Click += new System.EventHandler(this.goOK_Click);
            // 
            // goCancel
            // 
            this.goCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.goCancel.FlatAppearance.BorderSize = 0;
            this.goCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goCancel.ForeColor = System.Drawing.Color.White;
            this.goCancel.Location = new System.Drawing.Point(12, 56);
            this.goCancel.Name = "goCancel";
            this.goCancel.Size = new System.Drawing.Size(75, 23);
            this.goCancel.TabIndex = 3;
            this.goCancel.Text = "Cancel";
            this.goCancel.UseVisualStyleBackColor = false;
            this.goCancel.Click += new System.EventHandler(this.goCancel_Click);
            // 
            // GRBLConfigEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(297, 91);
            this.Controls.Add(this.goCancel);
            this.Controls.Add(this.goOK);
            this.Controls.Add(this.labelOption);
            this.Controls.Add(this.inputOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GRBLConfigEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRBLConfigEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button goOK;
        private System.Windows.Forms.Button goCancel;
        public System.Windows.Forms.TextBox inputOption;
        public System.Windows.Forms.Label labelOption;
    }
}