using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Contex;
using Accounting.Utility.Convertor;
using Accounting.App.Customer;
using Accounting.ViewModels.Customers;

namespace Accounting.App.Accounting
{
    public partial class frmReport : Form
    {
        public int TypeID = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            if (TypeID == 1)
            {
                this.Text = "گزارش دریافتی ها";
            }
            else
            {
                this.Text = "گزارش پرداختی ها";
            }
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomerViewModels> list = new List<ListCustomerViewModels>();
                list.Add(new ListCustomerViewModels()
                {
                    CustomerId = 0,
                    FullName = "لطفا انتخاب کنید"
                });
                list.AddRange(db.CustomerRepositories.GetNameCustomer());
                cbCustomer.DataSource = list;
                cbCustomer.ValueMember = "CustomerId";
                cbCustomer.DisplayMember = "FullName";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            dgReport.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                DateTime? startDate;
                DateTime? endDate;
                List<DataLayer.Accounting> result = new List<DataLayer.Accounting>();
                if ((int)cbCustomer.SelectedValue != 0)
                {
                    int customerid = int.Parse(cbCustomer.SelectedValue.ToString());
                    result.AddRange(db.AccountingRepository.Get(c => c.TypeID == TypeID && c.CostumerID == customerid));
                }
                else
                {
                    result.AddRange(db.AccountingRepository.Get(c => c.TypeID == TypeID));
                }
                if (txtBDate.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(txtBDate.Text);
                    startDate = DateConverter.ToMiladi(startDate.Value);
                    result = result.Where(r => r.Datetitle >= startDate).ToList();
                }
                if (txtEDate.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(txtEDate.Text);
                    endDate = DateConverter.ToMiladi(endDate.Value);
                    result = result.Where(r => r.Datetitle <= endDate).ToList();
                }
                dgReport.Rows.Clear();
                foreach (var accound in result)
                {
                    string FullName = db.CustomerRepositories.GetFullNameById(accound.CostumerID);
                    dgReport.Rows.Add(accound.ID, FullName, accound.Amuont, Convert.ToDateTime(accound.Datetitle).Toshamsi(),accound.Description);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف مطمین هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    int customerid = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                    db.AccountingRepository.Delete(customerid);
                    db.Save();
                    Filter();
                }
            }
            else
            {
                return;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                frmNewAccounting frm = new frmNewAccounting();
                frm.Id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }

        }

        private void btnPirint_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Description");
            foreach (DataGridViewRow row in dgReport.Rows)
            {
                dtPrint.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString());
            }
            stiReport.Load(Application.StartupPath + "/Report.mrt");
            stiReport.RegData("DT", dtPrint);
            stiReport.Show();
        }
    }
}
