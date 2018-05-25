using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Aplicatie_XML_BAC;

namespace Aplicatie_XML_BAC
{
    /// <summary>
    /// Clasa setărilor
    /// </summary>
    public partial class Settings : Form
    {
        /// <summary>
        /// Creează o nouă instanță a clasei Log.
        /// Folosită pentru înregistrarea acțiunilor aplicației.
        /// </summary>
        public Log log = new Log();

        /// <summary>
        /// Inițiaizeală instanța clasei de setări
        /// </summary>
        public Settings()
        {
            InitializeComponent();
            MySettings Settings = MySettings.Load();
            radioButton1.Checked = Settings.Debug;
            radioButton2.Checked = !Settings.Debug;
            radioButton3.Checked = Settings.Popup;
            radioButton4.Checked = !Settings.Popup;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MySettings Settings = MySettings.Load();
            log.Message("Debugger dezactivat");
            Settings.Debug = false;
            Settings.Save();            
        }

        

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MySettings Settings = MySettings.Load();
            Settings.Debug = true;
            log.Message("Debugger activat");
            Settings.Save();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MySettings Settings = MySettings.Load();
            Settings.Popup = true;
            log.Message("Pup-ups activate");
            Settings.Save();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MySettings Settings = MySettings.Load();
            Settings.Popup = false;
            log.Message("Pup-ups dezactivate");
            Settings.Save();
        }
    }

    /// <summary>
    /// Clasa responsabilă de setările aplicației.
    /// </summary>
    /// <typeparam name="T">Tipul de obiect al setărilor.</typeparam>
    public class AppSettings<T> where T : new()
    {
        private const string DEFAULT_FILENAME = "settings.json";

        /// <summary>
        /// Metodă folosită pentru salvarea setărilor.
        /// </summary>
        /// <param name="fileName">Numele fișierului de setări.</param>
        public void Save(string fileName = DEFAULT_FILENAME)
        {
            File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(this));
        }

        /// <summary>
        /// Metodă folosită pentru salvarea setărilor.
        /// </summary>
        /// <param name="pSettings">Variabilă de tip obiect.</param>
        /// <param name="fileName">Numele fișierului de setări.</param>
        public static void Save(T pSettings, string fileName = DEFAULT_FILENAME)
        {
            File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(pSettings));
        }

        /// <summary>
        /// Metodă folosită pentru încărcarea setărilor.
        /// </summary>
        /// <param name="fileName">Numele fișierului de setări</param>
        /// <returns></returns>
        public static T Load(string fileName = DEFAULT_FILENAME)
        {
            T t = new T();
            if (File.Exists(fileName))
                t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
            return t;
        }
    }

    /// <summary>
    /// Clasa de variabile a setărilor.
    /// Folosită pentru memorarea și modificarea setărilor.
    /// </summary>
    public class MySettings : AppSettings<MySettings>
    {
        private bool debug = true;
        private bool popup = true;
        /// <summary>
        /// Variabilă folosită pentru modificarea setărilor de debug.
        /// </summary>
        public bool Debug { get => debug; set => debug = value; }

        /// <summary>
        /// Variabilă folosită pentru modificarea setărilor de pupup.
        /// </summary>
        public bool Popup { get => popup; set => popup = value; }
    }
}
