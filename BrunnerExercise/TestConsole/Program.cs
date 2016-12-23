using BrunnerExercise.Item;
using BrunnerExercise.Shopping_Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart sc = new ShoppingCart();
            

            int number = 0;

            do
            {
                Console.WriteLine("Please enter the Item you want to buy");
                int selectItem;
                selectItem = Convert.ToInt32(Console.ReadLine());
                sc.AddItem(selectItem);
                foreach (var product in cartItem)
                {
                    Console.WriteLine(product.ItemId + " " + product.ItemName + " " + product.UnitPrice + " " + product.Quantity);
                }
                Console.WriteLine(sc.GetTotal());
                Console.ReadKey();
            }
            while (number < 5);
        }
    }
}
