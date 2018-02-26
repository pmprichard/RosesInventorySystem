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
        }
    }
}
