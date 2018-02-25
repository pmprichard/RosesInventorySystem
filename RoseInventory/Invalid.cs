using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseInventory
{
    public class Invalid : Item
    {
        public override string ItemType
        {
            get
            {
                return "NO SUCH ITEM";
            }
        }

        public override void UpdateQuality()
        {
            Quality = 0;
        }
        public override void UpdateSellIn()
        {
            SellIn = 0;
        }
    }
}
