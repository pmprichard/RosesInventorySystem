using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RoseInventory;


namespace RoseInventory.Test
{
    [TestFixture]
    public class AgedBrieTests
    {
        [TestCase(4, 5, 3, 6)]
        public void AgedBrie(int startingSellIn, int startingQuality, int resultSellIn, int resultQuality)
        {
            AgedBrie agedBrie = new AgedBrie() { SellIn = startingSellIn, Quality = startingQuality };
            agedBrie.MoveForwardOneDay();

            int expectedQuality = agedBrie.Quality;
            int sellin = agedBrie.SellIn;

            Assert.That(sellin, Is.EqualTo(resultSellIn));
            Assert.That(expectedQuality, Is.EqualTo(resultQuality));
        }
    }
}
