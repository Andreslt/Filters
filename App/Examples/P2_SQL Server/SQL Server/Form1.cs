using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace SQL_Server
{
    public partial class SQLSERVER : Form
    {
        public SQLSERVER()
        {
            InitializeComponent();
            Login();
        }

        public List<string> DataBases;
        public Login log;        
        List<string> TablasBD;
        List<string> VistasBD;
        TreeNode ServerNode;
        String VQuery;
        NewElements tabElements = new NewElements();
        NewElements viewElements = new NewElements();
        public String[] Servers;
        public List<Type> Tipos = new List<Type>();
        public bool addnode = true,editable=false;
        private void Login()
        {
            log = new Login();
            if (log.ShowDialog(this) == DialogResult.OK)
            {
                    String x = log.Conn.UserID;
                    CargarBDs(log);
                    ServerNode=new TreeNode(log.CmBx_Servidores.SelectedItem.ToString());
                    TreeView_Objects.Nodes.Add(ServerNode);
                    TreeView_Objects.Nodes[0].ImageIndex = 3;
                    int i = 0;
                    foreach(String Elem in DataBases)
                    {
                        if (i > 3)
                        { TreeView_Objects.Nodes[0].Nodes.Add(Elem);}
                        i++;
                    }               
            }              
        }
       
        private void CargarBDs(Login log)
        {
            using (SqlConnection connection = new SqlConnection(log.Conn.ToString()))
            {
                try
                {
                    connection.Open();
                    DataTable schema_db = connection.GetSchema("Databases");
                    DataBases = new List<string>();                    
                    foreach (DataRow row in schema_db.Rows)
                    {
                        DataBases.Add(row["database_name"].ToString());
                    }
                    connection.Close();
                    Gettablas(log);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }
        }

        private void Gettablas(Login log)
        {
            TablasBD = new List<string>();
            VistasBD = new List<string>();            
            using (SqlConnection connection = new SqlConnection(log.Conn.ToString()))
            {
                connection.Open();
                DataTable schema = connection.GetSchema("Tables");
                foreach (DataRow row in schema.Rows)
                {
                    String tabla = row[2].ToString();
                    if (row.ItemArray[3].Equals("BASE TABLE"))
                    {
                        Tipos.Add(row.Table.Columns[0].DataType);
                        TablasBD.Add(tabla);
                    }
                    else
                        if (row.ItemArray[3].Equals("VIEW"))
                            VistasBD.Add(tabla);                    
                }
                connection.Close();
            }
        }

        private void TreeView_Objects_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode Nodo = e.Node;
            TreeNode Nodo2;
            dataGridView.Visible = true;
            richTextBox1.Visible = false;
            btn_newTable.Enabled = false;
            btn_newView.Enabled = false;            
            if(Nodo.ImageKey.Equals(""))
            {
                if (Nodo.Parent == ServerNode)
                {
                    log.Conn.InitialCatalog = Nodo.Text;
                    Nodo.ImageIndex = 1;
                    Nodo.ImageKey="Seleccionado";
                    Gettablas(log);
                    Nodo2 = TreeView_Objects.Nodes[0].Nodes[Nodo.Index].Nodes.Add("Tables");
                    Nodo2.ImageIndex = 1;
                    Nodo2 = TreeView_Objects.Nodes[0].Nodes[Nodo.Index].Nodes.Add("Views");
                    Nodo2.ImageIndex = 2;
                }
                else
                {
                    if (Nodo.Parent != null)
                    {
                        log.Conn.InitialCatalog = Nodo.Parent.Text;
                        
                        if (Nodo.Text == "Tables")
                        {
                            Gettablas(log);
                            btn_newTable.Enabled = true;
                            foreach (String element in TablasBD)
                            {
                                Nodo2 = TreeView_Objects.Nodes[0].Nodes[Nodo.Parent.Index].Nodes[Nodo.Index].Nodes.Add(element);
                                if (Nodo2.ImageKey.Equals(""))
                                Nodo2.ImageIndex = 1;
                                Nodo.ImageKey = "Seleccionado";
                            }
                        }
                        else
                        {
                            if (Nodo.Text == "Views")
                            {
                                Gettablas(log);
                                btn_newView.Enabled = true;
                                foreach (String element in VistasBD)
                                {
                                    Nodo2 = TreeView_Objects.Nodes[0].Nodes[Nodo.Parent.Index].Nodes[Nodo.Index].Nodes.Add(element);
                                    if (Nodo2.ImageKey.Equals(""))
                                    Nodo2.ImageIndex = 2;
                                    Nodo.ImageKey = "Seleccionado";
                                }
                            }
                        }
                    }
                    
                }
            }


            if (Nodo.Text == "Tables")
            {
                btn_newTable.Enabled = true;
            }else
            {
                if (Nodo.Text == "Views")
                btn_newView.Enabled = true;
            }
        }

        public void Creates(int type, String name, String table, String db)
        {
            String str,str2="";
            if (type == 1) 
            { 
              str = "TABLE "; 
              name="[dbo].["+name+"]";
              if (tabElements.Properties)
              {
                  ListBox.ObjectCollection List = tabElements.LBx_Columns.Items;
                  ComboBox.ObjectCollection Coltype = tabElements.Cmbx_ColType.Items;
                  List<int> Types = tabElements.TypeColumns;
                  str2 = "(";
                  int index, tipo,i=0;
                  foreach (var item in List)
                  {
                      String Pk = item.ToString().Contains("PK")?" IDENTITY(1,1) PRIMARY KEY CLUSTERED":"";                      
                      index=item.ToString().IndexOf(",");
                      str2 += item.ToString().Substring(0,index)+" ";
                      tipo = Types[i];
                      str2 += Coltype[tipo].ToString()+Pk;
                      if (i < List.Count - 1)
                      { str2 += ", "; }
                      else { str2 += ")"; }
                      i++;
                  }                  
              }else
              str2 = "(Id int IDENTITY(1,1) PRIMARY KEY CLUSTERED, Name varchar(50))"; 
            } else 
                { 
                    if (type == 2) 
                    { str = "VIEW ";
                    name += " AS";
                    str2 = " SELECT " + viewElements.Cmbx_Columns.SelectedItem.ToString() + " FROM " + table;
                    VQuery = str2;
                    } else 
                        { 
                        str = "DATABASE "; 
                        TreeView_Objects.Nodes[0].Nodes.Add(name); 
                    } 
            }
            
            if (TreeView_Objects.SelectedNode.Parent!=ServerNode) 
            {
                log.Conn.InitialCatalog = db;
            }  
                        
          using (SqlConnection connection = new SqlConnection(log.Conn.ToString()))
                {
                    try
                    {
                        String strSQLCommand = "CREATE " + str + name + str2;                        
                        connection.Open();                                              
                        SqlCommand command = new SqlCommand(strSQLCommand, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        addnode = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha Ocurrido un Error. Lo siento!\nError: "+ex.Message);
                        addnode = false;
                    }                    
                }
        }

        private void btn_NewDB_Click(object sender, EventArgs e)
        {
            NewDBs newbiedb = new NewDBs(this);
            if (newbiedb.ShowDialog(this) == DialogResult.OK)
            {}
        }

        private void btn_newTable_Click(object sender, EventArgs e)
        {
            tabElements.Height=325;
            tabElements.Width = 477;
            viewElements.tab1 = true;
            tabElements.tabControl1.SelectedIndex = 0;
            tabElements.btn_TbCancel.Enabled = true;
            tabElements.btn_TbCreate.Enabled = true;
            tabElements.btn_Add.Enabled = true;
            tabElements.txt_Tablename.Enabled = true;
            tabElements.txt_ColName.Enabled = true;
            tabElements.Chbx_NULL.Enabled = true;
            tabElements.Chbx_PK.Enabled = true;
            tabElements.Cmbx_ColType.Enabled = true;
            tabElements.btn_Delete.Enabled = true;
            tabElements.btn_VCancel.Enabled = false;
            tabElements.btn_VCreate.Enabled = false;
            if (tabElements.ShowDialog(this) == DialogResult.OK)
            {
                Creates(1, tabElements.txt_Tablename.Text, "", TreeView_Objects.SelectedNode.Parent.Text);
                if(addnode)
                TreeView_Objects.Nodes[0].Nodes[TreeView_Objects.SelectedNode.Parent.Index].Nodes[TreeView_Objects.SelectedNode.Index].Nodes.Add(tabElements.txt_Tablename.Text);
            }            
        }

        private void btn_newView_Click(object sender, EventArgs e)
        {
            viewElements.Height = 191;
            viewElements.Width = 477;
            viewElements.tab1 = false;
            viewElements.Cmbx_Columns.Items.Clear();
            viewElements.Cmbx_Tables.Items.Clear();
            viewElements.txt_ViewName.Clear();
            ((Control)this.viewElements.tabControl1.TabPages[0]).Enabled = false;
            viewElements.tabControl1.SelectedIndex = 1;
            viewElements.btn_TbCancel.Enabled = false;
            viewElements.btn_TbCreate.Enabled = false;
            viewElements.btn_Add.Enabled = false;
            viewElements.Chbx_NULL.Enabled = false;
            viewElements.Chbx_PK.Enabled = false;
            viewElements.txt_Tablename.Enabled = false;
            viewElements.txt_ColName.Enabled = false;
            viewElements.Cmbx_ColType.Enabled = false;
            viewElements.btn_Delete.Enabled = false;
            viewElements.btn_VCancel.Enabled = true;
            viewElements.btn_VCreate.Enabled = true;
            CargarTablas();
            TreeNode Node=new TreeNode();
            viewElements.Database= log.Conn.InitialCatalog;
            viewElements.Connect = log.Conn.ToString();
            if (viewElements.ShowDialog(this) == DialogResult.OK)
            {
                Creates(2, viewElements.txt_ViewName.Text, viewElements.Cmbx_Tables.SelectedItem.ToString(), TreeView_Objects.SelectedNode.Parent.Text);
                if (addnode)
                    Node=TreeView_Objects.Nodes[0].Nodes[TreeView_Objects.SelectedNode.Parent.Index].Nodes[TreeView_Objects.SelectedNode.Index].Nodes.Add(viewElements.txt_ViewName.Text);
                    Node.Tag = VQuery;
            }
        }

        private void TreeView_Objects_DoubleClick(object sender, EventArgs e)
        {
            TreeNode Nodo=TreeView_Objects.SelectedNode;
            if (Nodo.Parent.Text.Equals("Tables") || Nodo.Parent.Text.Equals("Views"))
            {
                DataTable dt = new DataTable();
                String Database=Nodo.Parent.Parent.Text;
                String strSQLCommand = "USE " + Database + "; SELECT TOP 1000 * FROM " + Nodo.Text;
                log.Conn.InitialCatalog = Database;
                SqlConnection connection = new SqlConnection(log.Conn.ToString());
                SqlCommand command = new SqlCommand(strSQLCommand,connection);                
                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                sqlDA.Fill(dt);
                connection.Close();
                dataGridView.DataSource = dt;
            }
        }

        public void CargarTablas()
        {
            viewElements.Cmbx_Tables.Items.Clear();
            String Db =TreeView_Objects.SelectedNode.Parent.Text;
            log.Conn.InitialCatalog = Db;
            Gettablas(log);
            foreach (var item in TablasBD)
            {
                viewElements.Cmbx_Tables.Items.Add(item.ToString());
            }
        }

        private void TreeView_Objects_MouseClick(object sender, MouseEventArgs e)
        {
            Pan_ModifyDB.Visible = false;
            Pan_View.Visible = false;
            MouseButtons button = e.Button;
            TreeNode Nodo=TreeView_Objects.SelectedNode;
            if(button.ToString().Equals("Right"))
                if (Nodo.Parent.ToString().Contains("Tables"))
                {
                    Pan_ModifyDB.Visible = true;
                    Point Mpos = e.Location; Mpos.X -= 2;
                    Pan_ModifyDB.Location = Mpos;
                }else
                {
                    if (Nodo.Parent.ToString().Contains("Views"))
                        Pan_View.Visible = true;
                        Point Mpos = e.Location; Mpos.X -= 2;
                        Pan_View.Location = Mpos;
                }
        }

        private void Edit_Table_Click(object sender, EventArgs e)
        {
            String tab=TreeView_Objects.SelectedNode.Text;
            editable = true;
            tabElements.btn_Modify.Visible = true;
            tabElements.btn_Modify.Enabled = true;
            tabElements.btn_TbCreate.Visible = false;
            tabElements.Height = 325;
            tabElements.Width = 477;
            tabElements.tab1 = true;
            tabElements.tabControl1.SelectedIndex = 0;
            tabElements.btn_TbCancel.Enabled = true;
            tabElements.btn_TbCreate.Enabled = false;
            tabElements.btn_Add.Enabled = false;
            tabElements.txt_Tablename.Enabled = true;
            tabElements.txt_ColName.Enabled = false;
            tabElements.Chbx_NULL.Enabled = false;
            tabElements.Chbx_PK.Enabled = false;
            tabElements.Cmbx_ColType.Enabled = false;
            tabElements.btn_Delete.Enabled = false;
            tabElements.btn_VCancel.Enabled = false;
            tabElements.btn_VCreate.Enabled = false;
            tabElements.txt_Tablename.Text = tab;            
            tabElements.txt_Tablename.BackColor=Color.SeaShell;
            Pan_ModifyDB.Visible = false;
            tabElements.Nodo = TreeView_Objects.SelectedNode;
            log.Conn.InitialCatalog = TreeView_Objects.SelectedNode.Parent.Parent.Text;
            tabElements.connection = new SqlConnection(log.Conn.ToString());
            if (tabElements.ShowDialog(this) == DialogResult.OK)
            {
                TreeView_Objects.Nodes[0].Nodes[TreeView_Objects.SelectedNode.Parent.Parent.Index].Nodes[TreeView_Objects.SelectedNode.Parent.Index].Nodes[TreeView_Objects.SelectedNode.Index].Remove();
                TreeView_Objects.Nodes[0].Nodes[TreeView_Objects.SelectedNode.Parent.Parent.Index].Nodes[TreeView_Objects.SelectedNode.Parent.Index].Nodes.Add(tabElements.txt_Tablename.Text);
            }            
            editable = false;
            tabElements.btn_Modify.Visible = false;
        }

        private void Drop_Table_Click(object sender, EventArgs e)
        {
            String table=TreeView_Objects.SelectedNode.Text;
            MessageBoxButtons botones;
            Pan_ModifyDB.Visible = false;
            botones = MessageBoxButtons.OKCancel;
            if(MessageBox.Show("Esta seguro que desea borrar esta tabla?", "Borrar Tabla", botones)==DialogResult.OK)
            {
                try
                {
                    log.Conn.InitialCatalog = TreeView_Objects.SelectedNode.Parent.Parent.Text;
                    SqlConnection connection = new SqlConnection(log.Conn.ToString());
                    String strSQLCommand = "DROP TABLE " + table;
                    connection.Open();
                    SqlCommand command = new SqlCommand(strSQLCommand, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    TreeView_Objects.SelectedNode.Remove();
                }
                catch (Exception)
                {}
                
            }
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            Query Q = new Query(log, DataBases);
            if (Q.ShowDialog(this) == DialogResult.OK)
            {
                
                DataTable dt = new DataTable();
                String query=Q.RTxt_Query.Text;
                String Database = Q.Cmbx_Databases.SelectedItem.ToString();
                String strSQLCommand = "USE " + Database + " "+query;
                log.Conn.InitialCatalog = Database;
                SqlConnection connection = new SqlConnection(log.Conn.ToString());
                SqlCommand command = new SqlCommand(strSQLCommand, connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                    sqlDA.Fill(dt);
                    connection.Close();
                    dataGridView.DataSource = dt;
                }
                catch (Exception)
                {
                    MessageBox.Show("Verificar el Query Ingresado!");
                }                
            }
        }

        private void lbl_DropView_Click(object sender, EventArgs e)
        {
            String View = TreeView_Objects.SelectedNode.Text;
            MessageBoxButtons botones;
            Pan_View.Visible = false;
            botones = MessageBoxButtons.OKCancel;
            if (MessageBox.Show("Esta seguro que desea borrar esta Vista?", "Borrar Vista", botones) == DialogResult.OK)
            {
                try
                {
                    log.Conn.InitialCatalog = TreeView_Objects.SelectedNode.Parent.Parent.Text;
                    SqlConnection connection = new SqlConnection(log.Conn.ToString());
                    String strSQLCommand = "DROP VIEW " + View;
                    connection.Open();
                    SqlCommand command = new SqlCommand(strSQLCommand, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    TreeView_Objects.SelectedNode.Remove();
                }
                catch (Exception)
                { }

            }
        }

        private void See_Sql_Click(object sender, EventArgs e)
        {
            dataGridView.Visible = false;
            richTextBox1.Visible = true;
            if(TreeView_Objects.SelectedNode.Tag!=null)
            richTextBox1.Text=TreeView_Objects.SelectedNode.Tag.ToString();
            Pan_View.Visible = false;
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {            
            object misValue = System.Reflection.Missing.Value;
            DataTable dt = (DataTable)dataGridView.DataSource;
            SaveFileDialog Guardar=new SaveFileDialog();
            Guardar.Filter = "Archivo Microsoft Excel|.xls";
            Guardar.Title = "Guardar archivo Excel";
            var ExcelApp= new Excel.Application();
            var sf = Guardar.ShowDialog();
                if(sf == DialogResult.OK)
                {
                    try
                    {
                        Microsoft.Office.Interop.Excel.Workbook wb = null;
                        Microsoft.Office.Interop.Excel.Worksheet ws = null;

                        wb = ExcelApp.Workbooks.Add(misValue);
                        ws = ExcelApp.ActiveWorkbook.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

                        Microsoft.Office.Interop.Excel.Range range;

                        range = ws.get_Range("A2", misValue);
                        range = range.get_Resize(dt.Rows.Count, dt.Columns.Count);

                        Microsoft.Office.Interop.Excel.Range columnNameRange;
                        columnNameRange = ws.get_Range("A1", misValue);
                        columnNameRange = columnNameRange.get_Resize(1, dt.Columns.Count);

                        string[] columNames = new string[dt.Columns.Count];

                        for (int i = 0; i < dt.Columns.Count; i++)
                        columNames[i] = dt.Columns[i].ColumnName;
                        columnNameRange.set_Value(misValue, columNames);

                        string[,] arr = new string[dt.Rows.Count, dt.Columns.Count];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            for (int j = 0; j < dt.Columns.Count; j++)
                            {
                                arr[i, j] = dt.Rows[i][j].ToString();
                            }
                        }
                        range.set_Value(misValue, arr);
                        wb.Close(true, Guardar.FileName, misValue);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                        finally
                    {
                        // make sure the office process quit after certain operations done.
                        if (ExcelApp != null)
                        {
                            ExcelApp.UserControl = false;
                            ExcelApp.Quit();
                            ExcelApp = null;
                        }
                    }
                }
        }

        private void btn_Merge_Click(object sender, EventArgs e)
        {
            Merge M = new Merge(log, DataBases);
            List<String> TablasBD1 = new List<String>();
            List<Type> TiposBD1 = new List<Type>();
            List<String> TablasBD2 = new List<String>();
            List<Type> TiposBD2 = new List<Type>();
            SqlConnection connection = new SqlConnection(log.Conn.ToString());
            TreeNode Nodo=new TreeNode();
            if (M.ShowDialog(this) == DialogResult.OK)
            {

                //Database1
                String Database1 = M.Cmbx_Database1.SelectedItem.ToString();
                log.Conn.InitialCatalog = Database1;
                Gettablas(log);
                TablasBD1 = TablasBD;
                TiposBD1 = Tipos;

                //Database2
                String Database2= M.Cmbx_Database2.SelectedItem.ToString();
                log.Conn.InitialCatalog = Database2;
                Gettablas(log);
                TablasBD2 = TablasBD;
                TiposBD2 = Tipos;

                if(M.NewBD)
                {
                    String strSQLCommand = "CREATE DATABASE " + M.txt_NewDB.Text;
                    connection.Open();
                    SqlCommand command = new SqlCommand(strSQLCommand, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    Nodo=TreeView_Objects.Nodes[0].Nodes.Add(M.txt_NewDB.Text);
                }else
                {
                    Nodo = TreeView_Objects.Nodes[0].Nodes[M.Cmbx_Database2.SelectedIndex];
                }

                log.Conn.InitialCatalog = Nodo.Text;
                String strSQLCommandtable = "CREATE TABLE ";
                String n = "[dbo].[",name=n;
                foreach (String item in TablasBD1)
                {
                    name += item + "]";
                    strSQLCommandtable +=  name + "(" ;
                }

             /*   String strSQLCommandtable = "CREATE TABLE" + str + name + str2;
                connection.Open();
                SqlCommand command = new SqlCommand(strSQLCommand, connection);
                command.ExecuteNonQuery();
                connection.Close();*/


            }
        }
    }
}
