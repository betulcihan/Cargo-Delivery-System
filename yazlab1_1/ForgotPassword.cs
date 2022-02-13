using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace yazlab1_1
{
    public partial class ForgotPassword : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtConfirmNewPass.Text != string.Empty || txtNewPass.Text != string.Empty || txtForgotUserName.Text != string.Empty)
            {
                var adminPass = txtNewPass.Text;
                var adminName = txtForgotUserName.Text;
                if (txtNewPass.Text == txtConfirmNewPass.Text)
                {
                    using (var conn = new SqlConnection(connectionString))
                    {
                        var command = new SqlCommand("select adminName from admin where adminName='" + txtForgotUserName.Text + "'", conn);
                        conn.Open();
                        var dr = command.ExecuteReader();

                        if (dr.Read())
                        {
                            dr.Close();
                            using (var command2 = conn.CreateCommand())
                            {
                                command2.CommandText = @"update admin set adminPass = @adminPass where adminName = @adminName";
                                command2.Parameters.AddWithValue("@adminName", adminName);
                                command2.Parameters.AddWithValue("@adminPass", adminPass);
                                command2.ExecuteNonQuery();
                            }
                            MessageBox.Show("Şifreniz değiştirildi. Lütfen giriş yapınız.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            this.Hide();
                            Login login = new Login();
                            login.ShowDialog();
                        }
                        else
                        {
                            dr.Close();
                            MessageBox.Show("Bu kullanıcı adına ait bir hesap bulunmamaktadır. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                      
                        }
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Girilen şifreler uyuşmamaktadır ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
