using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace yazlab1_1
{
    public partial class Login : Form
    {
        public static GoogleMap g;
        public static KargoTakip k;

        string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != string.Empty || txtUserName.Text != string.Empty)
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand("select * from admin where adminName='" + txtUserName.Text + "' and adminPass='" + txtPass.Text + "'", conn);
                    var dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        this.Hide();
                        var threadGoogle = new Thread(() =>
                        {
                            g = new GoogleMap();
                            Application.Run(g);
                        });

                        threadGoogle.Start();

                        var threadKargo = new Thread(() =>
                        {
                            k = new KargoTakip();
                            Application.Run(k);
                        });

                        threadKargo.Start();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Bu kullanıcı adı ve şifrece ait kullanıcı bulunamadı ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();

        }

        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }
    }
}
