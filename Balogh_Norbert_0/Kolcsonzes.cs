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
    public partial class Kolcsonzes : Form
    {
        public Kolcsonzes()
        {
            InitializeComponent();
        }

        private void Kolcsonzes_Load(object sender, EventArgs e)
        {
            Kony_cimek_Beolvasasa();
            Berlok_Beolvasasa();
        }

        public void Kony_cimek_Beolvasasa()
        {
            try
            {
                Program.sql.CommandText = "SELECT `Cím` FROM `konyvek`";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        combobox_Konyvek.Items.Add(dr.GetString("Cím"));
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

        public void Berlok_Beolvasasa()
        {
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

        private void btn_add_list_Click(object sender, EventArgs e)
        {
            if (!Valid_field())
            {
                return;
            }

            list_kolcsonzot.Items.Add(combobox_Berlok.SelectedItem.ToString() + " -> " + combobox_Konyvek.SelectedItem.ToString() + "(" + numericud_peldany.Value + "db)");

            combobox_Konyvek.SelectedIndex = -1;
            combobox_Berlok.SelectedIndex = -1;
            numericud_peldany.Value = 1;

        }

        private void btn_add_database_Click(object sender, EventArgs e)
        {
            if (!Valid_field())
            {
                return;
            }

            Program.sql.CommandText = $"INSERT INTO kolcsonzes (`konyvID`, `kolcsonzoID`, `kivetelDatum`, `peldany`) " +
                $"VALUES ((SELECT `Kod` FROM `konyvek` WHERE `Cím` = '{combobox_Konyvek.SelectedItem}'), " +
                $"(SELECT `ID` FROM `kolcsonzo` WHERE `nev` = '{combobox_Berlok.SelectedItem}'), " +
                $"'{DateTime.Now.ToString("yyyy-MM-dd")}', '{numericud_peldany.Value}')";
            Program.sql.ExecuteNonQuery();

            MessageBox.Show("Sikeres rögzítés!", "Visszajelzés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            combobox_Konyvek.SelectedIndex = -1;
            combobox_Berlok.SelectedIndex = -1;
            numericud_peldany.Value = 1;
        }

        public bool Valid_field()
        {
            if (combobox_Konyvek.SelectedIndex == -1)
            {
                MessageBox.Show("Válasszon könyvet!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combobox_Konyvek.Focus();
                return false;
            }

            if (combobox_Berlok.SelectedIndex == -1)
            {
                MessageBox.Show("Válasszon bérlőt!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combobox_Berlok.Focus();
                return false;
            }

            return true;
        }
    }
}
