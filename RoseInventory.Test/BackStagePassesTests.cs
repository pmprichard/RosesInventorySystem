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
        [TestCase(4, 5, 3, 6)]
        public void BackStagePasses(int startingSellIn, int startingQuality, int resultSellIn, int resultQuality)
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
