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
                MessageBox.Show("Der Benutzer existiert bereits");
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
                    u.Geld = Convert.ToInt32(reader[12]);
                    u.Profilbild = Convert.ToInt32(reader[14]);
                    u.Id = Convert.ToInt32(reader[11]);
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Die Datenbankverbindung hat nicht funktioniert");
                conn.Close();
            }
        }
        public static void UpdateDungeonEnde(cls_user u)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string query = "UPDATE tbl_townbuilder SET geld = @geld, leveldungeon=@leveldungeon, levelwaffe =@levelwaffe,levelruestung=@levelruestung WHERE id=@id;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add("geld", MySqlDbType.Int32).Value = u.Geld;
            cmd.Parameters.Add("leveldungeon", MySqlDbType.Int32).Value = u.Leveldungeon;
            cmd.Parameters.Add("levelwaffe", MySqlDbType.Int32).Value = u.Levelwaffe;
            cmd.Parameters.Add("levelruestung", MySqlDbType.Int32).Value = u.Levelruestung;
            cmd.CommandTimeout = 60;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Die Datenbankverbindung hat nicht funktioniert");
                conn.Close();
            }
        }
        public static void SelectRandomGegner(cls_user u, cls_user g)//g=gegner
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string query = "SELECT MAX(id) FROM tbl_townbuilder";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandTimeout = 60;
            int i = 0;
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    i = Convert.ToInt32(reader[0]);
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Die Datenbankverbindung hat nicht funktioniert");
                conn.Close();
            }
            Random r = new Random();
            bool istok = true;
            while (istok == true)
            {
                int id = r.Next(1, i);
                if (id != u.Id)
                {
                    query = "SELECT username, leveluser, wache, levelwache, levelstadt, stadtkaputt, geld, profilbild, id FROM tbl_townbuilder WHERE id =@id;";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.Add("id", MySqlDbType.Int32).Value = id;
                    cmd.CommandTimeout = 60;
                    try
                    {
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            g.User = Convert.ToString(reader[0]);
                            g.Leveluser = Convert.ToInt32(reader[1]);
                            g.Wache = Convert.ToInt32(reader[2]);
                            g.Levelwache = Convert.ToInt32(reader[3]);
                            g.Levelstadt = Convert.ToInt32(reader[4]);
                            g.Stadtkaputt = Convert.ToInt32(reader[5]);
                            g.Geld = Convert.ToInt32(reader[6]);
                            g.Profilbild = Convert.ToInt32(reader[7]);
                            g.Id = Convert.ToInt32(reader[8]);
                        }
                        conn.Close();
                        if(g.Stadtkaputt==0&&g.Id!=null)
                        {
                            istok = false;
                            MessageBox.Show(string.Format("Id: {0}", u.Id));
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Die Datenbankverbindung hat nicht funktioniert");
                        conn.Close();
                    }
                }
            }
        }
        public static void UpdateGegnerGame(cls_user u, cls_user g)
        {
            //WICHTIG BRAUCHST AUCH VOM GEGNER (ALSO BEI IHM GOLD UND STADT REPARIEREN UPDATEN)

            MySqlConnection conn = new MySqlConnection(connectionString);
            string query = "UPDATE tbl_townbuilder SET geld = @geld, levelwaffe=@levelwaffe, levelruestung=@levelruestung WHERE id=@id;";
            string query2 = "UPDATE tbl_townbuilder SET geld = @geld, levelstadt=@levelstadt, levelwaffe=@levelwaffe, levelruestung=@levelruestung WHERE id=@id;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            cmd.Parameters.Add("geld", MySqlDbType.Int32).Value = u.Geld;
            cmd.Parameters.Add("leveldungeon", MySqlDbType.Int32).Value = u.Leveldungeon;
            cmd.Parameters.Add("levelwaffe", MySqlDbType.Int32).Value = u.Levelwaffe;
            cmd.Parameters.Add("levelruestung", MySqlDbType.Int32).Value = u.Levelruestung;
            cmd2.Parameters.Add("geld", MySqlDbType.Int32).Value = u.Geld;
            cmd2.Parameters.Add("leveldungeon", MySqlDbType.Int32).Value = u.Leveldungeon;
            cmd2.Parameters.Add("levelwaffe", MySqlDbType.Int32).Value = u.Levelwaffe;
            cmd2.Parameters.Add("levelruestung", MySqlDbType.Int32).Value = u.Levelruestung;
            cmd2.Parameters.Add("levelstadt", MySqlDbType.Int32).Value = u.Levelstadt;
            cmd2.CommandTimeout = 60;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Die Datenbankverbindung hat nicht funktioniert");
                conn.Close();
            }
        }
    }
}
