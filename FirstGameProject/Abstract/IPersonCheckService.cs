using FirstGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameProject.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
