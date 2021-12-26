using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Repositories;

namespace Accounting.DataLayer.Contex
{
    public class UnitOfWork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();

        private ICustomerRepositories _customerRepositories;
        private GenericRepositories<Accounting> _accountingRepository;
        private GenericRepositories<Login> _loginRepositories;

        public GenericRepositories<Login> LoginRepositories
        {
            get
            {
                if (_loginRepositories==null)
                {
                    _loginRepositories = new GenericRepositories<Login>(db);
                }
                return _loginRepositories;
            }
        }

        public GenericRepositories<Accounting> AccountingRepository
        {
            get
            {
                if (_accountingRepository == null)
                {
                    _accountingRepository = new GenericRepositories<Accounting>(db);
                }
                return _accountingRepository;
            }
        }

        public ICustomerRepositories CustomerRepositories
        {
            get
            {
                if (_customerRepositories == null)
                {
                    _customerRepositories = new CustomerRepositories(db);
                }
                return _customerRepositories;
            }

        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
