using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace IteratorTest.Tests
{
    [TestFixture]
    public class IteratorTests
    {
        private const string CreationCommand = "Create Tristan CuckBoy Tedka";
        private ListIterator systemUnderTest;
        private ListIterator iterator;

        [SetUp]
        public void SetUpItems()
        {
            systemUnderTest = ListIterator.Create(CreationCommand);
            iterator = new ListIterator();
        }

        [Test]
        public void TestConstructorWithValidInfo()
        {
            Assert.DoesNotThrow(() => iterator = ListIterator.Create(CreationCommand)
                , "Invalid info");
        }

        [Test]
        public void TestConstructorWithInvalidInfo()
        {
            Assert.Throws<ArgumentNullException>(() => iterator = ListIterator.Create(null)
                , "Iterator was created.");
        }

        [Test]
        public void TestMoveMethod()
        {
            bool result = systemUnderTest.Move();

            Assert.AreEqual("True", result.ToString(), "Expect To Move In Right Direction.");
        }

        [Test]
        public void TestMoveMethodAtTheEndOfTheCollection()
        {
            Assert.IsFalse(iterator.Move(), "List is not empty.");
        }

        [Test]
        public void TestHasNextMethod()
        {
            bool result = systemUnderTest.Move();

            Assert.AreEqual("True", result.ToString(), "We are at the end of the collection.");
        }

        [Test]
        public void TestHasNextMethodAtEndOfCollection()
        {
            Assert.IsFalse(iterator.HasNext(), "List is not empty.");
        }

        [Test]
        public void TestPrintMethod()
        {
            Assert.DoesNotThrow(() => systemUnderTest.Print(), "Empty collection.");
        }

        [Test]
        public void TestPrintMethodWithEmptyCollection()
        {
            Assert.Throws<InvalidOperationException>(() => iterator.Print()
                , "Collection is not empty");
        }
    }
}
