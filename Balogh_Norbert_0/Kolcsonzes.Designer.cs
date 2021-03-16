namespace Balogh_Norbert_0
{
    partial class Kolcsonzes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kolcsonzes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_kolcsonzot = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combobox_Konyvek = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combobox_Berlok = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericud_peldany = new System.Windows.Forms.NumericUpDown();
            this.btn_add_list = new System.Windows.Forms.Button();
            this.btn_add_database = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericud_peldany)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericud_peldany);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.combobox_Berlok);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combobox_Konyvek);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(402, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kölcsönzés adatok";
            // 
            // list_kolcsonzot
            // 
            this.list_kolcsonzot.FormattingEnabled = true;
            this.list_kolcsonzot.ItemHeight = 16;
            this.list_kolcsonzot.Location = new System.Drawing.Point(469, 28);
            this.list_kolcsonzot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list_kolcsonzot.Name = "list_kolcsonzot";
            this.list_kolcsonzot.Size = new System.Drawing.Size(452, 372);
            this.list_kolcsonzot.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Könyv";
            // 
            // combobox_Konyvek
            // 
            this.combobox_Konyvek.FormattingEnabled = true;
            this.combobox_Konyvek.Location = new System.Drawing.Point(96, 41);
            this.combobox_Konyvek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combobox_Konyvek.Name = "combobox_Konyvek";
            this.combobox_Konyvek.Size = new System.Drawing.Size(284, 24);
            this.combobox_Konyvek.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bérlő";
            // 
            // combobox_Berlok
            // 
            this.combobox_Berlok.FormattingEnabled = true;
            this.combobox_Berlok.Location = new System.Drawing.Point(96, 106);
            this.combobox_Berlok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combobox_Berlok.Name = "combobox_Berlok";
            this.combobox_Berlok.Size = new System.Drawing.Size(284, 24);
            this.combobox_Berlok.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Példány";
            // 
            // numericud_peldany
            // 
            this.numericud_peldany.Location = new System.Drawing.Point(258, 168);
            this.numericud_peldany.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericud_peldany.Name = "numericud_peldany";
            this.numericud_peldany.Size = new System.Drawing.Size(122, 22);
            this.numericud_peldany.TabIndex = 5;
            this.numericud_peldany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericud_peldany.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_add_list
            // 
            this.btn_add_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_add_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add_list.Location = new System.Drawing.Point(38, 306);
            this.btn_add_list.Name = "btn_add_list";
            this.btn_add_list.Size = new System.Drawing.Size(402, 40);
            this.btn_add_list.TabIndex = 2;
            this.btn_add_list.Text = "Listában tárolja az adatokat";
            this.btn_add_list.UseVisualStyleBackColor = false;
            this.btn_add_list.Click += new System.EventHandler(this.btn_add_list_Click);
            // 
            // btn_add_database
            // 
            this.btn_add_database.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_add_database.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add_database.Location = new System.Drawing.Point(263, 447);
            this.btn_add_database.Name = "btn_add_database";
            this.btn_add_database.Size = new System.Drawing.Size(402, 40);
            this.btn_add_database.TabIndex = 3;
            this.btn_add_database.Text = "Rögzítés adatbázisban";
            this.btn_add_database.UseVisualStyleBackColor = false;
            this.btn_add_database.Click += new System.EventHandler(this.btn_add_database_Click);
            // 
            // Kolcsonzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 554);
            this.Controls.Add(this.btn_add_database);
            this.Controls.Add(this.btn_add_list);
            this.Controls.Add(this.list_kolcsonzot);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Kolcsonzes";
            this.Text = "Kölcsönzés";
            this.Load += new System.EventHandler(this.Kolcsonzes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericud_peldany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericud_peldany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobox_Berlok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combobox_Konyvek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_kolcsonzot;
        private System.Windows.Forms.Button btn_add_list;
        private System.Windows.Forms.Button btn_add_database;
    }
}