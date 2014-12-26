namespace Filters
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_folderRoute = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dTimePick = new System.Windows.Forms.DateTimePicker();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFiltrar = new System.Windows.Forms.TabPage();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.lblExportarExcel = new System.Windows.Forms.Label();
            this.btn_ExportarExcel = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Ingresar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_ConsultarPor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabFiltrar.SuspendLayout();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.tabConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_folderRoute
            // 
            this.btn_folderRoute.Location = new System.Drawing.Point(4, 63);
            this.btn_folderRoute.Name = "btn_folderRoute";
            this.btn_folderRoute.Size = new System.Drawing.Size(102, 22);
            this.btn_folderRoute.TabIndex = 0;
            this.btn_folderRoute.Text = "Ruta de Carpeta";
            this.btn_folderRoute.UseVisualStyleBackColor = true;
            this.btn_folderRoute.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(112, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 22);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dTimePick
            // 
            this.dTimePick.Location = new System.Drawing.Point(112, 18);
            this.dTimePick.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dTimePick.MinDate = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.dTimePick.Name = "dTimePick";
            this.dTimePick.Size = new System.Drawing.Size(200, 20);
            this.dTimePick.TabIndex = 4;
            this.dTimePick.Value = new System.DateTime(2014, 12, 10, 20, 16, 6, 0);
            // 
            // btn_Continue
            // 
            this.btn_Continue.Enabled = false;
            this.btn_Continue.Location = new System.Drawing.Point(485, 106);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(75, 33);
            this.btn_Continue.TabIndex = 6;
            this.btn_Continue.Text = "Continuar";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Download";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB2);
            this.groupBox1.Controls.Add(this.rB1);
            this.groupBox1.Location = new System.Drawing.Point(9, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 66);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Enabled = false;
            this.rB2.Location = new System.Drawing.Point(7, 43);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(137, 17);
            this.rB2.TabIndex = 1;
            this.rB2.Text = "Archivos seleccionados";
            this.rB2.UseVisualStyleBackColor = true;
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Enabled = false;
            this.rB1.Location = new System.Drawing.Point(7, 20);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(114, 17);
            this.rB1.TabIndex = 0;
            this.rB1.Text = "Todos los archivos";
            this.rB1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFiltrar);
            this.tabControl1.Controls.Add(this.tabResults);
            this.tabControl1.Controls.Add(this.tabConsultar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 211);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabFiltrar
            // 
            this.tabFiltrar.BackColor = System.Drawing.SystemColors.Window;
            this.tabFiltrar.Controls.Add(this.label1);
            this.tabFiltrar.Controls.Add(this.groupBox1);
            this.tabFiltrar.Controls.Add(this.btn_folderRoute);
            this.tabFiltrar.Controls.Add(this.textBox1);
            this.tabFiltrar.Controls.Add(this.btn_Continue);
            this.tabFiltrar.Controls.Add(this.dTimePick);
            this.tabFiltrar.Location = new System.Drawing.Point(4, 22);
            this.tabFiltrar.Name = "tabFiltrar";
            this.tabFiltrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiltrar.Size = new System.Drawing.Size(576, 185);
            this.tabFiltrar.TabIndex = 0;
            this.tabFiltrar.Text = "Filtrar";
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.lblExportarExcel);
            this.tabResults.Controls.Add(this.btn_ExportarExcel);
            this.tabResults.Controls.Add(this.comboBox2);
            this.tabResults.Controls.Add(this.btnConsultar);
            this.tabResults.Controls.Add(this.dgvResults);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Name = "tabResults";
            this.tabResults.Size = new System.Drawing.Size(576, 186);
            this.tabResults.TabIndex = 2;
            this.tabResults.Text = "Resultados";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // lblExportarExcel
            // 
            this.lblExportarExcel.AutoSize = true;
            this.lblExportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportarExcel.Location = new System.Drawing.Point(431, 23);
            this.lblExportarExcel.Name = "lblExportarExcel";
            this.lblExportarExcel.Size = new System.Drawing.Size(96, 15);
            this.lblExportarExcel.TabIndex = 4;
            this.lblExportarExcel.Text = "Exportar a Excel";
            this.lblExportarExcel.Visible = false;
            // 
            // btn_ExportarExcel
            // 
            this.btn_ExportarExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ExportarExcel.Image = global::Filters.Properties.Resources.application_vnd_ms_excel;
            this.btn_ExportarExcel.Location = new System.Drawing.Point(530, 13);
            this.btn_ExportarExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ExportarExcel.Name = "btn_ExportarExcel";
            this.btn_ExportarExcel.Size = new System.Drawing.Size(32, 36);
            this.btn_ExportarExcel.TabIndex = 3;
            this.btn_ExportarExcel.UseVisualStyleBackColor = false;
            this.btn_ExportarExcel.Visible = false;
            this.btn_ExportarExcel.Click += new System.EventHandler(this.btn_ExportarExcel_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Reporte Diario"});
            this.comboBox2.Location = new System.Drawing.Point(8, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(146, 13);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(7, 55);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(555, 219);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.DataSourceChanged += new System.EventHandler(this.dgvResults_DataSourceChanged);
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.monthCalendar1);
            this.tabConsultar.Controls.Add(this.textBox2);
            this.tabConsultar.Controls.Add(this.label_Ingresar);
            this.tabConsultar.Controls.Add(this.comboBox1);
            this.tabConsultar.Controls.Add(this.label_ConsultarPor);
            this.tabConsultar.Controls.Add(this.dataGridView1);
            this.tabConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultar.Size = new System.Drawing.Size(576, 186);
            this.tabConsultar.TabIndex = 1;
            this.tabConsultar.Text = "Consultar";
            this.tabConsultar.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(14, 106);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label_Ingresar
            // 
            this.label_Ingresar.AutoSize = true;
            this.label_Ingresar.Location = new System.Drawing.Point(11, 74);
            this.label_Ingresar.Name = "label_Ingresar";
            this.label_Ingresar.Size = new System.Drawing.Size(45, 13);
            this.label_Ingresar.TabIndex = 3;
            this.label_Ingresar.Text = "Ingresar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fecha",
            "No. Solicitud",
            "No. Parte",
            "Asistente",
            "Todo"});
            this.comboBox1.Location = new System.Drawing.Point(84, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label_ConsultarPor
            // 
            this.label_ConsultarPor.AutoSize = true;
            this.label_ConsultarPor.Location = new System.Drawing.Point(8, 32);
            this.label_ConsultarPor.Name = "label_ConsultarPor";
            this.label_ConsultarPor.Size = new System.Drawing.Size(69, 13);
            this.label_ConsultarPor.TabIndex = 1;
            this.label_ConsultarPor.Text = "Consultar por";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(285, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 211);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 250);
            this.Name = "Form1";
            this.Text = "ALTUM AEROSPACE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabFiltrar.ResumeLayout(false);
            this.tabFiltrar.PerformLayout();
            this.tabResults.ResumeLayout(false);
            this.tabResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.tabConsultar.ResumeLayout(false);
            this.tabConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_folderRoute;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dTimePick;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFiltrar;
        private System.Windows.Forms.TabPage tabConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_ConsultarPor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_Ingresar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btn_ExportarExcel;
        private System.Windows.Forms.Label lblExportarExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

