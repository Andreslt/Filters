namespace SQL_Server
{
    partial class SQLSERVER
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLSERVER));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Query = new System.Windows.Forms.Button();
            this.btn_newView = new System.Windows.Forms.Button();
            this.btn_newTable = new System.Windows.Forms.Button();
            this.btn_NewDB = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.Pan_ModifyDB = new System.Windows.Forms.Panel();
            this.Drop_Table = new System.Windows.Forms.Label();
            this.Edit_Table = new System.Windows.Forms.Label();
            this.TreeView_Objects = new System.Windows.Forms.TreeView();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Pan_View = new System.Windows.Forms.Panel();
            this.lbl_DropView = new System.Windows.Forms.Label();
            this.See_Sql = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Merge = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.Pan_ModifyDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.Pan_View.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Excel);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Query);
            this.splitContainer1.Panel1.Controls.Add(this.btn_newView);
            this.splitContainer1.Panel1.Controls.Add(this.btn_newTable);
            this.splitContainer1.Panel1.Controls.Add(this.btn_NewDB);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Merge);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(759, 497);
            this.splitContainer1.SplitterDistance = 28;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(119, 1);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(68, 23);
            this.btn_Query.TabIndex = 3;
            this.btn_Query.Text = "Query";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_newView
            // 
            this.btn_newView.Enabled = false;
            this.btn_newView.Location = new System.Drawing.Point(639, 1);
            this.btn_newView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_newView.Name = "btn_newView";
            this.btn_newView.Size = new System.Drawing.Size(117, 23);
            this.btn_newView.TabIndex = 2;
            this.btn_newView.Text = "Create View";
            this.btn_newView.UseVisualStyleBackColor = true;
            this.btn_newView.Click += new System.EventHandler(this.btn_newView_Click);
            // 
            // btn_newTable
            // 
            this.btn_newTable.Enabled = false;
            this.btn_newTable.Location = new System.Drawing.Point(521, 1);
            this.btn_newTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_newTable.Name = "btn_newTable";
            this.btn_newTable.Size = new System.Drawing.Size(111, 24);
            this.btn_newTable.TabIndex = 1;
            this.btn_newTable.Text = "Create Table";
            this.btn_newTable.UseVisualStyleBackColor = true;
            this.btn_newTable.Click += new System.EventHandler(this.btn_newTable_Click);
            // 
            // btn_NewDB
            // 
            this.btn_NewDB.Location = new System.Drawing.Point(1, 1);
            this.btn_NewDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_NewDB.Name = "btn_NewDB";
            this.btn_NewDB.Size = new System.Drawing.Size(111, 24);
            this.btn_NewDB.TabIndex = 0;
            this.btn_NewDB.Text = "Create New DB";
            this.btn_NewDB.UseVisualStyleBackColor = true;
            this.btn_NewDB.Click += new System.EventHandler(this.btn_NewDB_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(759, 464);
            this.splitContainer2.SplitterDistance = 184;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.Pan_View);
            this.splitContainer3.Panel1.Controls.Add(this.Pan_ModifyDB);
            this.splitContainer3.Panel1.Controls.Add(this.TreeView_Objects);
            this.splitContainer3.Size = new System.Drawing.Size(184, 464);
            this.splitContainer3.SplitterDistance = 428;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // Pan_ModifyDB
            // 
            this.Pan_ModifyDB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pan_ModifyDB.Controls.Add(this.Drop_Table);
            this.Pan_ModifyDB.Controls.Add(this.Edit_Table);
            this.Pan_ModifyDB.Location = new System.Drawing.Point(80, 213);
            this.Pan_ModifyDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pan_ModifyDB.Name = "Pan_ModifyDB";
            this.Pan_ModifyDB.Size = new System.Drawing.Size(92, 49);
            this.Pan_ModifyDB.TabIndex = 1;
            this.Pan_ModifyDB.Visible = false;
            // 
            // Drop_Table
            // 
            this.Drop_Table.AutoSize = true;
            this.Drop_Table.Font = new System.Drawing.Font("Gadugi", 10F);
            this.Drop_Table.Location = new System.Drawing.Point(2, 23);
            this.Drop_Table.Name = "Drop_Table";
            this.Drop_Table.Size = new System.Drawing.Size(75, 17);
            this.Drop_Table.TabIndex = 1;
            this.Drop_Table.Text = "Drop Table";
            this.Drop_Table.Click += new System.EventHandler(this.Drop_Table_Click);
            // 
            // Edit_Table
            // 
            this.Edit_Table.AutoSize = true;
            this.Edit_Table.Font = new System.Drawing.Font("Gadugi", 10F);
            this.Edit_Table.Location = new System.Drawing.Point(3, 2);
            this.Edit_Table.Name = "Edit_Table";
            this.Edit_Table.Size = new System.Drawing.Size(67, 17);
            this.Edit_Table.TabIndex = 0;
            this.Edit_Table.Text = "Edit Table";
            this.Edit_Table.Click += new System.EventHandler(this.Edit_Table_Click);
            // 
            // TreeView_Objects
            // 
            this.TreeView_Objects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView_Objects.ImageIndex = 0;
            this.TreeView_Objects.ImageList = this.imageList1;
            this.TreeView_Objects.Location = new System.Drawing.Point(0, 0);
            this.TreeView_Objects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TreeView_Objects.Name = "TreeView_Objects";
            this.TreeView_Objects.SelectedImageIndex = 0;
            this.TreeView_Objects.Size = new System.Drawing.Size(184, 428);
            this.TreeView_Objects.TabIndex = 0;
            this.TreeView_Objects.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Objects_AfterSelect);
            this.TreeView_Objects.DoubleClick += new System.EventHandler(this.TreeView_Objects_DoubleClick);
            this.TreeView_Objects.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TreeView_Objects_MouseClick);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(570, 464);
            this.dataGridView.TabIndex = 0;
            // 
            // Pan_View
            // 
            this.Pan_View.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pan_View.Controls.Add(this.See_Sql);
            this.Pan_View.Controls.Add(this.lbl_DropView);
            this.Pan_View.Location = new System.Drawing.Point(78, 270);
            this.Pan_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pan_View.Name = "Pan_View";
            this.Pan_View.Size = new System.Drawing.Size(92, 50);
            this.Pan_View.TabIndex = 2;
            this.Pan_View.Visible = false;
            // 
            // lbl_DropView
            // 
            this.lbl_DropView.AutoSize = true;
            this.lbl_DropView.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_DropView.Location = new System.Drawing.Point(3, 2);
            this.lbl_DropView.Name = "lbl_DropView";
            this.lbl_DropView.Size = new System.Drawing.Size(68, 17);
            this.lbl_DropView.TabIndex = 0;
            this.lbl_DropView.Text = "DropView";
            this.lbl_DropView.Click += new System.EventHandler(this.lbl_DropView_Click);
            // 
            // See_Sql
            // 
            this.See_Sql.AutoSize = true;
            this.See_Sql.Font = new System.Drawing.Font("Gadugi", 10F);
            this.See_Sql.Location = new System.Drawing.Point(5, 25);
            this.See_Sql.Name = "See_Sql";
            this.See_Sql.Size = new System.Drawing.Size(33, 17);
            this.See_Sql.TabIndex = 1;
            this.See_Sql.Text = "SQL";
            this.See_Sql.Click += new System.EventHandler(this.See_Sql_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(570, 464);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // btn_Excel
            // 
            this.btn_Excel.Location = new System.Drawing.Point(194, 1);
            this.btn_Excel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(103, 23);
            this.btn_Excel.TabIndex = 4;
            this.btn_Excel.Text = "Export to Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Merge
            // 
            this.btn_Merge.Enabled = false;
            this.btn_Merge.Location = new System.Drawing.Point(639, 1);
            this.btn_Merge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Merge.Name = "btn_Merge";
            this.btn_Merge.Size = new System.Drawing.Size(117, 23);
            this.btn_Merge.TabIndex = 5;
            this.btn_Merge.Text = "Merge Databases";
            this.btn_Merge.UseVisualStyleBackColor = true;
            this.btn_Merge.Visible = false;
            this.btn_Merge.Click += new System.EventHandler(this.btn_Merge_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Database2.png");
            this.imageList1.Images.SetKeyName(1, "Table.png");
            this.imageList1.Images.SetKeyName(2, "Views.png");
            this.imageList1.Images.SetKeyName(3, "Server.png");
            // 
            // SQLSERVER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(759, 497);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Gadugi", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SQLSERVER";
            this.Text = "SQL SERVER LIGHT EDITION";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.Pan_ModifyDB.ResumeLayout(false);
            this.Pan_ModifyDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.Pan_View.ResumeLayout(false);
            this.Pan_View.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        public System.Windows.Forms.TreeView TreeView_Objects;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_NewDB;
        private System.Windows.Forms.Button btn_newView;
        private System.Windows.Forms.Button btn_newTable;
        private System.Windows.Forms.Panel Pan_ModifyDB;
        private System.Windows.Forms.Label Edit_Table;
        private System.Windows.Forms.Label Drop_Table;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.Panel Pan_View;
        private System.Windows.Forms.Label lbl_DropView;
        private System.Windows.Forms.Label See_Sql;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_Merge;
        private System.Windows.Forms.ImageList imageList1;
    }
}

