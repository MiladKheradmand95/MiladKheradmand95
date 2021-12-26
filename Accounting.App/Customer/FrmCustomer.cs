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
using Accounting.App.Customer;

namespace Accounting.App
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGried();
        }
        private void BindGried()
        {
            DgCustomer.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                DgCustomer.DataSource = db.CustomerRepositories.GetAllCustomers().ToList();
            }
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                DgCustomer.DataSource = db.CustomerRepositories.GetCustomerFillter(TxtFilter.Text).ToList();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            TxtFilter.Text = "";
            BindGried();
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف این مورد مطمین هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DgCustomer.CurrentRow != null)
                {
                    using (UnitOfWork u = new UnitOfWork())
                    {
                        int res = int.Parse(DgCustomer.CurrentRow.Cells["CustomreID"].Value.ToString());
                        u.CustomerRepositories.DeleteCustomer(res);
                        u.Save();
                        BindGried();
                        MessageBox.Show("عملیات حذف با موفقیت انجام شد", "پیام حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("لطفا یک مورد برای حذف انتخاب کنید");
                    return;
                }
            }
            else
                return;

        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmAddOrEditeCustomers f = new FrmAddOrEditeCustomers();
            if (f.ShowDialog()==DialogResult.OK)
            {
                BindGried();
            }
            
        }

        private void BtnEditeCustomer_Click(object sender, EventArgs e)
        {
            if (DgCustomer.CurrentRow!=null)
            {
                FrmAddOrEditeCustomers frm = new FrmAddOrEditeCustomers();
                frm.CustomerId = int.Parse(DgCustomer.CurrentRow.Cells[0].Value.ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGried();
                }
            }
           
        }


    }
}
