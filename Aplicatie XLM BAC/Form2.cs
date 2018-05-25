using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_XML_BAC
{
    /// <summary>
    /// Clasa ferestrei de salvare.
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// Metoda principală a clasei.
        /// </summary>
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodă folosită pentru returnarea datelor.
        /// </summary>
        /// <returns>Returnează numele elevului sub formă de text.</returns>
        public string GetData()
        {
            return name.Text;
        }

        /// <summary>
        /// Selectarea opțiunii de dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Confirm_Click(object sender, EventArgs e)
        {
            if(name.Text == "")
            {
                MessageBox.Show("Introduceți un nume pentru fișier.",
                    "Eroare", 
                    MessageBoxButtons.OK);
            }
            else
            {
                Close();
            }
        }
    }
}
