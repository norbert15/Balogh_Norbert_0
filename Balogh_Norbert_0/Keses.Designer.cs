namespace Balogh_Norbert_0
{
    partial class Keses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keses));
            this.listBox_Keses = new System.Windows.Forms.ListBox();
            this.comboBox_Nev = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox_Keses
            // 
            this.listBox_Keses.FormattingEnabled = true;
            this.listBox_Keses.Location = new System.Drawing.Point(27, 106);
            this.listBox_Keses.Name = "listBox_Keses";
            this.listBox_Keses.Size = new System.Drawing.Size(565, 316);
            this.listBox_Keses.TabIndex = 0;
            // 
            // comboBox_Nev
            // 
            this.comboBox_Nev.FormattingEnabled = true;
            this.comboBox_Nev.Location = new System.Drawing.Point(141, 43);
            this.comboBox_Nev.Name = "comboBox_Nev";
            this.comboBox_Nev.Size = new System.Drawing.Size(289, 21);
            this.comboBox_Nev.TabIndex = 1;
            this.comboBox_Nev.SelectedValueChanged += new System.EventHandler(this.comboBox_Nev_SelectedValueChanged);
            // 
            // Keses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Nev);
            this.Controls.Add(this.listBox_Keses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Keses";
            this.Text = "30 napnál régebben bérelve";
            this.Load += new System.EventHandler(this.Keses_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Keses;
        private System.Windows.Forms.ComboBox comboBox_Nev;
    }
}