namespace AOGL
{
    partial class GRBLConfigurationForm
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
            this.goFetchConfig = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listOptions = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.goWriteConfig = new System.Windows.Forms.Button();
            this.goLoad = new System.Windows.Forms.Button();
            this.goSave = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.goSave);
            this.panelContainer.Controls.Add(this.goLoad);
            this.panelContainer.Controls.Add(this.goWriteConfig);
            this.panelContainer.Controls.Add(this.goFetchConfig);
            this.panelContainer.Controls.Add(this.groupBox1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(10);
            this.panelContainer.Size = new System.Drawing.Size(676, 570);
            this.panelContainer.TabIndex = 0;
            // 
            // goFetchConfig
            // 
            this.goFetchConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.goFetchConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.goFetchConfig.FlatAppearance.BorderSize = 2;
            this.goFetchConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goFetchConfig.ForeColor = System.Drawing.Color.White;
            this.goFetchConfig.Location = new System.Drawing.Point(10, 535);
            this.goFetchConfig.Name = "goFetchConfig";
            this.goFetchConfig.Size = new System.Drawing.Size(93, 23);
            this.goFetchConfig.TabIndex = 2;
            this.goFetchConfig.Text = "Pobierz";
            this.goFetchConfig.UseVisualStyleBackColor = false;
            this.goFetchConfig.Click += new System.EventHandler(this.goFetchConfig_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listOptions);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konfiguracja GRBL";
            // 
            // listOptions
            // 
            this.listOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.listOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnDescription,
            this.columnValue});
            this.listOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOptions.ForeColor = System.Drawing.Color.White;
            this.listOptions.FullRowSelect = true;
            this.listOptions.HideSelection = false;
            this.listOptions.Location = new System.Drawing.Point(3, 16);
            this.listOptions.Name = "listOptions";
            this.listOptions.Size = new System.Drawing.Size(650, 500);
            this.listOptions.TabIndex = 0;
            this.listOptions.UseCompatibleStateImageBehavior = false;
            this.listOptions.View = System.Windows.Forms.View.Details;
            this.listOptions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listOptions_MouseDoubleClick);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnName
            // 
            this.columnName.Text = "Opcja";
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Opis";
            // 
            // columnValue
            // 
            this.columnValue.Text = "Wartosc";
            // 
            // goWriteConfig
            // 
            this.goWriteConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.goWriteConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.goWriteConfig.FlatAppearance.BorderSize = 2;
            this.goWriteConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goWriteConfig.ForeColor = System.Drawing.Color.White;
            this.goWriteConfig.Location = new System.Drawing.Point(109, 535);
            this.goWriteConfig.Name = "goWriteConfig";
            this.goWriteConfig.Size = new System.Drawing.Size(93, 23);
            this.goWriteConfig.TabIndex = 3;
            this.goWriteConfig.Text = "Wgraj";
            this.goWriteConfig.UseVisualStyleBackColor = false;
            this.goWriteConfig.Click += new System.EventHandler(this.goWriteConfig_Click);
            // 
            // goLoad
            // 
            this.goLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.goLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.goLoad.FlatAppearance.BorderSize = 2;
            this.goLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goLoad.ForeColor = System.Drawing.Color.White;
            this.goLoad.Location = new System.Drawing.Point(208, 535);
            this.goLoad.Name = "goLoad";
            this.goLoad.Size = new System.Drawing.Size(93, 23);
            this.goLoad.TabIndex = 4;
            this.goLoad.Text = "Wczytaj";
            this.goLoad.UseVisualStyleBackColor = false;
            this.goLoad.Click += new System.EventHandler(this.goLoad_Click);
            // 
            // goSave
            // 
            this.goSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.goSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.goSave.FlatAppearance.BorderSize = 2;
            this.goSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goSave.ForeColor = System.Drawing.Color.White;
            this.goSave.Location = new System.Drawing.Point(307, 535);
            this.goSave.Name = "goSave";
            this.goSave.Size = new System.Drawing.Size(93, 23);
            this.goSave.TabIndex = 5;
            this.goSave.Text = "Zapisz";
            this.goSave.UseVisualStyleBackColor = false;
            this.goSave.Click += new System.EventHandler(this.goSave_Click);
            // 
            // GRBLConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(676, 570);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GRBLConfigurationForm";
            this.Text = "GRBLConfigurationForm";
            this.Load += new System.EventHandler(this.GRBLConfigurationForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listOptions;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnValue;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.Button goFetchConfig;
        private System.Windows.Forms.Button goWriteConfig;
        private System.Windows.Forms.Button goSave;
        private System.Windows.Forms.Button goLoad;
    }
}