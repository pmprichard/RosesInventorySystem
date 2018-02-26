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
        [TestCase(4, 5, 3, 6, TestName = "Brie Positive SellIn")]
        [TestCase(-2, 5, -3, 6, TestName = "Brie Negative SellIn")]
        public void AgedBrie(int startingSellIn, int startingQuality, int resultSellIn, int resultQuality)
        {
            AgedBrie agedBrie = new AgedBrie() { SellIn = startingSellIn, Quality = startingQuality };
            agedBrie.MoveForwardOneDay();

            int expectedQuality = agedBrie.Quality;
            int sellin = agedBrie.SellIn;

            Assert.That(sellin, Is.EqualTo(resultSellIn));
            Assert.That(expectedQuality, Is.EqualTo(resultQuality));
        }

        [TestCase(55,50)]
        [TestCase(-15, 0)]
        public void ValidateQuality(int inputQuality, int expectedResult)
        {
            AgedBrie agedBrie = new AgedBrie();
            int actual = agedBrie.ValidateQuality(inputQuality);

            Assert.That(actual, Is.EqualTo(expectedResult));
        }
    }
}
