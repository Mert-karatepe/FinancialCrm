using FinancialCrm.Models;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
     

        private void button1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            var user= db.Users.FirstOrDefault(x => x.UserName == username && x.Password == password);//kullanıcı adı ve şifre kontrolü

            if (user != null) // Kullanıcı varsa
            {
                // Yeni formu aç
                FrmDashboard dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignIn frmSignIn = new FrmSignIn();
            frmSignIn.Show();
            this.Hide();
        }
    }
}
