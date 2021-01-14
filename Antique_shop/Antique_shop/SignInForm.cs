using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Antique_shop
{
    public partial class SignInForm : Form
    {
        public string ConStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Antique_shop_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public SignInForm()
        {
            InitializeComponent();
        }

        private void tb_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char)Keys.Space;
        }
        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char)Keys.Space;
        }
        private void btn_signIn_Click(object sender, EventArgs e)
        {
            if (!ValidateSignInForm(tb_login.Text, tb_password.Text))
                MessageBox.Show(Properties.Strings.SignInForm_MB_SignInFieldsValidationFailed_text, Properties.Strings.SignInForm_MB_SignInFieldsValidationFailed_caption);
            else
            {
                using var connection = new SqlConnection(ConStr);
                try
                {
                    connection.Open();
                    var cmdText =
                        $"SELECT * FROM shop_users WHERE shop_user_login = '{tb_login.Text}' AND shop_user_password = '{tb_password.Text}'";
                    using var command = new SqlCommand(cmdText, connection);
                    if (command.ExecuteScalar() != null)
                    {
                        var dbAdminForm = new DBAdminForm();
                        dbAdminForm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show(Properties.Strings.SignInForm_MB_SignInFieldsValidationFailed_text, Properties.Strings.SignInForm_MB_SignInFieldsValidationFailed_caption);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool ValidateSignInForm(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) & string.IsNullOrWhiteSpace(password)) return false;
            const string symbols = "!@#$%^&?*()[]{}";
            var loginOk = true;
            var passwordOk = true;
            loginOk &= !login.Contains(" ");
            loginOk &= login.Length >= 6;
            loginOk &= login.All(c => char.IsLetterOrDigit(c) || c == '_');
            passwordOk &= !password.Contains(" ");
            passwordOk &= password.Length >= 8;
            passwordOk &= password.Any(char.IsDigit);
            passwordOk &= password.Any(char.IsLetter);
            passwordOk &= password.Any(char.IsUpper);
            passwordOk &= password.Any(char.IsLower);
            passwordOk &= password.Any(c => symbols.Contains(c));
            return loginOk & passwordOk;
        }


    }
}
