using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using The_Prodigal_Son;

namespace UnitTesting
{
    [TestClass]
    public class TestTrainer
    {
        [TestMethod]
        public void TestName()
        {
            var trainer = new Trainer();
            trainer.Name = "Test Trainer";
        }
        
        [TestMethod]
        public void TestUpdateName()
        {
            var trainer = new Trainer();
            var newName = "Updated Name";

            trainer.Name = "Test Trainer";

            trainer.UpdateName("Updated Name");

            Assert.AreEqual(trainer.Name, newName);
        }
    }
}
