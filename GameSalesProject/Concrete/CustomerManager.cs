using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Concrete
{
    public class CustomerManager : ICRUDService<Customer>,ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            if (customer.FirstName != null && customer.LastName != null && customer.NationalityId != null)
            {
                Console.WriteLine(customer.FirstName + " E-devlet login approved");
                return true;
            }
            else
            {
                Console.WriteLine("User not found");
                return false;
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " deleted");
        }

        public void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " added");
        }


        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " updated");
        }
    }
}
