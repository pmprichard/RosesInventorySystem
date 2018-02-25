using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseInventory
{
    public class Conjured : Item
    {
        public override string ItemType
        {
            get
            {
                return "Conjured ";
            }
        }

        public override void UpdateQuality()
        {
            if (SellIn >= 0)
            {
                Quality = Quality - 2;
            }
            if (SellIn < 0)
            {
                Quality = Quality - 4;
            }

            Quality = ValidateQuality(Quality);
        }
    }
}
