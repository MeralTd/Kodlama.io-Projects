using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Concrete
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
