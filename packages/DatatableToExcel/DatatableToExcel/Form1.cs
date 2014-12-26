using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatatableToExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = GetTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.ExcelUtlity obj = new Excel.ExcelUtlity();
            obj.WriteDataTableToExcel(GetTable(), "Person Details", "D:\\testPersonExceldata.xlsx", "Details");

            MessageBox.Show("Excel created D:\testPersonExceldata.xlsx");
        }
        static DataTable GetTable()
        {
            //
            // Here we create a DataTable with four columns.
            //
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Sex", typeof(string));
            table.Columns.Add("CreatedDate", typeof(string));
            table.Columns.Add("City", typeof(string));

            //
            // Here we add five DataRows.
            //
            table.Rows.Add(25, "Devesh Omar", "M", DateTime.Now,"Noida");
            table.Rows.Add(50, "Nikhil Vats", "M", DateTime.Now,"Noida");
            table.Rows.Add(10, "Heena Sharma", "F", DateTime.Now,"Delhi");
            table.Rows.Add(21, "Nancy Sharma", "F", DateTime.Now, "Delhi");
            table.Rows.Add(100, "Avinash", "M", DateTime.Now, "Delhi");

            table.Rows.Add(25, "Devesh gupta", "M", DateTime.Now, "Delhi");
            table.Rows.Add(50, "Nikhil gupta", "M", DateTime.Now, "Noida");
            table.Rows.Add(10, "HS gupta", "F", DateTime.Now, "Delhi");
            table.Rows.Add(21, "VS gupta", "F", DateTime.Now, "Delhi");
            table.Rows.Add(100, "RJ gupta", "M", DateTime.Now, "Delhi");

            return table;
        }


    }
}
