using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.App.Customer;
using Accounting.App.Accounting;
using Accounting.App;
using Accounting.Utility.Convertor;
using Accounting.DataLayer.Contex;
using Accounting.ViewModels.Account;
using Accounting.Business;

namespace Accounting.App
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer f = new FrmCustomer();
            f.ShowDialog();
        }

        private void BtnNewAccounting_Click(object sender, EventArgs e)
        {
            frmNewAccounting f = new frmNewAccounting();
            f.ShowDialog();
        }

        private void btnReportPay_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.TypeID = 2;
            frm.ShowDialog();
        }

        private void btnRecive_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.TypeID = 1;
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmlogin = new frmLogin();
            if (frmlogin.ShowDialog()==DialogResult.OK)
            {
                lblDate.Text = DateConverter.Toshamsi(DateTime.Now);
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
                Report();
            }
            else
            {
                Application.Exit();
            }
        }

        private void Report()
        {
            AccountViewModel report = Account.ReportFormMain();
            lblPay.Text = report.Pay.ToString("#,0");
            lblRecive.Text = report.Recive.ToString("#,0");
            lblMandeh.Text = report.Mandeh.ToString("#,0");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        
        private void تنظیماتورودیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.isEdite = true;
            frm.ShowDialog();
        }

    }
}
