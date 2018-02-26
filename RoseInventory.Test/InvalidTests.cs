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
        [TestCase("NO SUCH ITEM", TestName = "Invalid Item type check")]
        public void MoveForwardOneDay(string expected)
        {
            Invalid invalid = new Invalid();
            invalid.MoveForwardOneDay();

            string actual = invalid.ItemType;
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
