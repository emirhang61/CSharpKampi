using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public FrmBanks()
        {
            InitializeComponent();
           
            db = new FinancialCrmDbEntities();
        }

        

        public void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıf Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            // Ekrana Yazdır
            lblZiraatBankBalance.Text = (ziraatBankBalance != null ? ziraatBankBalance.ToString() : "0") + " ₺";
            lblVakıfBankBalance.Text = (vakifBankBalance != null ? vakifBankBalance.ToString() : "0") + " ₺";
            lblİşBankBalance.Text = (isBankBalance != null ? isBankBalance.ToString() : "0") + " ₺";

            //Banka Hareketleri
            var bankProcess1 = db.BankProcesses.OrderByDescending(x =>x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " " + bankProcess1.Amount + " " + bankProcess1.ProcesssDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + bankProcess2.Amount + " " + bankProcess2.ProcesssDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + bankProcess3.Amount + " " + bankProcess3.ProcesssDate;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + bankProcess4.Amount + " " + bankProcess4.ProcesssDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " " + bankProcess5.Amount + " " + bankProcess5.ProcesssDate;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Yeni Formu oluştur
            FrmCategories categoriesForm = new FrmCategories();

            // 2. Yeni Formu Göster
            categoriesForm.Show();

            // 3. İsteğe Bağlı: Mevcut formu gizle (Eğer ana formunuz bu ise)
             this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
           
            FrmBilling billingForm = new FrmBilling();
            billingForm.Show();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            FrmSpendings spendingsForm = new FrmSpendings();
            spendingsForm.Show();
        }

        private void btnBankTransactions_Click(object sender, EventArgs e)
        {
            FrmBankProcesses bankProcessesForm = new FrmBankProcesses();
            bankProcessesForm.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSettings settingsForm = new FrmSettings();
            settingsForm.Show();
        }
    }
}
