using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;


namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            using (FinancialCrmDbEntities context = new FinancialCrmDbEntities())
            {
                string username = txtUserName.Text;
                string text = txtPassword.Text;
                

                // LINQ sorgusu ile kullanıcıyı bulma
                var user = context.Users
                                  .FirstOrDefault(k => k.UserName == username && k.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Başarıyla giriş yapıldı!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Başarılı giriş sonrası ana forma yönlendirme (Örn: FrmDashboard)
                    FrmDashboard dashboardForm = new FrmDashboard();
                    dashboardForm.Show();
                    this.Hide(); // Login formunu gizle
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
        }
 

