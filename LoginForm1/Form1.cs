using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginForm1
{
    public partial class Form1 : Form
    {
        public string _email = "thethtarthuzar648@gmail.com";
        public string _password = "123123";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtemail.Text;
                string password = txtpw.Text;

                if (IsNullOrEmpty(email, password))
                {
                    MessageBox.Show("Please fill all fields...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return;

                    if (email == null)
                    {
                        MessageBox.Show("Please enter your email...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    else if (password == null)
                    {
                        MessageBox.Show("Please enter your password...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    return;
                }

                if (email.Equals(_email) && password.Equals(_password)) // Equals ==
                {
                    MessageBox.Show("Login Successful.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (email != _email)
                {
                    MessageBox.Show("Your email is invalid.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Login Fail!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                throw;
            }
        }

        public bool IsNullOrEmpty(params string[] str)
        {
            return str.Any(x => string.IsNullOrEmpty(x));
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
