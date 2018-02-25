using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseInventory.Test
{
    [TestFixture]
    public class NormalTests
    {
        [TestCase(4, 5, 3, 6)]
        public void Normal(int startingSellIn, int startingQuality, int resultSellIn, int resultQuality)
        {
            Normal normal = new Normal() { SellIn = startingSellIn, Quality = startingQuality };
            normal.MoveForwardOneDay();

            int expectedQuality = normal.Quality;
            int sellin = normal.SellIn;

            Assert.That(sellin, Is.EqualTo(resultSellIn));
            Assert.That(expectedQuality, Is.EqualTo(resultQuality));
        }
    }
}
