using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace yazlab1_1
{
    public partial class Registration : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text != string.Empty || txtRegisterPass.Text != string.Empty || txtRegisterUserName.Text != string.Empty)
            {
                if (txtRegisterPass.Text == txtConfirmPass.Text)
                {
                    using (var conn = new SqlConnection(connectionString))
                    {
                        var command = new SqlCommand("select * from admin where adminName='" + txtRegisterUserName.Text + "'", conn);
                        conn.Open();
                        var dr = command.ExecuteReader();

                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Bu kullanıcı adına ait bir hesap bulunmaktadır. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }   
                        else
                        {
                            dr.Close();
                            command = new SqlCommand("insert into admin(adminName,adminPass) values(@adminName,@adminPass)", conn);
                            command.Parameters.AddWithValue("adminName", txtRegisterUserName.Text);
                            command.Parameters.AddWithValue("adminPass", txtRegisterPass.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Hesabınız oluşturuldu. Lütfen giriş yapınız.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            Login login = new Login();
                            login.ShowDialog();
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
            login.ShowDialog();
        }
    }
}
