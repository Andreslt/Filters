namespace SQL_Server
{
    partial class Merge
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
            this.Cmbx_Database1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmbx_Database2 = new System.Windows.Forms.ComboBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.btn_TbCancel = new System.Windows.Forms.Button();
            this.Chbx_NewTab = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NewDB = new System.Windows.Forms.TextBox();
            this.Destinity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cmbx_Database1
            // 
            this.Cmbx_Database1.FormattingEnabled = true;
            this.Cmbx_Database1.Location = new System.Drawing.Point(83, 22);
            this.Cmbx_Database1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cmbx_Database1.Name = "Cmbx_Database1";
            this.Cmbx_Database1.Size = new System.Drawing.Size(234, 24);
            this.Cmbx_Database1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Database 1";
            // 
            // Cmbx_Database2
            // 
            this.Cmbx_Database2.FormattingEnabled = true;
            this.Cmbx_Database2.Location = new System.Drawing.Point(83, 58);
            this.Cmbx_Database2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cmbx_Database2.Name = "Cmbx_Database2";
            this.Cmbx_Database2.Size = new System.Drawing.Size(234, 24);
            this.Cmbx_Database2.TabIndex = 28;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(280, 133);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(87, 42);
            this.btn_Generate.TabIndex = 35;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // btn_TbCancel
            // 
            this.btn_TbCancel.Location = new System.Drawing.Point(13, 133);
            this.btn_TbCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TbCancel.Name = "btn_TbCancel";
            this.btn_TbCancel.Size = new System.Drawing.Size(87, 42);
            this.btn_TbCancel.TabIndex = 34;
            this.btn_TbCancel.Text = "Cancel";
            this.btn_TbCancel.UseVisualStyleBackColor = true;
            this.btn_TbCancel.Click += new System.EventHandler(this.btn_TbCancel_Click);
            // 
            // Chbx_NewTab
            // 
            this.Chbx_NewTab.AutoSize = true;
            this.Chbx_NewTab.Location = new System.Drawing.Point(14, 105);
            this.Chbx_NewTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Chbx_NewTab.Name = "Chbx_NewTab";
            this.Chbx_NewTab.Size = new System.Drawing.Size(115, 21);
            this.Chbx_NewTab.TabIndex = 36;
            this.Chbx_NewTab.Text = "New Database";
            this.Chbx_NewTab.UseVisualStyleBackColor = true;
            this.Chbx_NewTab.CheckStateChanged += new System.EventHandler(this.Chbx_NewTab_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Database 2";
            // 
            // txt_NewDB
            // 
            this.txt_NewDB.Location = new System.Drawing.Point(134, 105);
            this.txt_NewDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NewDB.Name = "txt_NewDB";
            this.txt_NewDB.Size = new System.Drawing.Size(233, 25);
            this.txt_NewDB.TabIndex = 38;
            this.txt_NewDB.Visible = false;
            // 
            // Destinity
            // 
            this.Destinity.AutoSize = true;
            this.Destinity.Location = new System.Drawing.Point(318, 63);
            this.Destinity.Name = "Destinity";
            this.Destinity.Size = new System.Drawing.Size(70, 17);
            this.Destinity.TabIndex = 39;
            this.Destinity.Text = "(Destinity)";
            // 
            // Merge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 176);
            this.Controls.Add(this.Destinity);
            this.Controls.Add(this.txt_NewDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chbx_NewTab);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.btn_TbCancel);
            this.Controls.Add(this.Cmbx_Database1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmbx_Database2);
            this.Font = new System.Drawing.Font("Gadugi", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Merge";
            this.Text = "Merge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox Cmbx_Database1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox Cmbx_Database2;
        public System.Windows.Forms.Button btn_Generate;
        public System.Windows.Forms.Button btn_TbCancel;
        private System.Windows.Forms.CheckBox Chbx_NewTab;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_NewDB;
        private System.Windows.Forms.Label Destinity;
    }
}