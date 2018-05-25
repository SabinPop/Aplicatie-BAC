namespace Aplicatie_XML_BAC
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.info = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.AllowDrop = true;
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(12, 9);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(247, 13);
            this.info.TabIndex = 0;
            this.info.Text = "Introduceți numele fișierului ce urmează să fie creat";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(15, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(244, 20);
            this.name.TabIndex = 1;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(15, 62);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(244, 23);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Crează";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 113);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.name);
            this.Controls.Add(this.info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Fișier nou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox name;
    }
}