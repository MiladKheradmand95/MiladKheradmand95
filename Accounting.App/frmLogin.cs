using Accounting.DataLayer.Contex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmLogin : Form
    {
        public bool isEdite = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Thread thr = new Thread(DoWork);
            thr.Start();

            if (isEdite)
            {
                this.Text = "ویرایش نام کاربری";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var userName = db.LoginRepositories.Get().First();
                    txtUserName.Text = userName.UserName;
                    txtPassword.Text = userName.Password;
                }
                btnOk.Text = "ویرایش";
            }
        }


        public static void DoWork()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                db.LoginRepositories.Get(P => P.UserName == "hasangoli");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (isEdite)
                    {
                        var username = db.LoginRepositories.Get().First();
                        username.Password = txtPassword.Text;
                        username.UserName = txtUserName.Text;
                        db.LoginRepositories.Update(username);
                        db.Save();
                        Application.Restart();
                    }
                    else
                    {
                        if (db.LoginRepositories.Get(l => l.UserName == txtUserName.Text && l.Password == txtPassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("کاربری یافت نشد");
                        }
                    }
                }
            }
        }
    }
}
