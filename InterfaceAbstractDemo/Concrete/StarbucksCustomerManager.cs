using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _personCheckService;
    public StarbucksCustomerManager(ICustomerCheckService personCheckService)
    {
        _personCheckService = personCheckService;
    }

      // starbucks da da nero da da aynı şeyi yapacagımız için veritabanına kaydı aynı oldugu icin
      // interface yerine abstract sınıf kullanıcaz(abstract:Yani aynı kodu yazacagımız aynı şeyi isteyenler için
      // bir abstract sınıf oluşturulur ve işlemi yapıcak interface inherit ederiz.)

    
        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
            
            
        }

       
    }
}
