using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mock data
            string userName = "Von";
            string passWord = "123";

            if (userName == UsernameTxtbox.Text && passWord == PasswordTxtBox.Text)
            {
                Form form2 = new Form2();
                form2.Show();
            }
            else
            {
                if (string.IsNullOrEmpty(UsernameTxtbox.Text))
                {
                    ErrorProvider1.SetError(UsernameTxtbox, "Username is required!");
                    UsernameTxtbox.Focus();
                }
                else if (string.IsNullOrEmpty(PasswordTxtBox.Text))
                {
                    ErrorProvider1.SetError(PasswordTxtBox, "Password is required");
                    PasswordTxtBox.Focus();
                }
                else if (string.IsNullOrEmpty(UsernameTxtbox.Text) && string.IsNullOrEmpty(PasswordTxtBox.Text))
                {
                    ErrorProvider1.SetError(UsernameTxtbox, "Username is required!");
                    UsernameTxtbox.Focus();
                    ErrorProvider1.SetError(PasswordTxtBox, "Password is required");
                    PasswordTxtBox.Focus();
                }
                else if (UsernameTxtbox.Text != userName && PasswordTxtBox.Text != passWord)
                {
                    ErrorProvider1.SetError(UsernameTxtbox, "Please input the right username");
                    UsernameTxtbox.Focus();
                    ErrorProvider1.SetError(PasswordTxtBox, "Please use the right password");
                    PasswordTxtBox.Focus();
                }
                else if (UsernameTxtbox.Text != userName)
                {

                    ErrorProvider1.SetError(UsernameTxtbox, "Please input the right username");
                    UsernameTxtbox.Focus();

                }
                else if (PasswordTxtBox.Text != passWord)
                {
                    ErrorProvider1.SetError(PasswordTxtBox, "Please use the right password");
                    PasswordTxtBox.Focus();
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}