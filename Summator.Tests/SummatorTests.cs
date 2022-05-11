using NUnit.Framework;
using System;

namespace Summator.Tests
{
    public class SummatorTests
    {
        private Summator summator;
        [OneTimeSetUp]
            public void OneTimeSetUp()
        {
            System.Console.WriteLine("All Test started");
        }

        [SetUp]
        public void SetUp()
        {
            summator = new Summator();
            System.Console.WriteLine("Test started" + DateTime.Now);
        }
        [Test]
        public void Test_Sum_TwoPositiveNumbers()
        {
            long actual = summator.Sum(new int[] { 5, 7, 8, 9, 10 });

            int expected = 39;

            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Sum_MultiplePositiveNumbers()
        {
            long actual = summator.Sum(new int[] { 5, 7 });

            int expected = 12;

            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Sum_OnePositiveNumbers()
        {
            long actual = summator.Sum(new int[] { 5 });

            Assert.That(actual == 5);
        }
        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = summator.Sum(new int[] { -7, -9 });

            Assert.That(actual == -16);
        }
        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = summator.Sum(new int[] { });

            Assert.That(actual == 0);
        }
        [Test]
        public void Test_Sum_BigValuesy()
        {
            long actual = summator.Sum(new int[] { 2000000000, 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(8000000000, actual);

        }
        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
            int actual = Summator.Average(new int[] { 5, 7 });

            int expected = 6;

            Assert.That(expected == actual);
        }

            [Test]

            public void Test_Sum_TwoPositiveNumbersAAA()
            {
                // Arange
                var values = new int[] { 5, 7 };

                int expected = 12;
                //Act 
                long actual = summator.Sum(values);
                //Assert

                Assert.That(expected == actual);
            }

            [Test]

            public void Test_Assertions()
            {
                var values = new int[] { 5, 7 };
                int expected = 12;
                long actual = summator.Sum(values);

                Assert.That(expected, Is.EqualTo(actual));
                Assert.That(expected == actual);
                Assert.AreEqual(expected, actual);

                double percentage = 99.95;
                Assert.That(percentage, Is.InRange(80, 100));

                Assert.That("QA are awesome", Does.Contain("awesome"));

                string date = "7/11/2021";
                Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));

            Assert.That(() => "abv"[10], Throws.TypeOf<IndexOutOfRangeException>());

            }
        
        [TearDown]
        public void TearDown()
        {
            summator = null;
            System.Console.WriteLine("Test ended" + DateTime.Now);
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            System.Console.WriteLine("All Test started");
        }
    }
}
