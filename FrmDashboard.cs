using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public FrmDashboard()
        {
            InitializeComponent();
            
        }
        
        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + " ₺";

            //Chart 1 Kodları

            var bankdata = db.Banks.Select(x => new
            {
                BankTitle = x.BankTitle,
                BankBalance = x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankdata)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            // Chart 2 Kodları

            var billData = db.Bills
    .ToList() 
    .Select(x => new
    {
        x.BankTitle,   
        x.BankAmount
    })
    .ToList();

            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (var item in billData.Where(x => x.BankTitle != null))
            {
                series2.Points.AddXY(item.BankTitle, item.BankAmount);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 == 1)
            {
                var elektrikFaturasi=db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y=>y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text= elektrikFaturasi.ToString() + " ₺";
            }

            if (count % 4 == 2)
            {
                var doğalgazFaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = doğalgazFaturasi.ToString() + " ₺";

                if (count % 4 == 3)
                {
                    var suFaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                    lblBillTitle.Text = "Su Faturası";
                    lblBillAmount.Text = suFaturasi.ToString() + " ₺";

                    if (count % 4 == 0)
                    {
                        var internetFaturasi = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                        lblBillTitle.Text = "İnternet Faturası";
                        lblBillAmount.Text = internetFaturasi.ToString() + " ₺";
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
