namespace Aplicatie_XML_BAC
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.nume = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Location = new System.Drawing.Point(9, 9);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(104, 13);
            this.nume.TabIndex = 0;
            this.nume.Text = "Ultimul elev introdus:";
            // 
            // textBoxNume
            // 
            this.textBoxNume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNume.Location = new System.Drawing.Point(122, 9);
            this.textBoxNume.Multiline = true;
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.ReadOnly = true;
            this.textBoxNume.Size = new System.Drawing.Size(227, 67);
            this.textBoxNume.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continuă";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 117);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.nume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimul elev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        /// <summary>
        /// Casetă de text.
        /// Detalii.
        /// </summary>
        public System.Windows.Forms.TextBox textBoxNume;
        /// <summary>
        /// Numele elevului.
        /// </summary>
        public System.Windows.Forms.Label nume;
    }
}