namespace SQL_Server
{
    partial class NewDBs
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dbname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nvistas = new System.Windows.Forms.TextBox();
            this.txt_ntablas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Cancel2 = new System.Windows.Forms.Button();
            this.btn_Create2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Database Name";
            // 
            // txt_dbname
            // 
            this.txt_dbname.Location = new System.Drawing.Point(121, 17);
            this.txt_dbname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dbname.Name = "txt_dbname";
            this.txt_dbname.Size = new System.Drawing.Size(162, 25);
            this.txt_dbname.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nvistas);
            this.groupBox1.Controls.Add(this.txt_ntablas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(14, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(269, 106);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // txt_nvistas
            // 
            this.txt_nvistas.Location = new System.Drawing.Point(129, 70);
            this.txt_nvistas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nvistas.Name = "txt_nvistas";
            this.txt_nvistas.Size = new System.Drawing.Size(74, 25);
            this.txt_nvistas.TabIndex = 10;
            // 
            // txt_ntablas
            // 
            this.txt_ntablas.Location = new System.Drawing.Point(129, 23);
            this.txt_ntablas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ntablas.Name = "txt_ntablas";
            this.txt_ntablas.Size = new System.Drawing.Size(74, 25);
            this.txt_ntablas.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "No. Tables";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "No. Views";
            // 
            // btn_Cancel2
            // 
            this.btn_Cancel2.Location = new System.Drawing.Point(14, 177);
            this.btn_Cancel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel2.Name = "btn_Cancel2";
            this.btn_Cancel2.Size = new System.Drawing.Size(87, 28);
            this.btn_Cancel2.TabIndex = 16;
            this.btn_Cancel2.Text = "Cancel";
            this.btn_Cancel2.UseVisualStyleBackColor = true;
            this.btn_Cancel2.Click += new System.EventHandler(this.btn_Cancel2_Click);
            // 
            // btn_Create2
            // 
            this.btn_Create2.Location = new System.Drawing.Point(196, 177);
            this.btn_Create2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Create2.Name = "btn_Create2";
            this.btn_Create2.Size = new System.Drawing.Size(87, 28);
            this.btn_Create2.TabIndex = 15;
            this.btn_Create2.Text = "Create";
            this.btn_Create2.UseVisualStyleBackColor = true;
            this.btn_Create2.Click += new System.EventHandler(this.btn_Create2_Click);
            // 
            // NewDBs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 212);
            this.Controls.Add(this.btn_Cancel2);
            this.Controls.Add(this.btn_Create2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_dbname);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Gadugi", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewDBs";
            this.Text = "NewDBs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dbname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nvistas;
        private System.Windows.Forms.TextBox txt_ntablas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Cancel2;
        private System.Windows.Forms.Button btn_Create2;


    }
}