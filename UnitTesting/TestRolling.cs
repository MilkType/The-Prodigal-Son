using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using The_Prodigal_Son;

namespace UnitTesting
{
    [TestClass]
    public class TestRolling
    {
        [TestMethod]
        public void TestRollDice()
        {
            var r = new Rolling();
            var result = r.RollDice(1, 20);
            Assert.IsTrue(result.Item1 <= 20);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRollDiceZeroCount()
        {
            var r = new Rolling();
            var result = r.RollDice(0, 20);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRollDiceZeroSided()
        {
            var r = new Rolling();
            var result = r.RollDice(1, 0);
        }

        [TestMethod]
        public void TestRollStat()
        {
            var r = new Rolling();
            var result = r.RollStat("");
        }
    }
}