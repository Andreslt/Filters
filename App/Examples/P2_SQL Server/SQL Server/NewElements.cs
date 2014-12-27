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

namespace SQL_Server
{
    public partial class NewElements : Form
    {
        public NewElements()
        {
            InitializeComponent();
            btn_Delete.Enabled = false;
        }        
        public List<int> TypeColumns=new List<int>();
        public bool Pk;
        public int NPk;
        public bool tab1 = true;
        public bool Properties=false;
        public String Database, Connect;
        public TreeNode Nodo;
        public SqlConnection connection;
        public List<string> TablasBD= new List<string>();
        private void btn_Cancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create2_Click(object sender, EventArgs e)
        {
            if (txt_Tablename.Text != "" && !txt_Tablename.Text.Contains(" "))
            {
                    this.DialogResult = DialogResult.OK;
            }            
            else
            {
                MessageBox.Show("El nombre de la tabla no puede contener espacio vacíos!");
            }
        }

        private void btn_Createview_Click(object sender, EventArgs e)
        {
            if (Cmbx_Tables.SelectedItem!= null && txt_ViewName.Text != "" && Cmbx_Columns.SelectedItem!=null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Los elementos deben tener un nombre y no pueden contener espacios.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Properties = true;
            Pk = false;
            String SPk="";           
            String NullValues = ", NOT NULL";
            btn_Delete.Enabled = true;
            String col = txt_ColName.Text;
            bool Colnamerepeat=false;     
            if(LBx_Columns.Items.Count>0)
            {
                foreach (String item in LBx_Columns.Items)
                {
                    String Value=item.ToString().Substring(0,item.IndexOf(","));
                    if (Value.Equals(col))
                    {
                        Colnamerepeat = true;
                        break;
                    }
                }
            }
            

            if(!Colnamerepeat)
            {
                if (!col.Equals("") && Cmbx_ColType.SelectedIndex >= 0)
                {
                    if (Chbx_PK.Checked)
                    {
                        Pk = true;
                        Chbx_PK.Enabled = false;
                        SPk = ", PK";
                        NPk = LBx_Columns.Items.Count;
                        Chbx_PK.Checked = false;
                    }

                    if(Chbx_NULL.Checked)
                    {
                        NullValues = ", NULL";
                    }
                    TypeColumns.Add(Cmbx_ColType.SelectedIndex);
                    LBx_Columns.Items.Add(txt_ColName.Text + ", (" + Cmbx_ColType.SelectedItem.ToString() + ")" + SPk + NullValues);
                    Chbx_NULL.Enabled = true;
                }
            }else
            {
                MessageBox.Show("No pueden haber columnas con el mismo nombre");
            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (LBx_Columns.SelectedIndices.Count>0)
            {
                if (LBx_Columns.SelectedItem.ToString().Contains("PK"))
                {
                    Chbx_PK.Enabled = true;
                }

                int item = LBx_Columns.SelectedIndex;
                LBx_Columns.Items.RemoveAt(item);
            }
            if(LBx_Columns.Items.Count==0)
            {
                btn_Delete.Enabled = false;
                Properties = false;
            }
        }

        private void Chbx_PK_CheckedChanged(object sender, EventArgs e)
        {
            if (Chbx_PK.Checked)
            {
                Chbx_NULL.Checked = false;
                Chbx_NULL.Enabled = false;
            }else
                Chbx_NULL.Enabled = true;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {   
            if(!tab1)
            {
                if (e.TabPage == tabPage1)
                    e.Cancel = true;
            }else
                if (e.TabPage == tabPage2)
                    e.Cancel = true;
        }

        private void Cmbx_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Cmbx_Columns.Items.Clear();
            String strSQLCommand = "USE " + Database + "; SELECT * FROM "+Cmbx_Tables.SelectedItem.ToString();
            SqlConnection connection = new SqlConnection(Connect);
            SqlCommand command = new SqlCommand(strSQLCommand, connection);
            connection.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter(command);
            sqlDA.Fill(dt);
            connection.Close();

            for (int i = -1; i < dt.Columns.Count; i++)
            {
                if(i==-1)
                {
                    Cmbx_Columns.Items.Add("*");
                }
                else
                {
                    Cmbx_Columns.Items.Add(dt.Columns[i].ColumnName);
                }                
            }
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            try
            {
                String strSQLCommand = "sp_rename " + Nodo.Text + ", " + txt_Tablename.Text;
                connection.Open();
                SqlCommand command = new SqlCommand(strSQLCommand, connection);
                command.ExecuteNonQuery();
                connection.Close();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("El nombre introducido no es válido.");
            }            
        }
    }
}
