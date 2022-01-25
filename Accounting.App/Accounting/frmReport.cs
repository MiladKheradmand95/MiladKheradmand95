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
using Accounting.Utility.Convertor;

namespace Accounting.App.Accounting
{
    public partial class frmReport : Form
    {
        public DateTime dt;
        public int TypeID = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            chTodey.Checked = true;
            groupBox2.Enabled = false;
            RbCurrentAccount.Checked = true;
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
            //Filter();
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
                if (RbCurrentAccount.Checked == true)
                {
                    result = result.Where(r => r.Status == false).ToList();
                    groupBox2.Enabled = true;
                    chTodey.Checked = true;
                    TarikhTasvih.Enabled = false;
                }
                else if(RbSettlmentAccount.Checked==true)
                {
                    result = result.Where(r => r.Status == true).ToList();
                    groupBox2.Enabled = false;
                }
                else if (RbAllAccount.Checked == true)
                {
                    groupBox2.Enabled = true;
                }
                dgReport.Rows.Clear();
                lblSum.Text = "0";
                foreach (var accound in result)
                {
                    string amount = accound.Amuont.ToString();
                    if (amount.Length > 3)
                    {
                        int count = amount.Length / 3;
                        int index = amount.Length;
                        for (int i = amount.Length; i > 3; i = i - 3)
                        {
                            index = index - 3;
                            amount = amount.Insert(index, ",");
                        }
                    }
                    string d = "";
                    if (accound.SettlmentDate != null)
                    {
                        d = Convert.ToDateTime(accound.SettlmentDate).Toshamsi();
                    }
                    string FullName = db.CustomerRepositories.GetFullNameById(accound.CostumerID);
                    dgReport.Rows.Add(accound.ID, FullName, amount, Convert.ToDateTime(accound.Datetitle).Toshamsi(), accound.Description, accound.Status, d);
                    lblSum.Text = (Convert.ToDecimal(lblSum.Text.Replace(",", "")) + Convert.ToDecimal(amount.Replace(",", ""))).ToString("#,0");
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
            dtPrint.Columns.Add("SettlmentDate");
            foreach (DataGridViewRow row in dgReport.Rows)
            {
                dtPrint.Rows.Add(
                    row.Cells[1].Value.ToString().Replace(",",""),
                    row.Cells[2].Value.ToString().Replace(",", ""),
                    row.Cells[3].Value.ToString().Replace(",", ""),
                    row.Cells[4].Value.ToString().Replace(",", ""),
                    row.Cells[6].Value.ToString().Replace(",", ""));
            }
            stiReport.Load(Application.StartupPath + "/Report.mrt");
            stiReport.RegData("DT", dtPrint);
            stiReport.Show();
        }

        private void BtnSettlment_Click(object sender, EventArgs e)
        {
            if (dgReport.SelectedRows.Count == 1 && dgReport.CurrentRow.Cells[6].Value.ToString()=="")
            {
                if (MessageBox.Show("آیا از تسویه مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var account = db.AccountingRepository.GetById(int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString()));
                        if (TarikhTasvih.Text == "    /  /")
                        {
                            account.SettlmentDate = dt;
                        }
                        else
                        {
                            account.SettlmentDate = DateConverter.ToMiladi(Convert.ToDateTime(TarikhTasvih.Text));
                        }
                        account.Status = true;
                        db.AccountingRepository.Update(account);
                        db.Save();
                        TarikhTasvih.Text = "";
                        Filter();
                    }
                }
            }
            else
            {
                MessageBox.Show("در انتخاب مورد برای تسویه دقت کن","اخطار",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ChTodey_CheckedChanged(object sender, EventArgs e)
        {
            if (chTodey.Checked == true)
            {
                TarikhTasvih.Enabled = false;
            }
            else
            {
                TarikhTasvih.Enabled = true;
            }
        }
    }
}
