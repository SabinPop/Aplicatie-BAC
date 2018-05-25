using Aplicatie_XML_BAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Aplicatie_XML_BAC
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Metodă prin care se exportă baza de date în format HTML.
        /// </summary>
        /// <param name="filename">Numele fișierului (sau locația) în exportă datele.</param>
        public void Export_HTML(string filename)
        {
            if(filename != null)
            {
                string td = "td";
                using (XmlWriter writer = XmlWriter.Create(filename + ".html"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("bac" + DateTime.Now.Year);

                    writer.WriteStartElement("html");

                    writer.WriteStartElement("head");

                    writer.WriteStartElement("style");
                    writer.WriteString("table{" +
                        "font-family: arial, sans-serif;" +
                        "width:100%}" +
                        "\n" +
                        "td, th{" +
                        "border: 1px solid #dddddd;" +
                        "text-align: center;" +
                        "padding: 2px;}" +
                        "\n");
                    writer.WriteEndElement();

                    writer.WriteEndElement();

                    writer.WriteStartElement("body");
                    writer.WriteStartElement("table");


                    writer.WriteStartElement("tr");

                    writer.WriteElementString(td, "nume");
                    writer.WriteElementString(td, "clasa");
                    writer.WriteElementString(td, "specializare");
                    writer.WriteElementString(td, "sectia");
                    writer.WriteElementString(td, "program_studiu");
                    writer.WriteElementString(td, "a_exam");
                    writer.WriteElementString(td, "b_exam");
                    writer.WriteElementString(td, "c_exam");
                    writer.WriteElementString(td, "d_exam");
                    writer.WriteElementString(td, "e_exam");
                    writer.WriteElementString(td, "f_exam");
                    writer.WriteElementString(td, "g_exam");
                    writer.WriteElementString(td, "h_exam");

                    writer.WriteEndElement();

                    DataSet ds = new DataSet();
                    try
                    {
                        ds.ReadXml(filename);
                    }
                    catch (Exception e)
                    {
                        log.Message("Eroare: " + e.Message);
                        
                        try
                        {
                            filename += ".xml";
                            ds.ReadXml(filename);
                        }
                        catch(Exception ex)
                        {
                            log.Message("Eroare: " + ex.Message);
                            //throw ex;
                        }
                       //throw e;
                    }

                    for (int index = 0; index < numar_elevi; index++)
                    {
                        writer.WriteStartElement("tr");



                        writer.WriteElementString(td, ds.Tables[0].Rows[index][0].ToString());
                        writer.WriteElementString(td, ds.Tables[0].Rows[index][1].ToString());
                        writer.WriteElementString(td, ds.Tables[0].Rows[index][2].ToString());
                        writer.WriteElementString(td, ds.Tables[0].Rows[index][3].ToString());
                        writer.WriteElementString(td, ds.Tables[0].Rows[index][4].ToString());
                        writer.WriteElementString(td, ds.Tables[0].Rows[index][6].ToString());
                        writer.WriteElementString(td, ds.Tables[0].Rows[index][8].ToString());
                        writer.WriteElementString(td, ds.Tables[0].Rows[index][10].ToString());
                        writer.WriteElementString(td, ds.Tables[0].Rows[index][12].ToString());
                        writer.WriteElementString(td, ds.Tables[0].Rows[index][14].ToString());
                        writer.WriteElementString(td, ds.Tables[0].Rows[index][16].ToString());
                        writer.WriteElementString(td, ds.Tables[0].Rows[index][18].ToString());
                        writer.WriteElementString(td, ds.Tables[0].Rows[index][20].ToString());

                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    writer.WriteEndElement();

                    writer.WriteEndElement();

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    log.Message("A fost exportat fisierul copie in format HTML -> cu acelasi nume");
                    Form3 f = new Form3
                    {
                        Text = "Exportare HTML"
                    };
                    f.textBoxNume.Text = filename + ".html";
                    f.nume.Text = "Locație fișier exportat";
                    f.ShowDialog();
                }
            }
        }
    }
}
