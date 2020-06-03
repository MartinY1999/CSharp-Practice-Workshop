using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private const int AxeAttack = 10;
        private const int AxeDurability = 10;
        private const int DummyHealth = 10;
        private const int ExperienceDrop = 10;

        private Axe systemUnderTest;
        private Dummy dummy;

        [SetUp]
        public void ConstantValuesOfFields()
        {
            systemUnderTest = new Axe(AxeAttack, AxeDurability);
            dummy= new Dummy(DummyHealth, ExperienceDrop);
        }

        [Test]
        public void AxeLosesDurabilityDuringAttack()
        {
            systemUnderTest.Attack(dummy);

            Assert.AreEqual(9, systemUnderTest.DurabilityPoints, "Axe Durability doesn't change after attack");
        }

        [Test]
        public void AxeAttackWhenBroken()
        {
            systemUnderTest = new Axe(1, 1);

            systemUnderTest.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() => systemUnderTest.Attack(dummy), "Axe is broken");
        }
    }
}
