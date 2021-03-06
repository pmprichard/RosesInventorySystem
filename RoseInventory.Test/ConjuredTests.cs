﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RoseInventory.Test
{
    [TestFixture]
    public class ConjuredTests
    {
        [TestCase(4, 5, 3, 3, TestName = "Conjured Positive SellIn")]
        [TestCase(-2, 5, -3, 1, TestName = "Conjured Negative SellIn")]
        public void MoveForwardOneDay(int startingSellIn, int startingQuality, int resultSellIn, int resultQuality)
        {
            Conjured conjured = new Conjured() { SellIn = startingSellIn, Quality = startingQuality };
            conjured.MoveForwardOneDay();

            int expectedQuality = conjured.Quality;
            int sellin = conjured.SellIn;

            Assert.That(sellin, Is.EqualTo(resultSellIn));
            Assert.That(expectedQuality, Is.EqualTo(resultQuality));
        }
    }
}
