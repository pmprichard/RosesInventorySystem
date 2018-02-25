using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseInventory
{
    public class Sulfuras : Item
    {
        public override string ItemType
        {
            get
            {
                return "Sulfuras";
            }
        }

        public override void UpdateSellIn()
        {

        }
        public override void UpdateQuality()
        {
            Quality = ValidateQuality(Quality);
        }
    }
}
