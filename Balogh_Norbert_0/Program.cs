using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Balogh_Norbert_0
{
    static class Program
    {
        public static Kolcsonzes kolcsonzes = null;
        public static Visszavitel visszavitel = null;
        public static Keses keses = null;
        public static Form_nyito form_nyito = null;
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;

        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "bagolyvar";

            conn = new MySqlConnection(sb.ToString());

            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kolcsonzes = new Kolcsonzes();
            visszavitel = new Visszavitel();
            keses = new Keses();
            form_nyito = new Form_nyito();

            Application.Run(form_nyito);
        }
    }
}
