using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Townbuilder
{
    class cls_DataProvider
    {
        const string connectionString = "datasource=db4free.net;port=3306;username=laureenundlara;password=EscapeTheRoom;database=db_escapetheroom;";
        public static void InsertData(cls_user u)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string query = "INSERT INTO tbl_townbuilder(username, leveluser, waffe, levelwaffe, ruestung, levelruestung, wache, levelwache, levelstadt, stadtkaputt, leveldungeon, geld, passwort, profilbild) VALUES (@username, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 0, @passwort, @profilbild)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = u.User;
            cmd.Parameters.Add("@passwort", MySqlDbType.VarChar).Value = u.Password;
            cmd.Parameters.Add("@profilbild", MySqlDbType.Int32).Value = u.Profilbild;
            cmd.CommandTimeout = 60;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Fehler: {0}", ex));
                conn.Close();
            }
        }
        public static void SelectLogin(cls_user u)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string query = "SELECT * FROM tbl_townbuilder WHERE username=@username AND passwort=@password";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add("username", MySqlDbType.VarChar).Value = u.User;
            cmd.Parameters.Add("password", MySqlDbType.VarChar).Value = u.Password;
            cmd.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    u.Leveluser = Convert.ToInt32(reader[1]);
                    u.Waffe = Convert.ToInt32(reader[2]);
                    u.Levelwaffe = Convert.ToInt32(reader[3]);
                    u.Ruestung = Convert.ToInt32(reader[4]);
                    u.Levelruestung = Convert.ToInt32(reader[5]);
                    u.Wache = Convert.ToInt32(reader[6]);
                    u.Levelwache = Convert.ToInt32(reader[7]);
                    u.Levelstadt = Convert.ToInt32(reader[8]);
                    u.Stadtkaputt = Convert.ToInt32(reader[9]);
                    u.Leveldungeon = Convert.ToInt32(reader[10]);
                    u.Geld = Convert.ToInt32(reader[11]);
                    u.Profilbild = Convert.ToInt32(reader[13]);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("{0}",ex));
                conn.Close();
            }
        }
    }
}
