namespace SQL_Server
{
    partial class Query
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
            this.RTxt_Query = new System.Windows.Forms.RichTextBox();
            this.btn_TbCancel = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.cmb_Tables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmbx_Databases = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RTxt_Query
            // 
            this.RTxt_Query.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxt_Query.Location = new System.Drawing.Point(8, 76);
            this.RTxt_Query.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RTxt_Query.Name = "RTxt_Query";
            this.RTxt_Query.Size = new System.Drawing.Size(308, 139);
            this.RTxt_Query.TabIndex = 1;
            this.RTxt_Query.Text = "";
            this.RTxt_Query.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RTxt_Query_KeyUp);
            // 
            // btn_TbCancel
            // 
            this.btn_TbCancel.Location = new System.Drawing.Point(7, 222);
            this.btn_TbCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_TbCancel.Name = "btn_TbCancel";
            this.btn_TbCancel.Size = new System.Drawing.Size(87, 42);
            this.btn_TbCancel.TabIndex = 22;
            this.btn_TbCancel.Text = "Cancel";
            this.btn_TbCancel.UseVisualStyleBackColor = true;
            this.btn_TbCancel.Click += new System.EventHandler(this.btn_TbCancel_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Enabled = false;
            this.btn_Generate.Location = new System.Drawing.Point(230, 222);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(87, 42);
            this.btn_Generate.TabIndex = 23;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // cmb_Tables
            // 
            this.cmb_Tables.FormattingEnabled = true;
            this.cmb_Tables.Location = new System.Drawing.Point(83, 43);
            this.cmb_Tables.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Tables.Name = "cmb_Tables";
            this.cmb_Tables.Size = new System.Drawing.Size(234, 24);
            this.cmb_Tables.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Database";
            // 
            // Cmbx_Databases
            // 
            this.Cmbx_Databases.FormattingEnabled = true;
            this.Cmbx_Databases.Location = new System.Drawing.Point(83, 7);
            this.Cmbx_Databases.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cmbx_Databases.Name = "Cmbx_Databases";
            this.Cmbx_Databases.Size = new System.Drawing.Size(234, 24);
            this.Cmbx_Databases.TabIndex = 27;
            this.Cmbx_Databases.SelectedIndexChanged += new System.EventHandler(this.Cmbx_Databases_SelectedIndexChanged);
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 266);
            this.Controls.Add(this.Cmbx_Databases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Tables);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.btn_TbCancel);
            this.Controls.Add(this.RTxt_Query);
            this.Font = new System.Drawing.Font("Gadugi", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Query";
            this.Text = "Query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox RTxt_Query;
        public System.Windows.Forms.Button btn_TbCancel;
        public System.Windows.Forms.Button btn_Generate;
        public System.Windows.Forms.ComboBox cmb_Tables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox Cmbx_Databases;
    }
}