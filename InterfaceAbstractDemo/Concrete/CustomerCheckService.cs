using InterfaceAbstractDemo.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckService : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
           
        }
    }
}
