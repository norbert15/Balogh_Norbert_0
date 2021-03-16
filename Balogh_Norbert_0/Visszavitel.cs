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
    public partial class Visszavitel : Form
    {
        static List<Kolcsonzott_konyvek> kolcsonzott_konyvek = new List<Kolcsonzott_konyvek>();

        public Visszavitel()
        {
            InitializeComponent();
        }

        private void Visszavitel_Load(object sender, EventArgs e)
        {
            Berlok_Beolvasasa();
        }

        public void Berlok_Beolvasasa()
        {
            combobox_Berlok.Items.Clear();
            try
            {
                Program.sql.CommandText = "SELECT `nev` FROM `kolcsonzo`";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        combobox_Berlok.Items.Add(dr.GetString("nev"));
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

        private void combobox_Berlok_SelectedValueChanged(object sender, EventArgs e)
        {
            list_feltolt();
        }

        private void list_feltolt()
        {
            list_kolcsonzott.Items.Clear();
            kolcsonzott_konyvek.Clear();
            try
            {
                Program.sql.CommandText = $"SELECT kolcsonzo.nev AS nev, konyvek.Szerzo AS szerzo, konyvek.Cím AS cim, konyvek.ISBN AS ISBN, kolcsonzes.kivetelDatum AS datum, kolcsonzes.peldany AS peldany " +
                    $"FROM kolcsonzes JOIN kolcsonzo ON kolcsonzes.kolcsonzoID = kolcsonzo.ID " +
                    $"JOIN konyvek ON kolcsonzes.konyvID = konyvek.Kod WHERE kolcsonzo.nev = '{combobox_Berlok.SelectedItem}'";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    int index = 0;
                    while (dr.Read())
                    {
                        kolcsonzott_konyvek.Add(new Kolcsonzott_konyvek(dr.GetString("nev"), dr.GetString("szerzo"), dr.GetString("cim"), dr.GetInt32("peldany"), dr.GetString("ISBN"), dr.GetDateTime("datum")));
                        list_kolcsonzott.Items.Add(kolcsonzott_konyvek[index++].ToString());
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

        private void list_kolcsonzott_Click(object sender, EventArgs e)
        {
            textB_konyvC.Text = kolcsonzott_konyvek[list_kolcsonzott.SelectedIndex].Cim;
            textB_szerzo.Text = kolcsonzott_konyvek[list_kolcsonzott.SelectedIndex].Szerzo;
            textB_ISBN.Text = kolcsonzott_konyvek[list_kolcsonzott.SelectedIndex].ISBN1;
            numericUD_peldany.Value = kolcsonzott_konyvek[list_kolcsonzott.SelectedIndex].Peldany;
            DateTime time = kolcsonzott_konyvek[list_kolcsonzott.SelectedIndex].Datum;
            int nap = (int) DateTime.Now.Subtract(time).TotalDays;
            label_datum.Text = $"{time.ToString("yyyy-MM-dd")} ({nap} nap)";

            if(nap > 30)
            {
                checkBox1.Checked = true;
            }
        }

        private void btn_delete_list_Click(object sender, EventArgs e)
        {
            try
            {
                string nev = kolcsonzott_konyvek[list_kolcsonzott.SelectedIndex].Kolcsonzo;
                DateTime time = kolcsonzott_konyvek[list_kolcsonzott.SelectedIndex].Datum;
                Program.sql.CommandText = $"DELETE k FROM kolcsonzes k INNER JOIN kolcsonzo kol ON k.kolcsonzoID = kol.ID INNER JOIN konyvek kv ON k.konyvID = kv.Kod WHERE kol.nev ='{nev}' AND k.kivetelDatum ='{time.ToString("yyyy-MM-dd")}' AND kv.Cím ='{textB_konyvC.Text}' AND k.peldany ='{numericUD_peldany.Value}'";
                Program.sql.ExecuteNonQuery();

                MessageBox.Show("Sikeres törlés!", "Visszajelzés!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                list_feltolt();
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
