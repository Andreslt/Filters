using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace P1_ExploradorWindows
{
        public partial class Form1 : Form
    {               
        public Form1()
        {            
            InitializeComponent();
            ArbolInicial();
            customizebottoms();
        }

        public void ArbolInicial() {            
            directorios(@"" + txt_BarDir.Text, 1,null);
            btn_adelante.Enabled = false;
            btn_atras.Enabled = false;
            btn_subir.Enabled = false;
            Vectores.Estados[0] = "C:\\";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode Nodo = e.Node;            
            if(Nodo.ImageIndex != 0)
            {
                directorios(Nodo.Tag.ToString(), 2, Nodo);
                Nodo.ImageIndex = 0;
            }
            btn_adelante.Enabled = true;
            btn_atras.Enabled = true;
            btn_subir.Enabled = true;
            Estados(Nodo.Tag.ToString());
            //txt_BarDir.Text = Nodo.Tag.ToString();                                      //1            
            MostrarListview(Nodo.Tag.ToString());
        }
        
        public void directorios(string ruta, int opcion, TreeNode Nodo)
        {
            DirectoryInfo dir = new DirectoryInfo(ruta);
                if (dir.Exists)
                {                                    
                    TreeNode node, node2;
                  if (opcion == 1)
                  {                      
                        try
                        {
                            MostrarListview(ruta);
                            Vectores.folders = dir.GetDirectories();
                            if (Vectores.folders.Length > 0)
                            {
                                foreach (DirectoryInfo directorio in Vectores.folders)
                                {
                                        node = treeView1.Nodes.Add(directorio.Name);
                                        node.ImageIndex = 0;
                                        node.Tag = directorio.FullName;
                                    try
                                    {
                                        Vectores.subfolders = directorio.GetDirectories();

                                        foreach (DirectoryInfo directory in Vectores.subfolders)
                                        {
                                            if (directory.Exists)
                                            {                                                
                                                node2 = treeView1.Nodes[node.Index].Nodes.Add(directory.Name);
                                                node2.ImageIndex = 1;
                                                node2.Tag = directory.FullName;
                                            }
                                        }
                                    }
                                    catch{}
                                }
                            }
                        }
                        catch{}
                    }
                  else
                  {   
                      if(opcion==2)
                      {
                          //Opcion2                      
                          try
                          {
                              Vectores.folders = dir.GetDirectories();
                              if (Vectores.folders.Length > 0)
                              {
                                  foreach (DirectoryInfo directorio in Vectores.folders)
                                  {
                                      if (directorio.Exists)
                                      {
                                          Nodo.Nodes.Add(directorio.Name);
                                          Nodo.LastNode.Tag = directorio.FullName;
                                          Nodo.ImageIndex = 1;
                                      }
                                  }
                              }
                          }
                          catch { }
                      }
                      else
                      {
                          MostrarListview(txt_BarDir.Text);
                      }
                  }
            }else
                {
                    MessageBox.Show("La ruta " + ruta + " especificada no existe. Por favor verificarla nuevamente");
                }
        }


        private void btn_Act_Click(object sender, EventArgs e)
        {            
            btn_subir.Enabled = true;                                                  //2*
            Estados(txt_BarDir.Text);
            directorios(txt_BarDir.Text, 3, null);
        }

            public void MostrarListview(String rute)
        {
            listView1.Items.Clear();
            lbl_vacia.Visible = false;
            lbl_carpetas.Visible = true;
            pictureBox1.Visible = true;
            lbl_archivos.Visible = true;
            pictureBox2.Visible=true;
            panel_prop.Visible = false;
            panel_nombrenew.Visible = false;
            lbl_newarch.Visible = false;
            DirectoryInfo ruta = new DirectoryInfo(rute);            
            bool sw1=true,sw2=true;
                try
                {
                    DirectoryInfo[] carpetas = ruta.GetDirectories();
                    ncarpetas = carpetas.Length;
                    sw1 = ncarpetas == 0;
                    foreach(DirectoryInfo directory in carpetas)
                    {
                        ListViewItem lista=new ListViewItem();
                        lista.Text = directory.Name;
                        lista.SubItems.Add(directory.LastWriteTime.ToString()); //Fecha de Modificación
                        lista.SubItems.Add("Carpeta de Archivos"); //Tipo
                        lista.SubItems.Add(""); //Tamaño
                        lista.Tag = directory.FullName;
                        lista.ImageIndex = 0;
                        listView1.Items.Add(lista);
                    }
                        FileInfo[] archivos = ruta.GetFiles();
                        narchivos = archivos.Length;
                        sw2 = narchivos == 0;
                        foreach (FileInfo file in archivos)
                        {
                            ListViewItem lista = new ListViewItem();
                            lista.Text = file.Name;
                            lista.Tag = file.FullName;
                            lista.SubItems.Add(file.LastWriteTime.ToString());//Fecha de Modificación
                            TipodArchivo(file.Extension);
                            lista.SubItems.Add(tipo); //Tipo
                            lista.SubItems.Add(file.Length.ToString()+" Bytes"); //Tamaño
                            lista.ImageIndex = Vista;
                            listView1.Items.Add(lista);
                        }
                        listView1.ForeColor = Color.Black;
                        lbl_archivos.Text = narchivos.ToString() + " Archivos";
                        lbl_carpetas.Text = ncarpetas.ToString() + " Carpetas";
                    if(sw1&&sw2)
                    {
                        lbl_vacia.Visible = true;
                        lbl_carpetas.Visible = false;
                        pictureBox1.Visible = false;
                        lbl_archivos.Visible = false;
                        pictureBox2.Visible = false;
                    }
                }                    
                catch { }
        }

            public void TipodArchivo(String archive)
            {
                bool sw=false;
                tipo = "";
                String[] tipos = { "Texto", "Word", "Word", "Power Point", "Power Point", "Winzip", "Pdf", "Excel", "Excel", "Jpg", "Gif", "Png", "Winrar", "Unkown" };
                String[] extensiones = { ".txt", ".doc", ".docx", ".ppt", ".pptx", ".zip", ".pdf", ".xls", ".xlsx", ".jpg", ".gif", ".png", ".rar" };

                for (int i = 0; i<extensiones.Length;i++)
                {
                    if (archive.Equals(extensiones[i])&&archive!="")
                    {
                        tipo= "Archivo de "+tipos[i];
                            Vista = i + 3;
                        sw = true;
                        break;
                    }
                }
                if(tipo==""&&sw==false)
                {
                    tipo = tipos[13];
                    Vista = 16;
                }                
            }

            private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
            {
                listView1.SmallImageList = imageList_16x16;
                listView1.View = View.Details;                
            }

            private void pequeñosToolStripMenuItem_Click(object sender, EventArgs e)
            {
                listView1.SmallImageList = imageList_32x32;
                listView1.View = View.SmallIcon;
            }

            private void medianosToolStripMenuItem_Click(object sender, EventArgs e)
            {
                listView1.LargeImageList = imageList_64x64;
                listView1.View = View.Tile;
            }

            private void grandesToolStripMenuItem_Click(object sender, EventArgs e)
            {
                listView1.SmallImageList = imageList_128x128;
                listView1.View = View.SmallIcon;
            }

            private void btn_atras_Click(object sender, EventArgs e)
            {                
                atras++;
                bolAt = true;
                esAt = estado - atras - 1;                
                if (esAt >= 0)
                {
                    txt_BarDir.Text = Vectores.Estados[esAt];
                    MostrarListview(txt_BarDir.Text);
                    btn_adelante.Enabled = true;
                }
                else
                {
                    btn_atras.Enabled = false;
                }
            }

            private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
            {                
                ListViewItem seleccion = listView1.SelectedItems[0];
                Estados(seleccion.Tag.ToString());
                //txt_BarDir.Text = seleccion.Tag;                                    //3
                if(seleccion.ImageIndex==0)
                {
                    MostrarListview(txt_BarDir.Text);
                    btn_subir.Enabled = true;
                }
                else
                {
                    try
                    {
                        DirectoryInfo dir = new DirectoryInfo((string)seleccion.Tag);
                        System.Diagnostics.Process.Start(dir.FullName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }                
            }

            private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                int seleccionados=listView1.SelectedItems.Count;
                Vectores.archivos=new ListViewItem[seleccionados];
                copyOn = true;
                for(int i=0;i<seleccionados;i++)
                {
                    Vectores.archivos[i] = listView1.SelectedItems[i];
                }                              
            }

            private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if(copyOn|cutOn)
                {
                    String[] rutfil = new String[Vectores.archivos.Length];
                    int i = 0;
                    try
                    {
                        foreach (ListViewItem item in Vectores.archivos)
                        {
                            rutfil[i] = txt_BarDir.Text + "\\" + item.Text;
                            System.IO.File.Copy((string)item.Tag, rutfil[i]);
                            i++;
                        }
                        if (cutOn)
                        {
                            foreach (string archi in Vectores.rutInc)
                            {
                                System.IO.File.Delete(archi);
                            }

                            foreach (ListViewItem item in listView1.Items)
                            {
                                item.ForeColor = Color.Black;
                            }
                        }
                        copyOn = false;
                        cutOn = false;
                        MostrarListview(txt_BarDir.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No existen elementos para Copiar o Pegar");
                }                
            }

            private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                int seleccionados = listView1.SelectedItems.Count;
                Vectores.archivos = new ListViewItem[seleccionados];
                Vectores.rutInc = new string[seleccionados];
                for (int i = 0; i < seleccionados; i++)
                {
                    Vectores.archivos[i] = listView1.SelectedItems[i];
                    listView1.Items[listView1.SelectedItems[i].Index].ForeColor=Color.LightGray;
                    Vectores.rutInc[i] = (string)listView1.Items[listView1.SelectedItems[i].Index].Tag;
                    cutOn = true;
                }
            }

            private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                int seleccionados = listView1.SelectedItems.Count;
                 for (int i = 0; i < seleccionados; i++)
                 {
                     ListViewItem eliminados = listView1.Items[listView1.SelectedItems[i].Index];
                     System.IO.File.Delete((string)eliminados.Tag);
                 }
                MostrarListview(txt_BarDir.Text);
            }

            private void customizebottoms()
            {
                btn_atras.TabStop = false;
                btn_atras.FlatStyle = FlatStyle.Flat;
                btn_atras.FlatAppearance.BorderSize = 0;
                btn_atras.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Transparent

                btn_adelante.TabStop = false;
                btn_adelante.FlatStyle = FlatStyle.Flat;
                btn_adelante.FlatAppearance.BorderSize = 0;
                btn_adelante.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Transparent

                btn_subir.TabStop = false;
                btn_subir.FlatStyle = FlatStyle.Flat;
                btn_subir.FlatAppearance.BorderSize = 0;
                btn_subir.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Transparent

                btn_Act.TabStop = false;
                btn_Act.FlatStyle = FlatStyle.Flat;
                btn_Act.FlatAppearance.BorderSize = 0;
                btn_Act.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Transparent

                btn_Search.TabStop = false;
                btn_Search.FlatStyle = FlatStyle.Flat;
                btn_Search.FlatAppearance.BorderSize = 0;
                btn_Search.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Transparent
                
                newElement.TabStop = false;
                newElement.FlatStyle = FlatStyle.Flat;
                newElement.FlatAppearance.BorderSize = 0;
                newElement.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Transparent
            }

            private void listView1_MouseClick(object sender, MouseEventArgs e)
            {
                MouseButtons boton= e.Button;
                if(boton.ToString().Equals("Right"))
                {
                    panel_Ops.Visible = true;
                    panel_Ops.Location=new Point(e.X,e.Y);
                }else
                {
                    panel_Ops.Visible = false;
                }
            }

            private void propiedades()
            {
                ListViewItem item = listView1.SelectedItems[0];
                if(item.ImageIndex!=0)
                {
                    FileInfo dir = new FileInfo(item.Tag.ToString());                    
                    prop_nombre.Text = dir.Name;
                    prop_tam.Text = dir.Length.ToString();
                    prop_tipo.Text = dir.Extension;
                    prop_fcrea.Text = dir.CreationTime.ToString();
                    prop_fmodif.Text = dir.LastWriteTime.ToString();
                    prop_ubicacion.Text = dir.FullName;
                    panel_prop.Visible = true;
                }
            }

            private void cerrar_panelprop_Click(object sender, EventArgs e)
            {
                panel_prop.Visible = false;
            }

            private void treeView1_MouseClick(object sender, MouseEventArgs e)
            {

            }

            private void btn_Search_Click(object sender, EventArgs e)
            {
                string elemento=txt_Buscar.Text.ToUpper();
                int item=0, founds=0;
                Vectores.BuscarItems=new ListViewItem [listView1.Items.Count];
                for (int i = 0; i < listView1.Items.Count;i++)
                {
                    ListViewItem list = listView1.Items[i];
                    int extension = list.Text.IndexOf(".");
                    if (list.ImageIndex != 0&& extension!=-1)
                    { list.Name = list.Text.Substring(0, extension); }
                    if (list.Name.ToUpper().Contains(elemento))
                    {
                        founds++;
                        encontrado = true;
                        Vectores.BuscarItems[item] = listView1.Items[i];
                    }
                }
                if(encontrado)
                    {
                        listView1.Items.Clear();
                        for (int i=0;i<founds;i++)
                        {
                            listView1.Items.Add(Vectores.BuscarItems[i]);
                        }
                        
                    }else{
                        elemento = "'" + elemento + "'";
                        MessageBox.Show("No se encontraron elementos que contengan " + elemento + " en la búsqueda");
                }
            }

            private void label9_MouseClick(object sender, MouseEventArgs e)
            {
                panel_Ops.Visible = false;
            }

            private void label14_MouseClick(object sender, MouseEventArgs e)
            {
                panel_Ops.Visible = false;
                panel_prop.Location = new Point(e.X, e.Y);
                propiedades();
            }

            private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (encontrado)
                {
                    encontrado = false;
                    MostrarListview(txt_BarDir.Text);
                }                    
            }

            private void lbl_Cut_MouseClick(object sender, MouseEventArgs e)
            {
                cortarToolStripMenuItem_Click(sender, e);
                panel_Ops.Visible = false;
            }

            private void lbl_Copy_Click(object sender, EventArgs e)
            {
                copiarToolStripMenuItem_Click(sender, e);
                panel_Ops.Visible = false;
            }

            private void lbl_Paste_MouseClick(object sender, MouseEventArgs e)
            {
                pegarToolStripMenuItem_Click(sender, e);
                panel_Ops.Visible = false;
            }

            private void lbl_Delete_MouseClick(object sender, MouseEventArgs e)
            {
                eliminarToolStripMenuItem_Click(sender, e);
                panel_Ops.Visible=false;
            }

            private void lbl_Cut_Click(object sender, EventArgs e)
            {
                cortarToolStripMenuItem_Click(sender, e);
            }

            private void btn_subir_Click(object sender, EventArgs e)
            {
                string textbar = txt_BarDir.Text;
                char []separador = new char [] {'\\'};
                string[] puntos = textbar.Split(separador);
                textbar = "C:";
                for(int p=1;p<puntos.Length-1;p++)
                {
                    textbar =  textbar+"\\" + puntos[p];
                }
                if(puntos.Length-1==1)
                {
                    textbar = "C:\\";
                    btn_subir.Enabled = false;
                }
                Estados(textbar);                                             //4
                MostrarListview(txt_BarDir.Text);
                btn_atras.Enabled = true;
                btn_adelante.Enabled = true;
                bolAt = false;
            }

            private void Estados(String ruta)
            {
                try
                {
                    btn_atras.Enabled = true;
                    Vectores.Estados[estado] = ruta;
                    txt_BarDir.Text = ruta;
                    estado++;
                }
                catch
                {
                    MessageBox.Show("Ya esta bueno. Cierra!");
                }                               
            }

            private void btn_adelante_Click(object sender, EventArgs e)
            {
                int esAd;
                adelante++;
                if (bolAt&&adelante<estado)
                {
                    esAd = esAt; //type=true : Boton Atras
                    txt_BarDir.Text = Vectores.Estados[esAd + adelante];
                    btn_atras.Enabled = true;
                    if (txt_BarDir.Text!="")
                    MostrarListview(txt_BarDir.Text);
                } 
                else
                    btn_adelante.Enabled = false;                
            }

            private void newElement_Click(object sender, EventArgs e)
            {
                panel_nombrenew.Visible = true;
                lbl_newarch.Visible = true;
            }

            private void txt_nombreNew_KeyPress(object sender, KeyPressEventArgs e)
            {
                txt_nombreNew.ForeColor = Color.MidnightBlue;
                mousecl = false;
                char tecla = e.KeyChar;
                string key = tecla.ToString();
                if (key.Equals("\r"))
                    NewElement();
            }

            private void NewElement()
            {
                bool sw = false;
                string nombreArch = txt_nombreNew.Text;
                string extension = "";

                if (comboBox1.SelectedIndex == 0)
                {
                    extension = "";
                }
                else
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        extension = ".docx";
                    }
                    else
                    {
                        if (comboBox1.SelectedIndex == 2)
                        {
                            extension = ".xlsx";
                        }
                        else
                        {
                            if (comboBox1.SelectedIndex == 3)
                            {
                                extension = ".pptx";
                            }
                            else
                            {
                                if (comboBox1.SelectedIndex == 4)
                                {
                                    extension = ".txt";
                                }
                                else
                                {
                                    MessageBox.Show("Debe escoger un elemento de la lista");
                                }
                            }
                        }
                    }
                }
                string ruta;
                string rutant = txt_BarDir.Text;
                if(txt_BarDir.Text.Equals("C:\\"))
                    ruta=txt_BarDir.Text + nombreArch + extension;
                else
                ruta = txt_BarDir.Text + "\\" + nombreArch + extension;

                if (File.Exists(ruta))
                {
                    MessageBox.Show("Ya existe un archivo con ese nombre en esa ubicación");
                }
                else
                {
                    sw = true;
                }

                if (sw)
                {
                    try
                    {
                        using (FileStream fs = File.Create(ruta))
                        {
                            Byte[] info = new UTF8Encoding(true).GetBytes("");
                            // Add some information to the file.
                            fs.Write(info, 0, info.Length);
                        }
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show(ex.Message);
                    }                    
                }
                MostrarListview(rutant);
            }

            private void txt_nombreNew_MouseClick(object sender, MouseEventArgs e)
            {
                if(mousecl)
                txt_nombreNew.Text = "";
            }
     }

        public static class Vectores
        {
            public static DirectoryInfo[] folders { get; set; }
            public static DirectoryInfo[] subfolders { get; set; }

            public static String[] Estados=new string[100]; 

            public static ListViewItem [] archivos { get; set; }

            public static String[] rutInc { get; set; }

            public static ListViewItem[] BuscarItems { get; set; }
        }
}
