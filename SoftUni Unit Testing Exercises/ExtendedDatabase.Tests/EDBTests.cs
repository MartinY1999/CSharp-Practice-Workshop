using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ExtendedDatabase;
using ExtendedDatabase.Interfaces;
using ExtendedDatabase.Models;
using NUnit.Framework;

namespace ExtendedDatabase.Tests
{
    [TestFixture]
    public class EDBTests
    {
        private const string Username = "Tristan";
        private const long ID = 66666;
        private IDatabase systemUnderTest;
        private IPerson person;

        [SetUp]
        public void SetUpItems()
        {
            systemUnderTest = new Database();
            person = new Person(ID, Username);
        }

        [Test]
        public void TestConstructor()
        {
            Type type = typeof(Database);
            FieldInfo field = type.GetFields(BindingFlags.Instance |
                                             BindingFlags.NonPublic).First();
            Assert.AreEqual(new List<IPerson>(), field.GetValue(systemUnderTest), "Constructor not working.");
        }

        [Test]
        public void TestAddValidPerson()
        {
            Assert.DoesNotThrow(() => systemUnderTest.Add(person), "Invalid person!");
        }

        [Test]
        public void ThrowWhenAddingAlreadyContainedPeople()
        {
            systemUnderTest.Add(person);

            Assert.Throws<InvalidOperationException>(() => systemUnderTest.Add(person)
                , "Person is added.");
        }

        [Test]
        public void TestRemovingAPerson()
        {
            systemUnderTest.Add(person);

            Assert.DoesNotThrow(() => systemUnderTest.Remove(Username)
                , "Does not contain this person.");
        }

        [Test]
        public void ThrowWhenRemovingFromEmptyList()
        {
            Assert.Throws<InvalidOperationException>(() => systemUnderTest.Remove(Username)
                , "There are people in the list");
        }

        [Test]
        public void TestFindByID()
        {
            systemUnderTest.Add(person);

            Assert.DoesNotThrow(() => systemUnderTest.FindByID(ID), "ID is invalid.");
        }

        [Test]
        public void ThrowWhenInvalidIDIsSearched()
        {
            systemUnderTest.Add(person);

            Assert.Throws<InvalidOperationException>(() => systemUnderTest.FindByID(32)
                , "Person is found.");
        }

        [Test]
        public void ThrowWhenNegativeIDIsGiven()
        {
            systemUnderTest.Add(person);

            Assert.Throws<ArgumentOutOfRangeException>(() => systemUnderTest.FindByID(-333)
                , "Person is found");
        }

        [Test]
        public void TestFindByUsername()
        {
            systemUnderTest.Add(person);

            Assert.DoesNotThrow(() => systemUnderTest.FindByUsername(Username)
                , "Username is invalid.");
        }

        [Test]
        public void ThrowWhenInvalidUsernameIsGiven()
        {
            systemUnderTest.Add(person);

            Assert.Throws<InvalidOperationException>(() => systemUnderTest.FindByUsername("Kok")
                , "Person is found.");
        }

        [Test]
        public void ThrowWhenUsernameParameterIsNull()
        {
            systemUnderTest.Add(person);

            Assert.Throws<ArgumentNullException>(() => systemUnderTest.FindByUsername(null)
                , "Person is found.");
        }
    }
}
