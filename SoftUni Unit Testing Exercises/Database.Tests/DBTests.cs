using System;
using System.Linq;
using Database.FakeItems;
using NUnit.Framework;

namespace Database.Tests
{
    [TestFixture]
    public class DBTests
    {
        private IDatabase database;

        [SetUp]
        public void SetUpItems()
        {
            database = new FakeCorrectDatabase();
        }

        [Test]
        public void TestDatabaseConstructor()
        {
            Assert.Throws<InvalidOperationException>(() => new Database(1, 2, 3, 4)
                , "Database is in correct format");
        }

        [Test]
        public void TestAddingToDatabase()
        {
            database.Remove();

            Assert.DoesNotThrow(() => database.Add(33), "Array is full");
        }

        [Test]
        public void TestAddingToFullDatabase()
        {
            Assert.Throws<InvalidOperationException>(() => database.Add(33), "Array is not full.");
        }

        [Test]
        public void TestRemovingFromDatabase()
        {
            Assert.DoesNotThrow(() => database.Remove(), "Database is empty.");
        }

        [Test]
        public void RemovingFromtEmptyDatabase()
        {
            for (int i = 0; i <= 15; i++)
            {
                database.Remove();
            }

            Assert.Throws<InvalidOperationException>(() => database.Remove(), "Database is not empty.");
        }

        [Test]
        public void TestFetchingADatabase()
        {
            database.Remove();
            database.Remove();
            database.Remove();
            database.Add(35);
            int?[] copy = database.Fetch();

            Assert.AreEqual(database.Integers.Where(x => x != null).ToArray().Length
                , copy.Length, "Fetch got wrong");
        }
    }
}
