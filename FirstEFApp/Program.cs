using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using(UserContext db = new UserContext())
            
            {
                User user1 = new User() { Name = "Tom", Age = 23 };
                User user2 = new User() { Name = "Ash", Age = 28 };
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                var Users = db.Users;

                foreach (var user in Users)
                {
                    Console.WriteLine("{0},{ 1}, { 2}" +user.ID,user.Name,user.Age);
                }

            }
            Console.ReadKey();
        }
    }
}
