using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepositories
    {
        string GetFullNameById(int customerid);
       
        List<Customers> GetAllCustomers();
        IEnumerable<Customers> GetCustomerFillter(String parameter);
        Customers GetCustomerById(int customerid);
        List<ListCustomerViewModels> GetNameCustomer(string filter = "");
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
    }
}
