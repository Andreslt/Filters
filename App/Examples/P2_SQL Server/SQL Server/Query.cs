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
    public partial class Query : Form
    {
        public SqlConnectionStringBuilder Conn = new SqlConnectionStringBuilder();
        public SqlConnection Connection= new SqlConnection();
        public Query(Login log, List<string> DBs)
        {
            InitializeComponent();
            Conn = log.Conn;
            DataBases = DBs;
            CargarBDs();            
        }      
        public List<string> TablasBD;
        public List<string> DataBases;
        private void RTxt_Query_KeyUp(object sender, KeyEventArgs e)
        {/*
            String[] keys = { "SELECT", "FROM", "WHERE" };            
            RTxt_Query.ForeColor = Color.Black;
            int [] pos=new int[3];
            for (int i = p; i <= 2; i++)
			{
			 int index = RTxt_Query.Text.ToUpper().IndexOf(keys[i]);
                  if (index != -1)
                   {
                      p++;
                      RTxt_Query.Select(index, index + keys[i].Length);
                      RTxt_Query.ForeColor = Color.Blue;
                      RTxt_Query.DeselectAll();
                      break;
                   } 
			}*/
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if(RTxt_Query.Text.ToUpper().Contains("SELECT"))
            {
                if (RTxt_Query.Text.ToUpper().Contains("FROM"))
                {
                    btn_Generate.Enabled = true;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Debe asignar la Sentencia 'FROM' para ejecutar la Query.");
                }                
            }else
                {
                    MessageBox.Show("Debe asignar la Sentencia 'SELECT' para ejecutar la Query.");
                }
        }

        private void btn_TbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarBDs()
        {
            int i=0;
            foreach (String item in DataBases)
	        {   if(i>3)             
                Cmbx_Databases.Items.Add(item);
            i++;
	        }            
        }

        private void Gettablas()
        {
            TablasBD = new List<string>();
            Conn.InitialCatalog = Cmbx_Databases.SelectedItem.ToString();
            using (Connection = new SqlConnection(Conn.ToString()))
            {
                Connection.Open();
                DataTable schema = Connection.GetSchema("Tables");
                foreach (DataRow row in schema.Rows)
                {
                    String tabla = row[2].ToString();
                    if (row.ItemArray[3].Equals("BASE TABLE"))
                        TablasBD.Add(tabla);
                }
                Connection.Close();
            }
        }

        private void Cmbx_Databases_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gettablas();
            cmb_Tables.Items.Clear();
            foreach (String item in TablasBD)
	        {
                cmb_Tables.Items.Add(item);
	        }
            btn_Generate.Enabled = true;
        }
    }
}
