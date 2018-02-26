using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseInventory
{
    public class BackStagePasses : Item
    {
        public override string ItemType
        {
            get
            {
                return "Backstage passes";
            }
        }

        //Sellin is updated before the quality is
        public override void UpdateQuality()
        {
            if (SellIn <= 10 && SellIn > 5)
            {
                Quality = Quality + 2;
            }
            else if (SellIn <= 5 && SellIn >= 0 )
            {
                Quality = Quality + 3;
            }
            else if (this.SellIn < 0)
            {
                Quality = 0;
            }
            Quality = ValidateQuality(Quality);
        }

    }
}
