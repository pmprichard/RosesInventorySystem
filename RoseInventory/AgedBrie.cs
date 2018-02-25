using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseInventory
{
    public class AgedBrie : Item
    {
        public override string ItemType
        {
            get
            {
                return "Aged Brie";
            }
        }

        public override void UpdateQuality()
        {
            Quality = Quality + 1;
            Quality = ValidateQuality(Quality);
        }
    }
}
