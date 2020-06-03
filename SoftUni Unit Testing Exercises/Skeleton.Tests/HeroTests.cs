using NUnit.Framework;
using Skeleton.FakeItems;
using Skeleton.Interfaces;

namespace Skeleton.Tests
{
    [TestFixture]
    public class HeroTests
    {
        private const string Name = "Martin";

        private Hero systemUnderTest;
        private IWeapon weapon;
        private ITarget target;

        [SetUp]
        public void ReceiveItems()
        {
            weapon = new FakeWeapon();
            target = new FakeTarget();
            systemUnderTest = new Hero(Name, weapon);
        }

        [Test]
        public void HeroGainsExperienceAfterAttackIfTargetDies()
        {
            systemUnderTest.Attack(target);

            Assert.That(systemUnderTest.Experience, Is.EqualTo(20));
            
        }
    }
}
