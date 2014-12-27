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
    public partial class Merge : Form
    {
        public SqlConnectionStringBuilder Conn = new SqlConnectionStringBuilder();
        public SqlConnection Connection = new SqlConnection();
        public Merge(Login log, List<string> DBs)
        {
            InitializeComponent();
            Conn = log.Conn;
            DataBases = DBs;
            CargarBDs();
        }
        public List<string> TablasBD;
        public List<string> DataBases;
        public bool NewBD=false;
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if (Cmbx_Database1.SelectedItem != null && Cmbx_Database2.SelectedItem != null)
            {
                if (Chbx_NewTab.Checked)
                    NewBD = true;
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Deben Seleccionarse dos Bases de Datos");
        }

        private void CargarBDs()
        {
            int i = 0;
            foreach (String item in DataBases)
            {
                if (i > 3)
                {
                    Cmbx_Database1.Items.Add(item);
                    Cmbx_Database2.Items.Add(item);
                }                    
                i++;
            }
        }

        private void Chbx_NewTab_CheckStateChanged(object sender, EventArgs e)
        {
            if (Chbx_NewTab.Checked)
            {
                txt_NewDB.Visible = true;
                Destinity.Visible = false;
            }                
            else
            {
                txt_NewDB.Visible = false;
                Destinity.Visible = true;
            }
                
        }

        private void btn_TbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
