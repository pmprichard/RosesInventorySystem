using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseInventory
{
    class GetData
    {
        public static List<Item> parseFile()
        {
            var reader = new StreamReader(File.OpenRead(@"..\..\Input.csv"));
            List<Item> items = new List<Item>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                Item item;
                switch (values[0])
                {
                    case "Normal Item":
                        item = new Normal()
                        {
                            SellIn = Convert.ToInt32(values[1]),
                            Quality = Convert.ToInt32(values[2])
                        };
                        break;
                    case "Aged Brie":
                         item = new AgedBrie()
                        {
                            SellIn = Convert.ToInt32(values[1]),
                            Quality = Convert.ToInt32(values[2])
                        };
                        break;
                    case "Backstage passes":
                        item = new BackStagePasses()
                        {
                            SellIn = Convert.ToInt32(values[1]),
                            Quality = Convert.ToInt32(values[2])
                        };
                        break;
                    case "Sulfuras":
                        item = new Sulfuras()
                        {
                            SellIn = Convert.ToInt32(values[1]),
                            Quality = Convert.ToInt32(values[2])
                        };
                        break;
                    case "Conjured":
                        item = new Conjured()
                        {
                            SellIn = Convert.ToInt32(values[1]),
                            Quality = Convert.ToInt32(values[2])
                        };
                        break;
                    default:
                        item = new Invalid
                        {
                            SellIn = Convert.ToInt32(values[1]),
                            Quality = Convert.ToInt32(values[2])
                        };
                        break;

                }
                items.Add(item);
            }
            return items;
        }
    }
}
