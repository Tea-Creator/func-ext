using NUnit.Framework;
using System;

namespace FuncExt.Tests
{
    public class CurryTests
    {
        [Test]
        public void Func_Results_Are_Same()
        {
            Func<int, int, int, int> sum = (x, y, z) => x + y + z;

            Assert.AreEqual(sum(1, 2, 3), sum.Curry()(1)(2)(3));
        }

        [Test]
        public void Func_Curry_Can_Be_Splitted()
        {
            Func<int, int, int, int> sum = (x, y, z) => x + y + z;

            var curry = sum.Curry();

            var five = curry(5);
            var seven = five(7);
            var result = seven(10);

            Assert.AreEqual(5 + 7 + 10, result);
        }
    }
}
