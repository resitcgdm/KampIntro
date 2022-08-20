using FirstGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameProject.Abstract
{
    public abstract class BaseManager : IGamerService

    {
        List<Gamer> gamers=new List<Gamer>();
        public virtual void Add(Gamer gamer)
        {
            gamers.Add(gamer);
            Console.WriteLine("added to db :"+gamer.FirstName+gamer.LastName);
            
        }

        public void Delete(Gamer gamer)
        {
            gamers.Remove(gamer);
            Console.WriteLine("The name of :"+gamer.FirstName+gamer.LastName+"deleted from db");

            
        }

        public void List()
        {
            Console.WriteLine("----Gamers----");
            foreach (var gmr in gamers)
            {
                Console.WriteLine("Gamers will be listed :"+gmr.Id+gmr.FirstName+gmr.LastName);
                
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Enter id which gamer you want update");
            var a=gamer.Id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Name of gamer: ");
            gamer.FirstName = Console.ReadLine();
            Console.WriteLine("The Last Name of gamer: ");
            gamer.LastName = Console.ReadLine();

            Console.WriteLine("this gamer "+a+"will be updated ");


        }
    }
}
