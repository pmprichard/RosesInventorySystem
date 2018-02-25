using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseInventory
{
    public abstract class Item
    {
        public int Quality { get; set; }
        public int SellIn { get; set; } 
        public abstract string ItemType { get;  }

        public virtual void UpdateSellIn()
        {
            SellIn = SellIn - 1;
        }

        public abstract void UpdateQuality();

        public  void MoveForwardOneDay()
        {
            //UPdates sellIn before quality
            UpdateSellIn();
            UpdateQuality();
        }
          
        public int ValidateQuality(int quality)
        {
            if (quality > 50)
                return 50;
            if (quality < 0)
                return 0;

            else return quality;
        }
    }
}
