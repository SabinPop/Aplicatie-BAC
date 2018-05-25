using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_XML_BAC
{
    /// <summary>
    /// Clasa Elev.
    /// Conține tipul de date 'elev' și metodele aferente utilizării acestuia.
    /// </summary>
    public class Elev
    {
        /// <summary>
        /// Tipul de date 'elev'.
        /// </summary>
        /// <param name="nume">Un șir de caractere ce reprezintă numele.</param>
        /// <param name="clasa">Un șir de caractere ce reprezintă clasa.</param>
        /// <param name="specializare">Un șir de caractere ce reprezintă specializarea.</param>
        /// <param name="sectia">Un șir de caractere ce reprezint secția.</param>
        /// <param name="program_studiu">Un șir de caractere ce reprezintă programul de studiu.</param>
        /// <param name="a_exam">Un șir de caractere ce reprezintă proba orală la limba romînă.</param>
        /// <param name="a_nota">Un șir de caractere  ce reprezintă calificativul obținut la proba orală la limba română.</param>
        /// <param name="b_exam">Un șir de caractere ce reprezintă proba orală la limba maternă.</param>
        /// <param name="b_nota">Un șir de caractere ce reprezintă nota obținută la proba orală la limba maternă.</param>
        /// <param name="c_exam">Un șir de caractere ce reprezintă limba străină la care a fost susținută proba.</param>
        /// <param name="c_nota">Un șir de caractere ce reprezintă calificativele obținute la limba străină.</param>
        /// <param name="d_exam">Un șir de caractere ce reprezintă competențele digitale.</param>
        /// <param name="d_nota">Un șir de caractere ce reprezintă nota obținută la competențele digitale.</param>
        /// <param name="e_exam">Un șir de caractere ce reprezintă limba română.</param>
        /// <param name="e_nota">Un șir de caractere ce reprezintă nota obținută la limba română.</param>
        /// <param name="f_exam">Un șir de caractere ce reprezintă limba maternă.</param>
        /// <param name="f_nota">Un șir de caractere ce reprezintă nota obținută la limba maternă.</param>
        /// <param name="g_exam">Un șir de caractere ce reprezintă disciplina obligatorie a specializării.</param>
        /// <param name="g_nota">Un șir de caractere ce reprezintă nota obținută la disciplina obligatorie a specializării.</param>
        /// <param name="h_exam">Un șir de caractere ce reprezintă disciplina la alegere.</param>
        /// <param name="h_nota">Un șir de caractere ce reprezintă nota obținută la disciplina la alegere.</param>
        public Elev(string nume, string clasa, string specializare, string sectia, string program_studiu, string a_exam, string a_nota, string b_exam, string b_nota, string c_exam, string c_nota, string d_exam, string d_nota, string e_exam, string e_nota, string f_exam, string f_nota, string g_exam, string g_nota, string h_exam, string h_nota)
        {
            this.Nume = nume;
            this.Clasa = clasa;
            this.Specializare = specializare;
            this.Sectia = sectia;
            this.Program_studiu = program_studiu;
            this.A_exam = a_exam;
            this.A_nota = a_nota;
            this.B_exam = b_exam;
            this.B_nota = b_nota;
            this.C_exam = c_exam;
            this.C_nota = c_nota;
            this.D_exam = d_exam;
            this.D_nota = d_nota;
            this.E_exam = e_exam;
            this.E_nota = e_nota;
            this.F_exam = f_exam;
            this.F_nota = f_nota;
            this.G_exam = g_exam;
            this.G_nota = g_nota;
            this.H_exam = h_exam;
            this.H_nota = h_nota;
        }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string Nume { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string Clasa { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string Specializare { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string Sectia { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string Program_studiu { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string A_exam { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string A_nota { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string B_exam { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string B_nota { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string C_exam { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string C_nota { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string D_exam { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string D_nota { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string E_exam { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string E_nota { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string F_exam { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string F_nota { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string G_exam { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string G_nota { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string H_exam { get; set; }
        /// <summary>
        /// Modifică sau returnează valoarea câmpului
        /// </summary>
        public string H_nota { get; set; }
    }
}
