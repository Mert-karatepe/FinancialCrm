using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();


        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
            this.Hide();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void button_Click(object sender, EventArgs e)
        {
            FrmBanks banks = new FrmBanks();
            banks.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmExpences frmExpences = new FrmExpences();
            frmExpences.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;

            Categories categories = new Categories();

            categories.CategoryName = categoryName;
            
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Başarıyla Eklenmiştir");

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeValue = db.Categories.Find(id);

            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Başarıyla Silinmiştir");

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            int id = int.Parse(txtCategoryId.Text);
            var updateValue = db.Categories.Find(id);

            updateValue.CategoryName = categoryName;
            db.SaveChanges();

            MessageBox.Show("Başarıyla Güncellenmiştir");

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBankProcess frmBankProcess = new FrmBankProcess();
            frmBankProcess.Show();
            this.Hide();
        }
    }
}
