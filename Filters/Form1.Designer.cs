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
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblExportarExcel = new System.Windows.Forms.Label();
            this.btn_ExportarExcel = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabFiltrar.SuspendLayout();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
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
            this.dTimePick.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dTimePick.MinDate = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.dTimePick.Name = "dTimePick";
            this.dTimePick.Size = new System.Drawing.Size(200, 20);
            this.dTimePick.TabIndex = 4;
            this.dTimePick.Value = new System.DateTime(2015, 2, 3, 0, 0, 0, 0);
            // 
            // btn_Continue
            // 
            this.btn_Continue.Enabled = false;
            this.btn_Continue.Location = new System.Drawing.Point(485, 97);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 148);
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 161);
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
            this.tabFiltrar.Size = new System.Drawing.Size(576, 135);
            this.tabFiltrar.TabIndex = 0;
            this.tabFiltrar.Text = "Filtrar";
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.dgvResults);
            this.tabResults.Controls.Add(this.lblExportarExcel);
            this.tabResults.Controls.Add(this.btn_ExportarExcel);
            this.tabResults.Controls.Add(this.comboBox2);
            this.tabResults.Controls.Add(this.btnConsultar);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Name = "tabResults";
            this.tabResults.Size = new System.Drawing.Size(576, 135);
            this.tabResults.TabIndex = 2;
            this.tabResults.Text = "Resultados";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(8, 86);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(860, 389);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.DataSourceChanged += new System.EventHandler(this.dgvResults_DataSourceChanged);
            // 
            // lblExportarExcel
            // 
            this.lblExportarExcel.AutoSize = true;
            this.lblExportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportarExcel.Location = new System.Drawing.Point(728, 28);
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
            this.btn_ExportarExcel.Location = new System.Drawing.Point(836, 19);
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
            this.comboBox2.Location = new System.Drawing.Point(19, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(163, 28);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 560);
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
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btn_ExportarExcel;
        private System.Windows.Forms.Label lblExportarExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}

