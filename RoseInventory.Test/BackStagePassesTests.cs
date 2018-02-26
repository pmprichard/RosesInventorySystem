using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RoseInventory.Test
{
    [TestFixture]
    public class BackStagePassesTests
    {
        [TestCase(15, 5, 14, 5, TestName = "Back Stage greater than 10")]
        [TestCase(8, 5, 7, 7, TestName = "Back Stage between 5 and 10")]
        [TestCase(3, 5, 2, 8, TestName = "Back Stage less than 5")]
        [TestCase(-2, 5, -3, 0, TestName = "Back Stage negative")]
        public void MoveForwardOneDay(int startingSellIn, int startingQuality, int resultSellIn, int resultQuality)
        {
            BackStagePasses backstagepasses = new BackStagePasses() { SellIn = startingSellIn, Quality = startingQuality };
            backstagepasses.MoveForwardOneDay();

            int expectedQuality = backstagepasses.Quality;
            int sellin = backstagepasses.SellIn;

            Assert.That(sellin, Is.EqualTo(resultSellIn));
            Assert.That(expectedQuality, Is.EqualTo(resultQuality));
        }
    }
}
