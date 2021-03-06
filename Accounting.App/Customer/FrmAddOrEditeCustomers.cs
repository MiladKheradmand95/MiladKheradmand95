using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ValidationComponents;
using Accounting.DataLayer;
using Accounting.DataLayer.Contex;

namespace Accounting.App.Customer
{
    public partial class FrmAddOrEditeCustomers : Form
    {
        public int CustomerId = 0;
        public FrmAddOrEditeCustomers()
        {
            InitializeComponent();
        }

        private void BtnBrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                PicCustomer.ImageLocation = open.FileName;

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (BaseValidator.IsFormValid(this.components))
            {
                string res = PicCustomer.ImageLocation;
                if (res != null)
                {
                    string imageName = Guid.NewGuid() + Path.GetExtension(res);
                    string path = Application.StartupPath + "/Images/";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    PicCustomer.Image.Save(path + imageName);
                    Customers customer = new Customers()
                    {
                        FullName = TxtName.Text,
                        Mobile = TxtMobile.Text,
                        Address = TxtAddres.Text,
                        Email = TxtEmail.Text,
                        CustomerImage = imageName

                    };
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (CustomerId == 0)
                        {
                            db.CustomerRepositories.InsertCustomer(customer);
                        }
                        else
                        {
                            customer.CustomerID = CustomerId;
                            db.CustomerRepositories.UpdateCustomer(customer);
                        }
                        db.Save();
                    }
                }
                else
                {
                    Customers customer = new Customers()
                    {
                        FullName = TxtName.Text,
                        Mobile = TxtMobile.Text,
                        Address = TxtAddres.Text,
                        Email = TxtEmail.Text,
                        CustomerImage = "no-profile-image.png"

                    };
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (CustomerId == 0)
                        {
                            db.CustomerRepositories.InsertCustomer(customer);
                        }
                        else
                        {
                            customer.CustomerID = CustomerId;
                            db.CustomerRepositories.UpdateCustomer(customer);
                        }
                        db.Save();
                    }
                }



                DialogResult = DialogResult.OK;
            }
        }

        private void FrmAddOrEditeCustomers_Load(object sender, EventArgs e)
        {
            PicCustomer.Image = Image.FromFile(Application.StartupPath + "/Images/no-profile-image.png");
            if (CustomerId != 0)
            {
                this.Text = "ویرایش";
                BtnSave.Text = "ویرایش";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var customer = db.CustomerRepositories.GetCustomerById(CustomerId);
                    TxtName.Text = customer.FullName;
                    TxtMobile.Text = customer.Mobile;
                    TxtEmail.Text = customer.Email;
                    TxtAddres.Text = customer.Address;
                    PicCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
                }
            }
        }

        private void TxtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) >= 48 && Convert.ToInt16(e.KeyChar) <= 57) || Convert.ToInt16(e.KeyChar) == 8)
            {

            }
            else
            {
                e.KeyChar = Convert.ToChar(Keys.None);
            }
        }
    }
}
