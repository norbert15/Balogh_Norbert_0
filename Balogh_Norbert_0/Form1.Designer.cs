namespace Balogh_Norbert_0
{
    partial class Form_nyito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_nyito));
            this.btn_visszavitel = new System.Windows.Forms.Button();
            this.btn_kolcsonzes = new System.Windows.Forms.Button();
            this.btn_Keses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_visszavitel
            // 
            this.btn_visszavitel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_visszavitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_visszavitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_visszavitel.Location = new System.Drawing.Point(344, 153);
            this.btn_visszavitel.Name = "btn_visszavitel";
            this.btn_visszavitel.Size = new System.Drawing.Size(143, 40);
            this.btn_visszavitel.TabIndex = 1;
            this.btn_visszavitel.Text = "Visszavitel";
            this.btn_visszavitel.UseVisualStyleBackColor = false;
            this.btn_visszavitel.Click += new System.EventHandler(this.btn_visszavitel_Click);
            // 
            // btn_kolcsonzes
            // 
            this.btn_kolcsonzes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_kolcsonzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kolcsonzes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_kolcsonzes.Location = new System.Drawing.Point(141, 153);
            this.btn_kolcsonzes.Name = "btn_kolcsonzes";
            this.btn_kolcsonzes.Size = new System.Drawing.Size(143, 40);
            this.btn_kolcsonzes.TabIndex = 2;
            this.btn_kolcsonzes.Text = "Kölcsönzés";
            this.btn_kolcsonzes.UseVisualStyleBackColor = false;
            this.btn_kolcsonzes.Click += new System.EventHandler(this.btn_kolcsonzes_Click);
            // 
            // btn_Keses
            // 
            this.btn_Keses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Keses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Keses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Keses.Location = new System.Drawing.Point(551, 153);
            this.btn_Keses.Name = "btn_Keses";
            this.btn_Keses.Size = new System.Drawing.Size(143, 40);
            this.btn_Keses.TabIndex = 3;
            this.btn_Keses.Text = "Késések";
            this.btn_Keses.UseVisualStyleBackColor = false;
            this.btn_Keses.Click += new System.EventHandler(this.btn_Keses_Click);
            // 
            // Form_nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Keses);
            this.Controls.Add(this.btn_kolcsonzes);
            this.Controls.Add(this.btn_visszavitel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_nyito";
            this.Text = "Könyvkölcsönzés";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_visszavitel;
        private System.Windows.Forms.Button btn_kolcsonzes;
        private System.Windows.Forms.Button btn_Keses;
    }
}

