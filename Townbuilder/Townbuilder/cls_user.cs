using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Townbuilder
{
    public class cls_user
    {
        string m_user;
        int m_leveluser;
        int m_waffe;
        int m_levelwaffe;
        int m_ruestung;
        int m_levelruestung;
        int m_wache;
        int m_levelwache;
        int m_levelstadt;
        int m_stadtkaputt;
        int m_leveldungeon;
        int m_geld;
        string m_password;
        int m_profilbild;
        int m_id;

        public string User { get => m_user; set => m_user = value; }
        public int Leveluser { get => m_leveluser; set => m_leveluser = value; }
        public int Waffe { get => m_waffe; set => m_waffe = value; }
        public int Levelwaffe { get => m_levelwaffe; set => m_levelwaffe = value; }
        public int Ruestung { get => m_ruestung; set => m_ruestung = value; }
        public int Levelruestung { get => m_levelruestung; set => m_levelruestung = value; }
        public int Wache { get => m_wache; set => m_wache = value; }
        public int Levelwache { get => m_levelwache; set => m_levelwache = value; }
        public int Levelstadt { get => m_levelstadt; set => m_levelstadt = value; }
        public int Stadtkaputt { get => m_stadtkaputt; set => m_stadtkaputt = value; }
        public int Leveldungeon { get => m_leveldungeon; set => m_leveldungeon = value; }
        public int Geld { get => m_geld; set => m_geld = value; }
        public string Password { get => m_password; set => m_password = value; }
        public int Profilbild { get => m_profilbild; set => m_profilbild = value; }
        public int Id { get => m_id; set => m_id = value; }

        public cls_user(string user, int leveluser, int waffe, int levelwaffe, int ruestung, int levelruestung, int wache, int levelwache, int levelstadt, int stadtkaputt, int leveldungeon, int geld, int bild, string passwort, int id)
        {
            m_user = user;
            m_leveluser = leveluser;
            m_waffe = waffe;
            m_levelwaffe = levelwaffe;
            m_ruestung = ruestung;
            m_levelruestung = levelruestung;
            m_wache = wache;
            m_levelwache = levelwache;
            m_levelstadt = levelstadt;
            m_stadtkaputt = stadtkaputt;
            m_leveldungeon = leveldungeon;
            m_geld = geld;
            m_profilbild = bild;
            m_password = passwort;
            m_id = id;
        }
        public cls_user(string user, string password, int bild)
        {
            m_user = user;
            m_password = password;
            m_profilbild = bild;
        }
        public cls_user(string user, string password)
        {
            m_user = user;
            m_password = password;
        }
        public cls_user(string user, int leveluser, int wache, int levelwache, int levelstadt, int stadtkaputt, int geld, int bild, int id)
        {
            m_user = user;
            m_leveluser = leveluser;
            m_wache = wache;
            m_levelwache = levelwache;
            m_levelstadt = levelstadt;
            m_stadtkaputt = stadtkaputt;
            m_geld = geld;
            m_profilbild = bild;
            m_id = id;
        }
    }
}
