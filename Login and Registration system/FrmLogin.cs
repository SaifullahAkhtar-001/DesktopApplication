using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Login_and_Registration_system
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./db_users.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "' and password='" + txtPassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new dashboard().Show();
                this.Close();
            }
        }

        private void CheckBxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {

                txtPassword.PasswordChar = '*';
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new FrmRegister().Show();
            this.Hide();
        }
    }
}
