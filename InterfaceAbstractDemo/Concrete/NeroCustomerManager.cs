using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager

    {
        public NeroCustomerManager(MernisServiceAdapter mernisServiceAdapter)
        {
        }
    }
}
