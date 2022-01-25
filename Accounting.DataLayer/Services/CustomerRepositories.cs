using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepositories : ICustomerRepositories
    {
        private Accounting_DBEntities db;

      

        public CustomerRepositories(Accounting_DBEntities contex)
        {
            db = contex;
        }

       
        public string GetFullNameById(int customerid)
        {
            return db.Customers.Find(customerid).FullName;
        }

        public IEnumerable<Customers> GetCustomerFillter(string parameter)
        {
            return db.Customers.Where(c => c.FullName.Contains(parameter) || c.Mobile.Contains(parameter) || c.Email.Contains(parameter));
        }

        //public List<Customer> GetAllCustomer()
        //{
        //    return db.Customers.ToList();
        //}


        public List<ListCustomerViewModels> GetNameCustomer(string filter = "")
        {
            if (filter == "")
            {
               return db.Customers.Select(c => new ListCustomerViewModels()
                    {
                        FullName = c.FullName,
                        CustomerId = c.CustomerID
                    }).ToList();
            }
            return db.Customers.Where(c => c.FullName.Contains(filter)).Select(c => new ListCustomerViewModels()
                {
                    CustomerId = c.CustomerID,
                    FullName = c.FullName
                }).ToList();

        }

        public Customers GetCustomerById(int customerid)
        {
            return db.Customers.Find(customerid);
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var res = GetCustomerById(customerId);
                DeleteCustomer(res);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

       
    }
}
