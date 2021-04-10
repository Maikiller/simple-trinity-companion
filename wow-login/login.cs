using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wow_login.Resources.Class;
using wow_login.Resources.Services;

namespace wow_login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;
            Connect.ObtainUser("SELECT account.username FROM account WHERE account.username = '" + username + "' AND account.pass = " + pass + "");
        }
    }
}