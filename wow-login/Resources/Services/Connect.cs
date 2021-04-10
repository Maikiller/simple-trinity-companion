using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wow_login.Resources.Services
{
    internal class Connect
    {
        private static MySqlConnection conn;

        private static MySqlConnection ConexaoBanco()
        {
            conn = new MySqlConnection("server=127.0.0.1;user id=maikiller;Pwd=Maikiller!2080*;persistsecurityinfo=True;database=auth");
            conn.Open();
            return conn;
        }

        public static DataTable ObtainUser(string sql)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da;
            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = sql;
            da = new MySqlDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            MessageBox.Show("Login Realizado com Success");
            ConexaoBanco().Close();
            return dt;
        }
    }
}