using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Contex;
using Accounting.ViewModels.Customers;
using ValidationComponents;
using Accounting.DataLayer.Services;
using Accounting.Utility.Convertor;


namespace Accounting.App.Customer
{
    public partial class frmNewAccounting : Form
    {
        public int Id = 0;
        public frmNewAccounting()
        {
            InitializeComponent();
        }

        private void frmNewAccounting_Load(object sender, EventArgs e)
        {
            dgCustomer.AutoGenerateColumns = false;
            checkBox1.Checked = true;
            txtDate.Enabled = labelX5.Enabled = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomer.DataSource = db.CustomerRepositories.GetNameCustomer();
                FillTextBoxName();
                if (Id != 0)
                {
                    var accound = db.AccountingRepository.GetById(Id);
                    txtAmount.Text = accound.Amuont.ToString();
                    txtDescription.Text = accound.Description;
                    txtName.Text = db.CustomerRepositories.GetFullNameById(accound.CostumerID);
                    if (accound.TypeID == 1)
                    {
                        rdRecive.Checked = true;
                    }
                    else
                    {
                        rdPay.Checked = true;
                    }
                    this.Text = ".ویرایش";
                    btnSave.Text = "ویرایش";
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgCustomer.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomer.DataSource = db.CustomerRepositories.GetNameCustomer(txtFilter.Text);
            }
        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillTextBoxName();
        }

        private void FillTextBoxName()
        {
            txtName.Text = dgCustomer.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rdRecive.Checked || rdPay.Checked)
                {

                    DataLayer.Accounting account = new DataLayer.Accounting();
                    account.Status = false;
                    DateTime? startDate;
                    if (txtDate.Text == "    /  /")
                    {
                        account.CostumerID = int.Parse(dgCustomer.CurrentRow.Cells[0].Value.ToString());
                        account.Amuont =Convert.ToDecimal(txtAmount.Text.Replace(",", ""));
                        account.TypeID = (rdRecive.Checked) ? 1 : 2;
                        account.Datetitle = DateTime.Now;
                        account.Description = txtDescription.Text;
                    }
                    else
                    {
                        startDate = Convert.ToDateTime(txtDate.Text);
                        startDate = DateConverter.ToMiladi(startDate.Value);
                        account.CostumerID = int.Parse(dgCustomer.CurrentRow.Cells[0].Value.ToString());
                        account.Amuont = Convert.ToDecimal(txtAmount.Text.Replace(",", ""));
                        account.TypeID = (rdRecive.Checked) ? 1 : 2;
                        account.Datetitle = startDate;
                        account.Description = txtDescription.Text;
                    }
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (Id == 0)
                        {
                            db.AccountingRepository.Insert(account);
                        }
                        else
                        {
                            account.ID = Id;
                            db.AccountingRepository.Update(account);
                        }
                        db.Save();
                    }
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("لطفا نوع تراکنش را انتخاب کنید");
                }
            }
        }
        //public DataLayer.Accounting GenericRepositories { get; set; }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtDate.Enabled = labelX5.Enabled = !checkBox1.Checked;
        }

        private void Txttest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) >= 48 && Convert.ToInt16(e.KeyChar) <= 57) || Convert.ToInt16(e.KeyChar) == 8)
            {

            }
            else
            {
                e.KeyChar = Convert.ToChar(Keys.None);
            }
            if (e.KeyChar == '\b')
            {
                //e.Handled = true;
                return;
            }
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            string text = txtAmount.Text.Replace(",", "");
            if (text.Length > 3)
            {

                int count = text.Length / 3;
                int index = text.Length;
                for (int i = text.Length;i> 3; i=i-3)
                {
                        index = index - 3;
                        text = text.Insert(index, ",");
                }
                txtAmount.Text = text;
                txtAmount.SelectionStart = txtAmount.Text.Length;
                txtAmount.SelectionLength = 0;
            }
        }
    }
}
