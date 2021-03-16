using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Balogh_Norbert_0
{
    public partial class Keses : Form
    {
        static List<Kolcsonzott_konyvek> kolcsonzott_konyvek = new List<Kolcsonzott_konyvek>();
         
        public Keses()
        {
            InitializeComponent();
        }

        private void Keses_Load(object sender, EventArgs e)
        {
            Berlok_Beolvasasa();
        }

        public void Berlok_Beolvasasa()
        {
            comboBox_Nev.Items.Clear();
            try
            {
                Program.sql.CommandText = "SELECT `nev` FROM `kolcsonzo`";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        comboBox_Nev.Items.Add(dr.GetString("nev"));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                throw;
            }
        }

        private void comboBox_Nev_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox_Keses.Items.Clear();
            kolcsonzott_konyvek.Clear();
            try
            {
                Program.sql.CommandText = $"SELECT kolcsonzo.nev AS nev, konyvek.Szerzo AS szerzo, konyvek.Cím AS cim, konyvek.ISBN AS ISBN, kolcsonzes.kivetelDatum AS datum, kolcsonzes.peldany AS peldany " +
                    $"FROM kolcsonzes JOIN kolcsonzo ON kolcsonzes.kolcsonzoID = kolcsonzo.ID " +
                    $"JOIN konyvek ON kolcsonzes.konyvID = konyvek.Kod WHERE kolcsonzo.nev = '{comboBox_Nev.SelectedItem}'";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    int index = 0;
                    while (dr.Read())
                    {
                        DateTime time = dr.GetDateTime("datum");
                        int nap = (int)DateTime.Now.Subtract(time).TotalDays;

                        if (nap > 30)
                        {
                            kolcsonzott_konyvek.Add(new Kolcsonzott_konyvek(dr.GetString("nev"), dr.GetString("szerzo"), dr.GetString("cim"), dr.GetInt32("peldany"), dr.GetString("ISBN"), dr.GetDateTime("datum")));
                            listBox_Keses.Items.Add(kolcsonzott_konyvek[index++].ToString());
                        }

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                throw;

            }
        }
    }
         
}
