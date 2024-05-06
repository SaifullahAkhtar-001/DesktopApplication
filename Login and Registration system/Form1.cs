using System.Data.OleDb;

namespace Login_and_Registration_system
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./db_users.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConPassword.Text == "")
            {
                MessageBox.Show("Username and Passwoed  fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPassword.Text == txtConPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConPassword.Text = "";

                MessageBox.Show("Your account is created successfully", "Registration Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password doesnot match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void CheckBxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {

                txtPassword.PasswordChar = '*';
                txtConPassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConPassword.Text = "";
            txtUsername.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
        }
    }
}
