using Accounting.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Contex;

namespace Accounting.Business
{
   public class Account
    {
       public static AccountViewModel ReportFormMain()
       {
           AccountViewModel avm=new AccountViewModel();
           using (UnitOfWork db=new UnitOfWork())
           {
               DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
               DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
               var Recive = db.AccountingRepository.Get(a => a.TypeID == 1 && a.Datetitle >= startDate && a.Datetitle <= endDate).Select(a => a.Amuont).ToList();
               var Pay = db.AccountingRepository.Get(a => a.TypeID == 2 && a.Datetitle >= startDate && a.Datetitle <= endDate).Select(a => a.Amuont).ToList();
               avm.Recive=Recive.Sum();
               avm.Pay=Pay.Sum();
               avm.Mandeh=(Recive.Sum()-Pay.Sum());
           }
           return avm;
       }
    }
}
