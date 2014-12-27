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

namespace SQL_Server
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CargarServidores();           
        }

        public SqlConnectionStringBuilder Conn;
        public List<string> DataBases;
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Conn = new SqlConnectionStringBuilder();
            if (CmBx_Servidores.SelectedItem != null && CmB_Authentic.SelectedItem != null)
            {
                if (Servers.Length == 1)
                    Conn.DataSource = Environment.MachineName;
                else
                    Conn.DataSource = Servers[CmBx_Servidores.SelectedIndex];

                if (CmB_Authentic.SelectedIndex == 1)
                {                    
                    Conn.UserID = txt_Login.Text;
                    Conn.Password = txt_Password.Text;
                }else{Conn.IntegratedSecurity = true;}

                CargarBDs();
            }else
            {
                MessageBox.Show("Debe escoger un servidor y un esquema de autenticación");
            }
        }

        private void CargarServidores()
        {
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    int i = 0;
                    Servers = new String[instanceKey.ValueCount];
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        Servers[i] = Environment.MachineName + @"\" + instanceName;
                        CmBx_Servidores.Items.Add(Servers[i]);
                        Console.WriteLine(Servers[i]);
                        i++;
                    }
                }
            }
        }

        private void CmB_Authentic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmB_Authentic.SelectedIndex == 0)
            {
                label3.Enabled = label4.Enabled = txt_Login.Enabled = txt_Password.Enabled = false;
            }
            else
            {
                label3.Enabled = label4.Enabled = txt_Login.Enabled = txt_Password.Enabled = true;
            }
        }

        private void CargarBDs()
        {
            using (SqlConnection connection = new SqlConnection(Conn.ToString()))
            {
                try
                {
                    connection.Open();
                    DataTable schema_db = connection.GetSchema("Databases");
                    DataBases = new List<string>();
                    List<string> TablasBD = new List<string>();
                    foreach (DataRow row in schema_db.Rows)
                    {
                        DataBases.Add(row["database_name"].ToString());
                    }
                    connection.Close();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
