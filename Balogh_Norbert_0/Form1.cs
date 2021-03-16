using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balogh_Norbert_0
{
    public partial class Form_nyito : Form
    {
        public Form_nyito()
        {
            InitializeComponent();
        }

        private void btn_kolcsonzes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.kolcsonzes.Show();
        }

        private void btn_visszavitel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.visszavitel.Show();
        }

        private void btn_Keses_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.keses.Show();
        }
    }
}
