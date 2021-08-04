using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoppingContext soppingContext = new SoppingContext())
            {
                Product milk = new Product() { Category = Enums.categories.Food, Name = "Milk", Pid = 1, Price = 5.90 };
                SoppingList sp1 = new SoppingList() { Lid = 1, Products = new List<Product>() { milk } };
                User user1 = new User() { Name = "Yair Cohen", SoppingLists = new List<SoppingList>() { sp1 }, Uid = 1 };

                soppingContext.Users.Add(user1);
                soppingContext.Products.Add(milk);
                soppingContext.SoppingLists.Add(sp1);
                soppingContext.SaveChanges();


            }





        }

    }
}
