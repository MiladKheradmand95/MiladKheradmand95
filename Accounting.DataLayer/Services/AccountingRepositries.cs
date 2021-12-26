using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;

namespace Accounting.DataLayer.Services
{
    class AccountingRepositries : IAccountingRepositories
    {
        private Accounting_DBEntities _db;

        public AccountingRepositries(Accounting_DBEntities db)
        {
            _db = db;
        }
      
    }
}
