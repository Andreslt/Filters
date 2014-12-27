using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Server
{
    public partial class NewDBs : Form
    {
        SQLSERVER form;
        public NewDBs(SQLSERVER formulario)
        {
            InitializeComponent();
            form = formulario;
        }

        private void btn_Create2_Click(object sender, EventArgs e)
        {
            String dbname = txt_dbname.Text;
            int ntablas, nvistas;
            try
            {
                ntablas = int.Parse(txt_ntablas.Text); nvistas = int.Parse(txt_nvistas.Text);
                if(ntablas>=nvistas)
                {
                    form.Creates(3, dbname, "","");
                    if (ntablas > 0)
                    {
                        List<String> Tables = new List<String>();
                        for (int i = 0; i < ntablas; i++)
                        {
                            String table = "Table" + i;
                            form.Creates(1, table, "",dbname);
                            Tables.Add(table);
                        }

                        if (nvistas > 0)

                        {
                            for (int i = 0; i < nvistas; i++)
                             {
                                    form.Creates(2, "View" + i, Tables[i],dbname);
                             }
                        }
                    }
                }
                else {MessageBox.Show("El número de Vistas debe ser menor o igual que el de Tablas."); }
                
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("El número de tablas y de vistas debe ser un valor entero.\nSi no desear crear tablas ni vistas por defecto, indicar 0 en cada campo.");
            }            
        }

        private void btn_Cancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
