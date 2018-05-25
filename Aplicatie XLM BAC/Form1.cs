using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Aplicatie_XML_BAC
{
    /// <summary>
    /// Clasa ferestrei principale
    /// </summary>
    public partial class Form1 : Form
    {

        /// <summary>
        /// Creează o nouă instanță a clasei Log.
        /// Folosită pentru înregistrarea acțiunilor aplicației.
        /// </summary>
        public Log log = new Log();

        /// <summary>
        /// Fereastra principală.
        /// Conține metodele pentru executarea comenzilor date.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            About("Numele produsului: " + Application.ProductName, "Versiunea: " + Application.ProductVersion);
            log.Message("\n");
            log.Message("Aplicatia a fost deschisa");
            log.Message("Versiunea aplicatiei:");
            log.Message("-------------------");
            log.Message("------" + Application.ProductVersion + "------");
            log.Message("-------------------");
            i.Text = Convert.ToString(index);
            table.Columns.Add("nume", typeof(string));
            table.Columns.Add("clasa", typeof(string));
            table.Columns.Add("specializare", typeof(string));
            table.Columns.Add("sectia", typeof(string));
            table.Columns.Add("program_studiu", typeof(string));
            table.Columns.Add("a_exam", typeof(string));
            table.Columns.Add("a_nota", typeof(string));
            table.Columns.Add("b_exam", typeof(string));
            table.Columns.Add("b_nota", typeof(string));
            table.Columns.Add("c_exam", typeof(string));
            table.Columns.Add("c_nota", typeof(string));
            table.Columns.Add("d_exam", typeof(string));
            table.Columns.Add("d_nota", typeof(string));
            table.Columns.Add("e_exam", typeof(string));
            table.Columns.Add("e_nota", typeof(string));
            table.Columns.Add("f_exam", typeof(string));
            table.Columns.Add("f_nota", typeof(string));
            table.Columns.Add("g_exam", typeof(string));
            table.Columns.Add("g_nota", typeof(string));
            table.Columns.Add("h_exam", typeof(string));
            table.Columns.Add("h_nota", typeof(string));

        }

        

        /// <summary>
        /// Creează o nouă instanță pentru setul de date folosit.
        /// </summary>
        /// <remarks>
        /// Adaugă anul curent în denumirea nodului rădăcină al fișierului folosit.
        /// </remarks>
        public static DataSet dataSet = new DataSet("bac" + DateTime.Now.Year);
        DataTable table = dataSet.Tables.Add("elev");
        /// <summary>
        /// Indexul elevului.
        /// </summary>
        public int index = 1;
        //public int lines;
        /// <summary>
        /// Numele (sau locația) fișierului de intrare (sau ieșire) folosit.
        /// </summary>
        public string filename;
        /// <summary>
        /// Numele fișierului de dinaintea creării unuia de rezervă.
        /// </summary>
        public string fn;
        /// <summary>
        /// Numărul elevilor din baza de date.
        /// </summary>
        public int numar_elevi;
        /// <summary>
        /// Operator de tip bool folosit pentru a reține dacă a fost deschis un fișier.
        /// </summary>
        public bool open = false;
        /// <summary>
        /// Operator de tip bool folosit pentru a reține dacă a fost salvat fișierul.
        /// </summary>
        public bool save = false;
        /// <summary>
        /// Lista tuturor elevilor din baza de date folosită.
        /// </summary>
        public List<Elev> elevi = new List<Elev>();
        /// <summary>
        /// Indexul fișierului de rezervă folosit.
        /// </summary>
        public int backupfilename = 1;


        //public XmlWriter writer = XmlWriter.Create("2nd=bac2016.xml");
        
        /// <summary>
        /// Creează și actualizează fișierul 'About.txt' cu informații despre aplicație.
        /// </summary>
        /// <param name="name">Șir de caractere ce reprezintă numele produsului.</param>
        /// <param name="ver">Șir de caractere ce reprezintă versiunea aplicației.</param>
        public void About(string name, string ver)
        {
            StreamWriter sw = File.CreateText("About.txt");
            try
            {
                string first = string.Format(name);
                string second = string.Format(ver);
                sw.WriteLine(first);
                sw.WriteLine(second);
            }
            finally
            {
                sw.Close();
            }
        }

        /*
        public void save_Click(object sender, EventArgs e)
        {
            //if (finish.Text != "Overwrite")
            //{

            //Form2 add = new Form2();
            //if (open == false)
            //{
            //add.ShowDialog();
            //filename = add.GetData();
            //SaveDialog();
            //Export_HTML(filename);
            //log.Message("Tabelul a fost exportat automat ca fisier HTML");
            //}
            save = true;
            if (open == false)
            {
                if (filename == null)
                    SaveDialog();
                Export_HTML(filename);
                using (XmlWriter writer = XmlWriter.Create(filename + ".xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("bac" + DateTime.Now.Year);

                    foreach (Elev elev in elevi)
                    {
                        writer.WriteStartElement("elev");

                        writer.WriteElementString("nume", elev.Nume);
                        writer.WriteElementString("clasa", elev.Clasa);
                        writer.WriteElementString("specializare", elev.Specializare);
                        writer.WriteElementString("sectia", elev.Sectia);
                        writer.WriteElementString("program_studiu", elev.Program_studiu);
                        writer.WriteElementString("a_exam", elev.A_exam);
                        writer.WriteElementString("a_nota", elev.A_nota);
                        writer.WriteElementString("b_exam", elev.B_exam);
                        writer.WriteElementString("b_nota", elev.B_nota);
                        writer.WriteElementString("c_exam", elev.C_exam);
                        writer.WriteElementString("c_nota", elev.C_nota);
                        writer.WriteElementString("d_exam", elev.D_exam);
                        writer.WriteElementString("d_nota", elev.D_nota);
                        writer.WriteElementString("e_exam", elev.E_exam);
                        writer.WriteElementString("e_nota", elev.E_nota);
                        writer.WriteElementString("f_exam", elev.F_exam);
                        writer.WriteElementString("f_nota", elev.F_nota);
                        writer.WriteElementString("g_exam", elev.G_exam);
                        writer.WriteElementString("g_nota", elev.G_nota);
                        writer.WriteElementString("h_exam", elev.H_exam);
                        writer.WriteElementString("h_nota", elev.H_nota);

                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
            //}
            if (open == true)
            {
                //salveaza fisierul deja inceput
                table.Rows.Add(nume.Text, clasa.Text, specializare.Text, sectia.Text, program_studiu.Text, a_exam.Text, a_nota.Text, b_exam.Text, b_nota.Text, c_exam.Text, c_nota.Text, d_exam.Text, d_nota.Text, e_exam.Text, e_nota.Text, f_exam.Text, f_nota.Text, g_exam.Text, g_nota.Text, h_exam.Text, h_nota.Text);
                dataSet.WriteXml(filename);
                log.Message(filename + " --- a fost salvat");
                Export_HTML(filename);
            }
        }
        */

        private void I_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodă folosită la închiderea ferestrei.
        /// </summary>
        /// <param name="sender">Obiectul care a cauzat acțiunea.</param>
        /// <param name="e">Detalii referitoare la acțiune.</param>
        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MySettings s = MySettings.Load();
            if ((open == false || save == false) && s.Popup == true)
            {
                if (MessageBox.Show("Fișierul nu a fost salvat. Dacă ai creat un nou fișier, trebuie să îl salvezi pentru a nu pierde datele.\nDacă ai deschis un fișier, modificările au fost salvare automat. \nVerifică versiunea aplicației pentru mai multe detalii în leagătură cu alte erori sau excepții. \nApăsând 'OK' iei la cunoștință faptul că poți pierde date.",
                           "Closing",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        /*
        public void open_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml|Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            Form3 form3 = new Form3();
            numar_elevi = 0;
            string ultimulElev = "";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {

                open = true;
                filename = theDialog.FileName;
                fn = theDialog.SafeFileName;
                log.Message("Fisierul " + filename + " a fost deschis");
                if (fn[0] < 58 && fn[0] > 47)
                {
                    backupfilename = fn[0] - 48 + 1;
                }
                else
                    backupfilename = 1;
                string[] filelines = File.ReadAllLines(filename);
                //deschidem un form cu ultimul elev introdus 

                try
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml(filename);
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ultimulElev = dr["nume"].ToString().Trim();
                        numar_elevi++;
                    }
                    ds.Dispose();
                    i.Clear();

                }
                catch
                {
                    form3.nume.Text = "Eroare: ";
                    form3.textBoxNume.Text = "Fișierul selectat este gol";
                    form3.Text = "Eroare";
                    log.Message("Erori la citirea fisierului " + filename);
                    log.Message("Fisierul " + filename + " este gol");
                }


            }
            if (numar_elevi > 0)
            {
                index = numar_elevi + 1;
                i.Text = Convert.ToString(index);
                dataSet.ReadXml(filename);
                form3.Text = "Detalii: ultimul elev introdus";
                form3.textBoxNume.Text = "Ultimul elev introdus este: " + ultimulElev;
                form3.nume.Text = "Numarul " + index;
            }
            else
            {
                form3.nume.Text = "Eroare: ";
                form3.textBoxNume.Text = "Fișierul selectat este gol";
                form3.Text = "Eroare";
                log.Message("Erori la citirea fisierului");
                log.Message("Fisierul " + filename + " este gol");
            }
            form3.ShowDialog();
            finish.Text = "save";
        }
        */

        /// <summary>
        /// Casetă de selecție pentru programul de studiu.
        /// </summary>
        /// <param name="sender">Obiectul care a cauzat acțiunea.</param>
        /// <param name="e">Detalii referitoare la acțiune.</param>
        public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            a_exam.Text = "Limba şi literatura română (" + comboBox1.Text + ") - oral";
            e_exam.Text = "Limba şi literatura română (" + comboBox1.Text + ") - scris";
        }

        /*
        public void finish_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(5);
            if (progressBar1.Value > 40)
            {
                Cursor.Current = Cursors.WaitCursor;
                finish.Text = "Overwrite";
            }
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                save = true;
                if (open == false)
                {
                    Export_HTML(filename);
                    using (XmlWriter writer = XmlWriter.Create(filename + ".xml"))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("bac" + DateTime.Now.Year);

                        foreach (Elev elev in elevi)
                        {
                            writer.WriteStartElement("elev");

                            writer.WriteElementString("nume", elev.nume);
                            writer.WriteElementString("clasa", elev.clasa);
                            writer.WriteElementString("specializare", elev.specializare);
                            writer.WriteElementString("sectia", elev.sectia);
                            writer.WriteElementString("program_studiu", elev.program_studiu);
                            writer.WriteElementString("a_exam", elev.a_exam);
                            writer.WriteElementString("a_nota", elev.a_nota);
                            writer.WriteElementString("b_exam", elev.b_exam);
                            writer.WriteElementString("b_nota", elev.b_nota);
                            writer.WriteElementString("c_exam", elev.c_exam);
                            writer.WriteElementString("c_nota", elev.c_nota);
                            writer.WriteElementString("d_exam", elev.d_exam);
                            writer.WriteElementString("d_nota", elev.d_nota);
                            writer.WriteElementString("e_exam", elev.e_exam);
                            writer.WriteElementString("e_nota", elev.e_nota);
                            writer.WriteElementString("f_exam", elev.f_exam);
                            writer.WriteElementString("f_nota", elev.f_nota);
                            writer.WriteElementString("g_exam", elev.g_exam);
                            writer.WriteElementString("g_nota", elev.g_nota);
                            writer.WriteElementString("h_exam", elev.h_exam);
                            writer.WriteElementString("h_nota", elev.h_nota);

                            writer.WriteEndElement();
                        }

                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                    }
                    log.Message("Fisierul a fost superscris cu datele actualizate");
                }
                Cursor.Current = Cursors.Default;
            }
        }

        public void finish_MouseUp(object sender, MouseEventArgs e)
        {
            progressBar1.Value = 0;
        }

        */

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.Message("Aplicatia a fost inchisa");
            //Process.Start(@"About.txt");
        }

        private void I_DoubleClick(object sender, EventArgs e)
        {
            i.ReadOnly = false;
        }

        private void I_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filename != null)
            {
                int index = Convert.ToInt32(i.Text) - 1;
                if (e.KeyChar == (char)13)
                {
                    i.ReadOnly = true;
                    ImportData(index);
                    /*foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        nume.Text = dr["nume"].ToString().Trim();
                        clasa.Text = dr["clasa"].ToString();
                        specializare.Text = dr["specializare"].ToString();
                    }
                    */
                }
            }
        }


        /// <summary>
        /// Metodă ce deschide un dialog de salvare a fișierului.
        /// </summary>
        public void SaveDialog()
        {
            Stream fs;
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "XML files (*.xml)|*.xml",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if ((fs = saveFile.OpenFile()) != null)
                {
                    StreamReader reader = new StreamReader(fs);
                    filename = reader.ReadToEnd();
                    fs.Close();
                }
            }
        }

        /// <summary>
        /// Metodă prin care se completează câmpurile din prima fereastră a aplicației pe baza indexului dat.
        /// </summary>
        /// <param name="index">Număr natural ce reprezintă indexul elevului.</param>
        public void ImportData(int index)
        {
            index--;
            DataSet ds = new DataSet();
            ds.ReadXml(filename);
            try
            {
                nume.Text = ds.Tables[0].Rows[index][0].ToString();
                clasa.Text = ds.Tables[0].Rows[index][1].ToString();
                specializare.Text = ds.Tables[0].Rows[index][2].ToString();
                sectia.Text = ds.Tables[0].Rows[index][3].ToString();
                program_studiu.Text = ds.Tables[0].Rows[index][4].ToString();
                a_nota.Text = ds.Tables[0].Rows[index][6].ToString();
                b_exam.Text = ds.Tables[0].Rows[index][7].ToString();
                b_nota.Text = ds.Tables[0].Rows[index][8].ToString();
                c_exam.Text = ds.Tables[0].Rows[index][9].ToString();
                c_nota.Text = ds.Tables[0].Rows[index][10].ToString();
                d_nota.Text = ds.Tables[0].Rows[index][12].ToString();
                e_nota.Text = ds.Tables[0].Rows[index][14].ToString();
                f_exam.Text = ds.Tables[0].Rows[index][15].ToString();
                f_nota.Text = ds.Tables[0].Rows[index][16].ToString();
                g_exam.Text = ds.Tables[0].Rows[index][17].ToString();
                g_nota.Text = ds.Tables[0].Rows[index][18].ToString();
                h_exam.Text = ds.Tables[0].Rows[index][19].ToString();
                h_nota.Text = ds.Tables[0].Rows[index][20].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void HTML_EXPORT_Click(object sender, EventArgs e)
        {
            if (filename == null)
                SaveDialog();
            Export_HTML(filename);
            log.Message("Tabelul a fost exportat ca fisier HTML");
        }

        private void I_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (filename != null)
            {
                int index = Convert.ToInt32(i.Text);
                if (e.KeyCode == Keys.Right)
                {
                    if (index < numar_elevi)
                    {
                        index++;
                        ImportData(index);
                        i.Text = (index).ToString();
                    }

                }
                if (e.KeyCode == Keys.Left)
                {
                    if (index > 1)
                    {
                        --index;
                        ImportData(index);
                        i.Text = (index).ToString();
                    }

                }
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml|Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            MySettings x = MySettings.Load();
            Form3 form3 = new Form3();
            numar_elevi = 0;
            string ultimulElev = "";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {

                open = true;
                filename = theDialog.FileName;
                fn = theDialog.SafeFileName;
                log.Message("Fisierul " + filename + " a fost deschis");
                if (fn[0] < 58 && fn[0] > 47)
                {
                    backupfilename = fn[0] - 48 + 1;
                }
                else
                    backupfilename = 1;
                string[] filelines = File.ReadAllLines(filename);
                //deschidem un form cu ultimul elev introdus 

                try
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml(filename);
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ultimulElev = dr["nume"].ToString().Trim();
                        numar_elevi++;
                    }
                    //ds.Dispose();
                    i.Clear();

                }
                catch
                {
                    if (x.Popup == true)
                    {
                        form3.nume.Text = "Eroare: ";
                        form3.textBoxNume.Text = "Fișierul selectat este gol";
                        form3.Text = "Eroare"; 
                    }
                    log.Message("Erori la citirea fisierului " + filename);
                    log.Message("Fisierul " + filename + " este gol");
                }


            }
            if (numar_elevi > 0)
            {
                index = numar_elevi + 1;
                i.Text = Convert.ToString(index);
                dataSet.ReadXml(filename);
                form3.Text = "Detalii: ultimul elev introdus";
                form3.textBoxNume.Text = "Ultimul elev introdus este: " + ultimulElev;
                form3.nume.Text = "Numarul " + index;
            }
            else
            {
                form3.nume.Text = "Eroare: ";
                form3.textBoxNume.Text = "Fișierul selectat este gol";
                form3.Text = "Eroare";
                log.Message("Erori la citirea fisierului");
                log.Message("Fisierul " + filename + " este gol");
            }
            if(x.Popup == true)
                form3.ShowDialog();
            saveAsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = false;
            exportAsToolStripMenuItem.Enabled = true;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save = true;
            if (filename == null)
                SaveDialog();
            Export_HTML(filename);
            using (XmlWriter writer = XmlWriter.Create(filename + ".xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("bac" + DateTime.Now.Year);

                foreach (Elev elev in elevi)
                {
                    writer.WriteStartElement("elev");

                    writer.WriteElementString("nume", elev.Nume);
                    writer.WriteElementString("clasa", elev.Clasa);
                    writer.WriteElementString("specializare", elev.Specializare);
                    writer.WriteElementString("sectia", elev.Sectia);
                    writer.WriteElementString("program_studiu", elev.Program_studiu);
                    writer.WriteElementString("a_exam", elev.A_exam);
                    writer.WriteElementString("a_nota", elev.A_nota);
                    writer.WriteElementString("b_exam", elev.B_exam);
                    writer.WriteElementString("b_nota", elev.B_nota);
                    writer.WriteElementString("c_exam", elev.C_exam);
                    writer.WriteElementString("c_nota", elev.C_nota);
                    writer.WriteElementString("d_exam", elev.D_exam);
                    writer.WriteElementString("d_nota", elev.D_nota);
                    writer.WriteElementString("e_exam", elev.E_exam);
                    writer.WriteElementString("e_nota", elev.E_nota);
                    writer.WriteElementString("f_exam", elev.F_exam);
                    writer.WriteElementString("f_nota", elev.F_nota);
                    writer.WriteElementString("g_exam", elev.G_exam);
                    writer.WriteElementString("g_nota", elev.G_nota);
                    writer.WriteElementString("h_exam", elev.H_exam);
                    writer.WriteElementString("h_nota", elev.H_nota);

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            //}
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //salveaza fisierul deja inceput
            table.Rows.Add(nume.Text, clasa.Text, specializare.Text, sectia.Text, program_studiu.Text, a_exam.Text, a_nota.Text, b_exam.Text, b_nota.Text, c_exam.Text, c_nota.Text, d_exam.Text, d_nota.Text, e_exam.Text, e_nota.Text, f_exam.Text, f_nota.Text, g_exam.Text, g_nota.Text, h_exam.Text, h_nota.Text);
            dataSet.WriteXml(filename);
            log.Message(filename + " --- a fost salvat");
            Export_HTML(filename);
        }

        /// <summary>
        /// Valoare prin care se verifică dacă toate câmpurile au fost completate.
        /// </summary>
        public bool IfNotEmpty
        {
            get
            {
                foreach (Control x in Controls)
                {
                    if (x is TextBox)
                    {
                        if (((TextBox)x).Text == String.Empty)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
        

        /// <summary>
        /// Metodă care golește conținutul tuturor câmpurilor.
        /// </summary>
        public void EmptyTextBoxes()
        {
            foreach (Control x in Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
        }

        private void NewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySettings x = MySettings.Load();
            if (IfNotEmpty)
                AdaugareElev();
            else if(x.Popup == true)
            {
                Form3 f = new Form3
                {
                    Text = "Eroare"
                };
                f.nume.Text = "Eroare:";
                f.textBoxNume.Text = "Toate câmpurile trebuie completate înainte de a trece la următorul elev.";
                f.ShowDialog();
            }
        }

        private void AdaugareElev()
        {

            save = false;
            Elev elev = new Elev(nume.Text,
                                    clasa.Text,
                                    specializare.Text,
                                    sectia.Text,
                                    program_studiu.Text,
                                    a_exam.Text,
                                    a_nota.Text,
                                    b_exam.Text,
                                    b_nota.Text,
                                    c_exam.Text,
                                    c_nota.Text,
                                    d_exam.Text,
                                    d_nota.Text,
                                    e_exam.Text,
                                    e_nota.Text,
                                    f_exam.Text,
                                    f_nota.Text,
                                    g_exam.Text,
                                    g_nota.Text,
                                    h_exam.Text,
                                    h_nota.Text);
            index++;
            i.Text = Convert.ToString(index);
            elevi.Add(elev);
            log.Message(nume.Text + " a fost adaugat");
            EmptyTextBoxes();
            if (open == true)
            {
                //continua cu fisierul deja inceput
                if (save == true)
                {
                    //table.Rows.Add(elev);
                    table.Rows.Add(elev.Nume, elev.Clasa, elev.Specializare, elev.Sectia, elev.Program_studiu, elev.A_exam, elev.A_nota, elev.B_exam, elev.B_nota, elev.C_exam, elev.C_nota, elev.D_exam, elev.D_nota, elev.E_exam, elev.E_nota, elev.F_exam, elev.F_nota, elev.G_exam, elev.G_nota, elev.H_exam, elev.H_nota);
                }
                dataSet.WriteXml(Convert.ToString(backupfilename) + "_" + fn);
                log.Message(Convert.ToString(backupfilename) + "_" + fn + " --- a fost salvat");
                Export_HTML(Convert.ToString(backupfilename) + "_" + fn);
            }
        }

        private void HTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == null)
                SaveDialog();
            Export_HTML(filename);
            log.Message("Tabelul a fost exportat ca fisier HTML");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Settings();
            f.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
            {
                NewItemToolStripMenuItem_Click(sender, e);
            }
        }
        
    }
}
