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

        [TestCase(4, 5, 3, 4, TestName = "Normal Positive SellIn")]
        [TestCase(-2, 5, -3, 3, TestName = "Normal Negative SellIn")]
        [TestCase(1, 5, 0, 4, TestName = "Normal 1 SellIn")]
        [TestCase(0, 5, -1, 3, TestName = "Normal zero SellIn")]
        public void MoveForwardOneDay(int startingSellIn, int startingQuality, int resultSellIn, int resultQuality)
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
