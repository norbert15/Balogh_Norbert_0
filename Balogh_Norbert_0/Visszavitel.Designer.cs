namespace Balogh_Norbert_0
{
    partial class Visszavitel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visszavitel));
            this.btn_delete_list = new System.Windows.Forms.Button();
            this.combobox_Berlok = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_kolcsonzott = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textB_szerzo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textB_konyvC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textB_ISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_datum = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUD_peldany = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_peldany)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete_list
            // 
            this.btn_delete_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_delete_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_delete_list.Location = new System.Drawing.Point(516, 406);
            this.btn_delete_list.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete_list.Name = "btn_delete_list";
            this.btn_delete_list.Size = new System.Drawing.Size(333, 49);
            this.btn_delete_list.TabIndex = 3;
            this.btn_delete_list.Text = "Visszaad";
            this.btn_delete_list.UseVisualStyleBackColor = false;
            this.btn_delete_list.Click += new System.EventHandler(this.btn_delete_list_Click);
            // 
            // combobox_Berlok
            // 
            this.combobox_Berlok.FormattingEnabled = true;
            this.combobox_Berlok.Location = new System.Drawing.Point(123, 31);
            this.combobox_Berlok.Margin = new System.Windows.Forms.Padding(5);
            this.combobox_Berlok.Name = "combobox_Berlok";
            this.combobox_Berlok.Size = new System.Drawing.Size(263, 24);
            this.combobox_Berlok.TabIndex = 5;
            this.combobox_Berlok.SelectedValueChanged += new System.EventHandler(this.combobox_Berlok_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bérlő neve";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_kolcsonzott);
            this.groupBox1.Location = new System.Drawing.Point(32, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 459);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kölcsönzött könyvek";
            // 
            // list_kolcsonzott
            // 
            this.list_kolcsonzott.FormattingEnabled = true;
            this.list_kolcsonzott.ItemHeight = 16;
            this.list_kolcsonzott.Location = new System.Drawing.Point(18, 33);
            this.list_kolcsonzott.Name = "list_kolcsonzott";
            this.list_kolcsonzott.Size = new System.Drawing.Size(402, 420);
            this.list_kolcsonzott.TabIndex = 0;
            this.list_kolcsonzott.Click += new System.EventHandler(this.list_kolcsonzott_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Szerző";
            // 
            // textB_szerzo
            // 
            this.textB_szerzo.Location = new System.Drawing.Point(594, 125);
            this.textB_szerzo.Name = "textB_szerzo";
            this.textB_szerzo.Size = new System.Drawing.Size(255, 22);
            this.textB_szerzo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Könyvcím";
            // 
            // textB_konyvC
            // 
            this.textB_konyvC.Location = new System.Drawing.Point(594, 171);
            this.textB_konyvC.Name = "textB_konyvC";
            this.textB_konyvC.Size = new System.Drawing.Size(255, 22);
            this.textB_konyvC.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "ISBN";
            // 
            // textB_ISBN
            // 
            this.textB_ISBN.Location = new System.Drawing.Point(594, 220);
            this.textB_ISBN.Name = "textB_ISBN";
            this.textB_ISBN.Size = new System.Drawing.Size(255, 22);
            this.textB_ISBN.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Példány";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dátum";
            // 
            // label_datum
            // 
            this.label_datum.AutoSize = true;
            this.label_datum.Location = new System.Drawing.Point(594, 322);
            this.label_datum.Name = "label_datum";
            this.label_datum.Size = new System.Drawing.Size(0, 16);
            this.label_datum.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(644, 363);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 20);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Késett!";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUD_peldany
            // 
            this.numericUD_peldany.Location = new System.Drawing.Point(715, 269);
            this.numericUD_peldany.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUD_peldany.Name = "numericUD_peldany";
            this.numericUD_peldany.Size = new System.Drawing.Size(134, 22);
            this.numericUD_peldany.TabIndex = 18;
            this.numericUD_peldany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUD_peldany.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Visszavitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.numericUD_peldany);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label_datum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textB_ISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textB_konyvC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textB_szerzo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.combobox_Berlok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete_list);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Visszavitel";
            this.Text = "Könyv visszavétel";
            this.Load += new System.EventHandler(this.Visszavitel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_peldany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete_list;
        private System.Windows.Forms.ComboBox combobox_Berlok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox list_kolcsonzott;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textB_szerzo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textB_konyvC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textB_ISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_datum;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUD_peldany;
    }
}