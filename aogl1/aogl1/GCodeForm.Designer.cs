namespace AOGL
{
    partial class GCodeForm
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
            this.panelEditorContainer = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LineNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelButtonPadding = new System.Windows.Forms.Panel();
            this.goEngrave = new System.Windows.Forms.Button();
            this.goClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContainer.SuspendLayout();
            this.panelEditorContainer.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelButtonPadding.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelEditorContainer);
            this.panelContainer.Controls.Add(this.LineNumberTextBox);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 450);
            this.panelContainer.TabIndex = 0;
            // 
            // panelEditorContainer
            // 
            this.panelEditorContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.panelEditorContainer.Controls.Add(this.richTextBox1);
            this.panelEditorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditorContainer.Location = new System.Drawing.Point(58, 0);
            this.panelEditorContainer.Name = "panelEditorContainer";
            this.panelEditorContainer.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panelEditorContainer.Size = new System.Drawing.Size(742, 450);
            this.panelEditorContainer.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(4, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(738, 450);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
            this.richTextBox1.FontChanged += new System.EventHandler(this.richTextBox1_FontChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // LineNumberTextBox
            // 
            this.LineNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.LineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineNumberTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LineNumberTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.LineNumberTextBox.Location = new System.Drawing.Point(0, 0);
            this.LineNumberTextBox.Name = "LineNumberTextBox";
            this.LineNumberTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LineNumberTextBox.Size = new System.Drawing.Size(58, 450);
            this.LineNumberTextBox.TabIndex = 0;
            this.LineNumberTextBox.Text = "";
            this.LineNumberTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LineNumberTextBox_MouseDown);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panelHeader.Controls.Add(this.panelButtonPadding);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHeader.Location = new System.Drawing.Point(0, 426);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 24);
            this.panelHeader.TabIndex = 5;
            // 
            // panelButtonPadding
            // 
            this.panelButtonPadding.Controls.Add(this.goEngrave);
            this.panelButtonPadding.Controls.Add(this.goClose);
            this.panelButtonPadding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtonPadding.Location = new System.Drawing.Point(0, 0);
            this.panelButtonPadding.Name = "panelButtonPadding";
            this.panelButtonPadding.Size = new System.Drawing.Size(800, 24);
            this.panelButtonPadding.TabIndex = 7;
            // 
            // goEngrave
            // 
            this.goEngrave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.goEngrave.Dock = System.Windows.Forms.DockStyle.Right;
            this.goEngrave.FlatAppearance.BorderSize = 0;
            this.goEngrave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goEngrave.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goEngrave.ForeColor = System.Drawing.Color.Black;
            this.goEngrave.Location = new System.Drawing.Point(729, 0);
            this.goEngrave.Name = "goEngrave";
            this.goEngrave.Size = new System.Drawing.Size(71, 24);
            this.goEngrave.TabIndex = 7;
            this.goEngrave.Text = "Graweruj";
            this.goEngrave.UseVisualStyleBackColor = false;
            this.goEngrave.Click += new System.EventHandler(this.goEngrave_Click);
            // 
            // goClose
            // 
            this.goClose.Dock = System.Windows.Forms.DockStyle.Left;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 6;
            // 
            // GCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GCodeForm";
            this.Text = "GCodeForm";
            this.Load += new System.EventHandler(this.GCodeForm_Load);
            this.Resize += new System.EventHandler(this.GCodeForm_Resize);
            this.panelContainer.ResumeLayout(false);
            this.panelEditorContainer.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelButtonPadding.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelEditorContainer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox LineNumberTextBox;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelButtonPadding;
        private System.Windows.Forms.Button goClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button goEngrave;
    }
}