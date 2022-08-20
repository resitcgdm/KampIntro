using FirstGameProject.Abstract;
using FirstGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameProject.Concrete
{
    public class GamerManager : BaseManager

    {


        IPersonCheckService _personCheckService;

        public GamerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_personCheckService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
                Console.WriteLine("will be added"+gamer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }
    }
}