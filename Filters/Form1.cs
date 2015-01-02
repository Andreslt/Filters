using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
//using Excel = Microsoft.Office.Interop.Excel;


namespace Filters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        int [] Download, FF;
        Dictionary<string, List<string>> SolsDict, NSNDict;
        Dictionary<string, int> Filtered;
        String route, intxt, astxt, folder, file, dPath;        
        List<String> founds;
        List<String> Cwords = new List<string>();
        List<String> selectedFiles;
        DataTable dt = new DataTable("Statistics");
        String MomPath = @"C:\Users\Altum Aerospace\Documents\Andrés Lastra\Altum\Filtros\App\Solicitations _ Test";
        bool badwords;
        //Excel.Application xlApp = new Excel.Application();
        private void button1_Click(object sender, EventArgs e)
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\Altum Aerospace\Documents\Andrés Lastra\Altum\Filtros\App\Critical words.txt"));
            Cwords.Clear();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Cwords.Add(line);
            }            
            SearchInFolder();
            textBox1.Text = route;
            if (!textBox1.Text.Equals(""))
            {
                //ENABLING COMPONENTS
                rB1.Enabled = true;
                rB1.Checked = true;
                rB2.Enabled = true;                
                btn_Continue.Enabled = true;
            }

        }

        public List<String> ReadPdfFile(string fileName, List<String> cw)
        {
            founds = new List<String>();
            String foundsText="";
            if (File.Exists(fileName))
            {
                PdfReader pdfReader = new PdfReader(fileName);                
                bool sw = false;
                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);
                    
                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));                                                            
                    for (int i = 0; i < cw.Count; i++)
                    {
                        if (currentText.Contains(cw[i]))
                        {
                            sw = true;
                            if (!founds.Contains(cw[i]))
                            founds.Add(cw[i]);
                        }
                    }
                }

                foreach (var fs in founds)
	            {
                    if (fs!=founds.Last())
		                foundsText=foundsText+fs+",";
                    else
                        foundsText=foundsText+fs+".";
	            }

                if (sw) //CRITICAL WORDS WERE FOUND.
                {
                    badwords = true;
                    MessageBox.Show("Se encontraron las siguientes palabras críticas: " + foundsText);
                }
                pdfReader.Close();
            }
            return founds;
        }

        public void SearchInFolder()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "PDF Files (.pdf)|*.pdf|All Files (*.*)|*.*";
            openFileDialog1.Multiselect = true;
            selectedFiles = new List<string>();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String filess in openFileDialog1.FileNames)
                {
                    int last = filess.LastIndexOf("\\") + 1;
                    selectedFiles.Add(filess.Substring(last));
                }

                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                           
                int index;
                route = openFileDialog1.FileName;
                file = openFileDialog1.SafeFileName; //FILENAME_ELEMENT SELECTED
                index = route.IndexOf(file);
                folder = route.Substring(0, index - 1); //FOLDERNAME_ELEMENT SELECTED                
                sr.Close();
            }            
        }

        public void continuebuttom(DateTime time)
        {            
            try
            {
                dt.Clear();
                folderbydate(time, MomPath);
                ResultsColumns(true);
                DirectoryInfo folders = new DirectoryInfo(folder);
                FileInfo[] files = folders.GetFiles();
                String[] workers = { "NORELLA", "SASHLEY", "STEPHANIA" };
                int wkr = 0;bool workFile=true;
                foreach (FileInfo fl in files)
                {
                    if(fl.Name.Contains(".pdf"))
                    {
                        if (rB2.Checked)
                        {
                            workFile = false;
                            if (selectedFiles.Contains(fl.Name))
                                workFile = true;
                        }

                        if (workFile)
                        {
                            if (wkr > 2) wkr = 0;
                            String rt = folder;
                            rt = rt + "\\" + fl.Name;
                            badwords = false;
                            ReadPdfFile(rt, Cwords);
                            if (!badwords)
                            {
                                File.Copy(fl.FullName, dPath + "\\" + workers[wkr] + "\\" + fl.Name);
                                File.Delete(fl.FullName);
                            }
                            Statistics(badwords, fl, workers[wkr]);
                            wkr++;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            //dataReference();
            DialogResult result = MessageBox.Show("La ruta de carpeta y la fecha de download son correctas?", "Confirmar Parámetros", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                DateTime time = dTimePick.Value;
                Dictionaries();
                continuebuttom(time);                
            }
            btn_Continue.Enabled = false;
            dgvResults.DataSource = new DataTable();
        }

        private void folderbydate(DateTime time, String MomPath)
        {
            int year, day;
            String month;

            String [] months = {"ENERO","FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"};
            year = time.Year;
            month = months[time.Month-1];
            day = time.Day;

            String yPath = MomPath + "\\" + year;
            String mPath = yPath + "\\" + month;
            dPath = mPath + "\\" + day;

            //DirectoryInfo yfolders = new DirectoryInfo(yPath);

            if (!Directory.Exists(yPath))
            {
                Directory.CreateDirectory(yPath);
            }

            if (!Directory.Exists(mPath))
            {
                Directory.CreateDirectory(mPath);
            }

            if (!Directory.Exists(dPath))
            {
                Directory.CreateDirectory(dPath);

                //      WORKERS
                Directory.CreateDirectory(dPath + "\\" + "NORELLA");
                Directory.CreateDirectory(dPath + "\\" + "SASHLEY");
                Directory.CreateDirectory(dPath + "\\" + "STEPHANIA");
            }
        }

       /* public void dataReference()
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open("C:\\Users\\Altum Aerospace\\Documents\\Andrés Lastra\\Altum\\Filtros\\App\\testFile.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0); ;
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1); ;
            Excel.Range range = xlWorkSheet.UsedRange;

            object str; double db; DateTime dt;
            for (int rCnt = 1; rCnt <= range.Rows.Count; rCnt++)
            {
                for (int cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
                {
                    //str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Text;
  
                    if (rCnt > 1 && cCnt == 2) //NSN
                    {
                        db = (double)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
                        str = db.ToString();
                    }
                    else
                    {
                        if (rCnt > 1 && cCnt == 5) // DUE
                        {
                            try
                            {
                                dt = (DateTime)(range.Cells[rCnt, cCnt] as Excel.Range).Value;
                                str = dt.ToShortDateString();
                            }
                            catch (Exception)
                            {
                                str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Text;
                            }
                        }
                        else
                        str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Text;                        
                    }
                    //MessageBox.Show(str.ToString());
                }
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }*/

        public void ResultsColumns(bool DayReport)
        {
            try
            {
                var reader = new StreamReader(File.OpenRead(@"C:\Users\Altum Aerospace\Documents\Andrés Lastra\Altum\Filtros\App\Result columns.txt"));
                int r = 0, d = 0; bool sw = false;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    if (DayReport)
                    {
                        if (line.Contains("Day Report"))
                        {
                            d = r;
                            sw = true;
                        }

                        if (r > d && sw)
                        {
                            dt.Columns.Add(line);
                        }
                    }
                    else
                    {
                        if (line.Contains("Day Report"))
                          { 
                            sw = true; 
                          }
                        if (r > 0 && !sw)
                        {
                            dt.Columns.Add(line);
                        }
                    }
                    r += 1;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Ha ocurrido un error al consultar los resultados del día \n" + E.Message);
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {                        
            if(dt.Rows.Count==0)
                MessageBox.Show("Para consultar los resultados debe ejecutar el programa en la pestaña Filtrar\nSeleccionar la ruta y presionar Continuar.");
            else
            {
                dgvResults.DataSource = dt;    
            }
                

            /*if (comboBox2.SelectedIndex == 0)
            {
                //DETAILED REPORT
                //ResultsColumns(false);
                //dgvResults.DataSource = dt;
            }
            else
            {*/
                //DAY REPORT                
                
            //}
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public void Statistics (bool badwords, FileInfo fl, String Worker)
        {          
            if (!badwords)
            {
                DateTime time = dTimePick.Value;
                DataRow row = dt.NewRow();
                row["Date"] = time.ToShortDateString();
                row["Group"] = fl.Name.Substring(0, 3);
                row["NSN"] = "XXXX";
                row["Solicitation"] = fl.Name.Substring(0,fl.Name.IndexOf("."));
                row["Worker"] = Worker;
                dt.Rows.Add(row);             
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == "tabResults")
            {
                this.MaximumSize = new System.Drawing.Size(600, 360);
                this.Size = new System.Drawing.Size(600, 360);
            }
            else
            {
                if (e.TabPage.Name == "tabFiltrar")
                {
                    this.MaximumSize = new System.Drawing.Size(600, 360);
                    this.Size = new System.Drawing.Size(600, 250);
                }
                    
            }
        }

        private void dgvResults_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvResults.RowCount != 0)
            {
                lblExportarExcel.Visible = true;
                btn_ExportarExcel.Visible = true;
            }                
            else
            {
                lblExportarExcel.Visible = false;
                btn_ExportarExcel.Visible = false;
            }            
        }

        private void btn_ExportarExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            Excel.ExcelUtlity Excelfile = new Excel.ExcelUtlity();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Excelfile.WriteDataTableToExcel(dt, "Report", saveFileDialog1.FileName, "Daily Report");
            }
        }

        public void Dictionaries()
        {
            Download = new int[5] { 0, 0, 0, 0, 0 };
            FF = new int[5] { 0, 0, 0, 0, 0 };
            SolsDict = new Dictionary<string, List<string>>();
            NSNDict = new Dictionary<string, List<string>>();
            Filtered = new Dictionary<string, int>();

            DirectoryInfo folders = new DirectoryInfo(folder);
            FileInfo[] files = folders.GetFiles();

            foreach (FileInfo fl in files)
            {
                if (fl.Name.Contains(".txt"))
                {
                    if (fl.Name.Contains("in"))
                        intxt = fl.FullName;
                    else
                        astxt = fl.FullName;
                }
            }

            var reader1 = new StreamReader(File.OpenRead(intxt)); // SOLICITATIONS
            var reader2 = new StreamReader(File.OpenRead(astxt)); // NSN

            string line;
            string[] strArray;
            List<String> tempList, tempList2;
            int [] Notcounts = new int[5] {0,0,0,0,0};
            while (!reader1.EndOfStream)
            {                
                tempList = new List<string>();
                line = reader1.ReadLine();
                strArray = line.Split(' ');
                int levelint=0;
                String Group="";
                
                    String Key = strArray[0].Substring(0, strArray[0].Length - 13); //SOLICITATION
                    if (Key.Equals("SPE4A515Q0618"))
                    {
                        int a;
                    }
                    String level = Key.Substring(3, 1);
                    if (level.Equals("4") || level.Equals("5") || level.Equals("7") || level.Equals("8") || level.Equals("F"))
                    {
                        if(!level.Equals("F"))
                        {
                            Group = "SPE "+level;
                            levelint = int.Parse(level);

                            if (levelint <= 5)
                            {
                                levelint = levelint - 4;
                                Download[levelint] += 1;
                            }
                            else
                            {
                                levelint = levelint - 5;
                                Download[levelint] += 1;
                            }

                        }else
                        {
                            Group = "SPE FA";
                            levelint = 4;
                            Download[levelint] += 1;
                        }

                            try
                            {
                                String NSN = strArray[0].Substring(13, 13);
                                String DueDate="", Requisition="", Unit="", Qty="", Description="";
                                int j = 1, j2 = 1;
                                while(j2!=3)
                                {                                    
                                    if(!strArray[j].Equals(""))
                                    {
                                        if (j2==1)
                                        {
                                            DueDate = strArray[j].Substring(10, 8);
                                            Requisition = strArray[j].Substring(0, 10);
                                        }
                                        else
                                        {
                                            Unit = strArray[j].Substring(7, 2);
                                            Qty = strArray[j].Substring(0, 7);
                                            Description = strArray[j].Substring(9);                                            
                                        }
                                        j2 += 1;
                                    }
                                    j += 1;                                    
                                }
                                

                                for (int i = j; i <= strArray.Length - 3; i++)
                                {
                                    if (!strArray[i].Equals(""))
                                    {
                                        Description = Description + " " + strArray[i]; 
                                    }
                                    else
                                    {
                                        break;
                                    }                                    
                                }

                                DateTime realDue,now;
                                now = Convert.ToDateTime("22/12/2014");
                                //now = DateTime.Now.Date; //dd-MM-yy MODIFICAR A ESTE VALOR POSTERIORMENTE!!!
                                String[] datefix = DueDate.Split('/');//MM-dd-yy
                                int day = int.Parse(datefix[1]);
                                int month = int.Parse(datefix[0]);
                                int year = int.Parse("20"+datefix[2]);
                                realDue = new DateTime(year, month, day);
                                bool sw = false;
                                String errorfound="";

                                if (!Description.Contains("FOAM SEGMENT"))
                                {
                                    if (!Description.Contains("FILLER, VOID"))
                                    {
                                        if (!Description.Contains("INSTRUMENTATION HARDWARE"))
                                        {
                                            if (!Description.Contains("COMMERCIAL HARDWARE"))
                                            {
                                                if (!Description.Contains("EMERGENCY BUY"))
                                                {
                                                    if (now < realDue)
                                                    {
                                                        if (!Key.Substring(8, 1).Equals("X"))
                                                        {
                                                            if (Unit.Equals("EA") || (Unit.Equals("HD") && int.Parse(Qty) < 100))
                                                            {
                                                                if (Group.Equals("SPE FA"))
                                                                {
                                                                    double a = double.Parse(NSN);
                                                                }
                                                                sw = true;
                                                                 if (Group.Equals("SPE 7"))
                                                                 {
                                                                    if (NSN.Substring(0,2).Equals("59"))
                                                                    {
                                                                        sw = false;
                                                                    }                                        
                                                                 }

                                                                if (sw)
                                                                {
                                                                    FF[levelint] += 1;
                                                                    tempList.Add(Group); //GROUP
                                                                    tempList.Add(DueDate);  //DUE DATE
                                                                    tempList.Add(Requisition); //REQUISITION
                                                                    tempList.Add(NSN); //NSN
                                                                    tempList.Add(Description); //DESCRIPTION
                                                                    tempList.Add(Unit); //UNIT
                                                                    tempList.Add(Qty); //QUANTITY

                                                                    if (!SolsDict.ContainsKey(Key))
                                                                    {
                                                                        SolsDict.Add(Key, tempList);
                                                                    }
                                                                    else
                                                                    {
                                                                        SolsDict[Key].Add(Requisition);
                                                                        SolsDict[Key].Add(NSN);
                                                                        SolsDict[Key].Add(Unit);
                                                                        SolsDict[Key].Add(Qty);
                                                                    }

                                                                    tempList2 = new List<string>();
                                                                    tempList2.Add(Key);
                                                                    if (!NSNDict.ContainsKey(NSN))
                                                                    {
                                                                        NSNDict.Add(NSN, tempList2);
                                                                    }
                                                                    else
                                                                    {
                                                                        NSNDict[NSN].Add(Key);
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                errorfound = "UNITS";
                                                            }
                                                        }
                                                        else
                                                        {
                                                            errorfound = "X's";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        errorfound = "DUE";
                                                    }
                                                }
                                                else
                                                {
                                                    errorfound = "EMERGENCY BUY";
                                                }
                                            }
                                            else
                                            {
                                                errorfound = "COMMERCIAL HARDWARE";
                                            }
                                        }
                                        else
                                        {
                                            errorfound = "INSTRUMENTATION HARDWARE";  
                                        }
                                    }
                                    else
                                    {
                                        errorfound = "FILLER, VOID";
                                    }                                                                                                          
                                }
                                else
                                {
                                    errorfound = "FOAM SEGMENT";
                                }

                                if (!sw && !errorfound.Equals(""))
                                {
                                    if (!Filtered.ContainsKey(errorfound))
                                    {
                                        Filtered.Add(errorfound, 1);
                                    }
                                    else
                                    {
                                        Filtered[errorfound] += 1;
                                    }
                                }
                                
                        }
                           catch (Exception e)
                            {
                                int index = line.IndexOf("/");
                               Notcounts[levelint] += 1;
                            }
                            
                    }                    
              }

            MessageBox.Show("No contados: " + "G4: " + Notcounts[0] + "," + "G5: " + Notcounts[1] + "," + "G7: " + Notcounts[2] + "," + "G8: " + Notcounts[3] + "," + "FA: " + Notcounts[4]);
            while (!reader2.EndOfStream)
            {
                tempList = new List<string>();
                line = reader2.ReadLine();
                strArray = line.Split(',');


            }
        }

        public void listemps()
        {

        }
    }
}
