using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RoseInventory.Test
{
    [TestFixture]
    public class InvalidTests
    {
        [TestCase(4, 5, 3, 6)]
        public void Invalid(int startingSellIn, int startingQuality, int resultSellIn, int resultQuality)
        {
            Invalid invalid = new Invalid() { SellIn = startingSellIn, Quality = startingQuality };
            invalid.MoveForwardOneDay();

            int expectedQuality = invalid.Quality;
            int sellin = invalid.SellIn;

            Assert.That(sellin, Is.EqualTo(resultSellIn));
            Assert.That(expectedQuality, Is.EqualTo(resultQuality));
        }
    }
}
