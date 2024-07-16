using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Co_Working_Space_Management_Application
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Please enter your username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Please enter your password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    SqlConnection koneksi = new SqlConnection("Data Source=DESKTOP-2TSOBBK;Initial Catalog=BD_WorkingApplication;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Select * from TB_USER where username = @username and password = @password", koneksi);
                    cmd.Parameters.AddWithValue("username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("password", tbPassword.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    { 
                        this.Hide();
                        Home home = new Home();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is invalid");
                        tbUsername.Text = "";
                        tbPassword.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
