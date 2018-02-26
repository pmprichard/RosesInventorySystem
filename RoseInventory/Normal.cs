using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseInventory
{
    public  class Normal : Item
    {
        public override string ItemType
        {
            get
            {
                return "Normal Item";
            }
        }

        //Sellin is updated before the quality is
        public override void UpdateQuality()
        {
            if (SellIn >= 0)
            {
                Quality = Quality - 1;
            }
            if (SellIn < 0)
            {
                Quality = Quality - 2;
            }
            Quality = ValidateQuality(Quality);
        }
    }
}
