using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private const int AxeAttack = 10;
        private const int AxeDurability = 10;
        private const int DummyHealth = 20;
        private const int ExperienceDrop = 10;
        private const string Name = "Martin";

        private Axe axe;
        private Dummy systemUnderTest;
        private Hero hero;

        [SetUp]
        public void ConstantValuesOfFields()
        {
            axe = new Axe(AxeAttack, AxeDurability);
            systemUnderTest = new Dummy(DummyHealth, ExperienceDrop);
            hero = new Hero(Name, axe);
        }

        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            hero.Attack(systemUnderTest);

            Assert.AreEqual(10, systemUnderTest.Health, "Dummy didn't lose health");
        }

        [Test]
        public void DummyThrowErrorWhenDead()
        {
            systemUnderTest = new Dummy(10, ExperienceDrop);

            hero.Attack(systemUnderTest);

            var ex = Assert.Throws<InvalidOperationException>((() => axe.Attack(systemUnderTest)), "Dummy is not dead.");
            Assert.AreEqual("Dummy is dead.", ex.Message);
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            systemUnderTest = new Dummy(10, ExperienceDrop);

            hero.Attack(systemUnderTest);

            Assert.AreEqual(10, hero.Experience, "Dummy isn't dead.");
        }

        [Test]
        public void AliveDummyCantGiveXP()
        {
            hero.Attack(systemUnderTest);

            Assert.That(hero.Experience, Is.EqualTo(0));
        }
    }
}
