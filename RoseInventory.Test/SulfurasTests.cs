﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RoseInventory.Test
{
    [TestFixture]
    public class SulfurasTests
    {

        [TestCase(4, 5, 4, 5, TestName = "Conjured Positive SellIn")]
        [TestCase(-2, 5, -2, 5, TestName = "Conjured Negative SellIn")]
        public void MoveForwardOneDay(int startingSellIn, int startingQuality, int resultSellIn, int resultQuality)
        {
            Sulfuras sulfuras = new Sulfuras() { SellIn = startingSellIn, Quality = startingQuality };
            sulfuras.MoveForwardOneDay();

            int expectedQuality = sulfuras.Quality;
            int sellin = sulfuras.SellIn;

            Assert.That(sellin, Is.EqualTo(resultSellIn));
            Assert.That(expectedQuality, Is.EqualTo(resultQuality));
        }
    }
}
