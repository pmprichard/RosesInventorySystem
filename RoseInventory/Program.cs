using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = GetData.parseFile();

            foreach (var item in items)
            {
                item.MoveForwardOneDay();
                if (item.ItemType == "NO SUCH ITEM")
                    Console.WriteLine(item.ItemType);
                else
                    Console.WriteLine(item.ItemType + ' ' + item.SellIn + ' ' + item.Quality); 
            }
            Console.ReadLine();


            //Sulfuras sulf = new Sulfuras() {Quality = 5, SellIn = 11  };

            //sulf.MoveForwardOneDay();
            //sulf.MoveForwardOneDay();
            //Console.WriteLine("Quality: " + sulf.Quality + " - SellIn: " + sulf.SellIn);

            //Normal norm = new Normal() { Quality = 6, SellIn = -2 };

            //norm.MoveForwardOneDay();

            //Console.WriteLine("Quality: " + norm.Quality + " - SellIn: " + norm.SellIn);

            //Console.ReadLine();

        }
    }
}
