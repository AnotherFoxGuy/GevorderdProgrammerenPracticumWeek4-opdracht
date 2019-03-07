using NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GevorderdProgrammerenPracticumWeek4.Tests
{
    [TestFixture]
    public class RecursionTest
    {
        [Test]
        public void Example_Fibonacci10Test()
        {
            //Arrange
            var recursion = new Recursion();
            //Act
            var result = recursion.Fib(10);
            //Assert
            Assert.AreEqual(55, result);
        }
                
        [Test]
        public void Example_Fibonacci29Test()
        {
            //Arrange
            var recursion = new Recursion();
            //Act
            var result = recursion.Fib(29);
            //Assert
            Assert.AreEqual(514229, result);
        }

        [Test]
        public void Opdracht02_Row10Test()
        {
            //Arrange
            var recursion = new Recursion();
            //Act
            var result = recursion.Row(10);
            //Assert
            Assert.AreEqual(1.9990234375, result, 0.0000000001);
        }
        
        [Test]
        public void Opdracht02_Row2Test()
        {
            //Arrange
            var recursion = new Recursion();
            //Act
            var result = recursion.Row(2);
            //Assert
            Assert.AreEqual(1.75, result);
        }

        [Test]
        public void Opdracht02_Row20Test()
        {
            //Arrange
            var recursion = new Recursion();
            //Act
            var result = recursion.Row(20);
            //Assert
            Assert.AreEqual(1.9999990463, result, 0.0000000001);
        }
        
        [Test]
        public void Opdracht03_SimplePow3to5Test()
        {
            //Arrange
            var recursion = new Recursion();
            //Act
            var result = recursion.SimplePow(3, 5);
            //Assert
            Assert.AreEqual(243, result);
        }

        [Test]
        public void Opdracht03_SimplePow5to15Test()
        {
            //Arrange
            var recursion = new Recursion();
            //Act
            var result = recursion.SimplePow(5, 15);
            //Assert
            Assert.AreEqual(30517578125, result);
        }

        [Test]
        public void Opdracht04_FastPow3to5Test()
        {
            //Arrange
            var recursion = new Recursion();
            //Act
            var result = recursion.FastPow(3, 5);
            //Assert
            Assert.AreEqual(243, result);
        }

        [Test]
        public void Opdracht04_FastPow5to15Test()
        {
            //Arrange
            var recursion = new Recursion();
            //Act
            var result = recursion.FastPow(5, 15);
            //Assert
            Assert.AreEqual(30517578125, result);
        }

        [Test]
        public void Opdracht05_LepelIsPalindroomTest()
        {
            //Arrange
            var recursion = new Recursion();
            //Act
            var result = recursion.IsPalindroom("lepel");
            //Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Opdracht05_ParterretrapIsPalindroomTest()
        {
            //Arrange
            var recursion = new Recursion();
            //Act
            var result = recursion.IsPalindroom("parterretrap");
            //Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Opdracht05_RaceautoIsPalindroomTest()
        {
            //Arrange
            var recursion = new Recursion();
            //Act
            var result = recursion.IsPalindroom("raceauto");
            //Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void Opdracht06_Sum1234Test()
        {
            //Arrange
            var recursion = new Recursion();
            var list = new List<int> { 1, 2, 3, 4 };
            //Act
            var result = recursion.Sum(list);
            //Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Opdracht06_Sum24681020Test()
        {
            //Arrange
            var recursion = new Recursion();
            var list = new List<int> { 2, 4, 6, 8, 10, 20 };
            //Act
            var result = recursion.Sum(list);
            //Assert
            Assert.AreEqual(50, result);
        }

        [Test]
        public void Opdracht07_IsSortedTest()
        {
            //Arrange
            var recursion = new Recursion();
            var list = new List<int>();
            //Act
            var result = recursion.IsSorted(list);
            //Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Opdracht07_IsSorted1379Test()
        {
            //Arrange
            var recursion = new Recursion();
            var list = new List<int> { 1, 3, 7, 9 };
            //Act
            var result = recursion.IsSorted(list);
            //Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Opdracht07_IsSorted13minus79Test()
        {
            //Arrange
            var recursion = new Recursion();
            var list = new List<int> { 1, 3, -7, 9 };
            //Act
            var result = recursion.IsSorted(list);
            //Assert
            Assert.AreEqual(false, result);
        }

        [Test]
        public void Opdracht08_Merge13791379Test()
        {
            //Arrange
            var recursion = new Recursion();
            var list_a = new List<int> { 1, 3, 7, 9 };
            var list_b = new List<int> { 1, 3, 7, 9 };
            var expectedResult = new List<int> { 1, 1, 3, 3, 7, 7, 9, 9 };
            //Act
            var result = recursion.Merge(list_a, list_b);
            //Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Opdracht08_Merge102030100Test()
        {
            //Arrange
            var recursion = new Recursion();
            var list_a = new List<int> { 10, 20, 30 };
            var list_b = new List<int> { 100 };
            var expectedResult = new List<int> { 10, 20, 30, 100 };
            //Act
            var result = recursion.Merge(list_a, list_b);
            //Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Opdracht08_Merge1020304025Test()
        {
            //Arrange
            var recursion = new Recursion();
            var list_a = new List<int> { 10, 20, 30, 40 };
            var list_b = new List<int> { 25 };
            var expectedResult = new List<int> { 10, 20, 25, 30, 40 };
            //Act
            var result = recursion.Merge(list_a, list_b);
            //Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Opdracht09_MergeSortTest()
        {
            //Arrange
            var recursion = new Recursion();
            var input = new List<int> { };
            var expectedResult = new List<int> { };
            //Act
            var result = recursion.MergeSort(input);
            //Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Opdracht09_MergeSort51829342Test()
        {
            //Arrange
            var recursion = new Recursion();
            var input = new List<int> { 5, 1, 8, 2, 9, 3, 4, 2 };
            var expectedResult = new List<int> { 1, 2, 2, 3, 4, 5, 8, 9 };
            //Act
            var result = recursion.MergeSort(input);
            //Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Opdracht10_MyListGetLast25Test()
        {
            //Arrange
            var recursion = new Recursion();
            var list = new MyList<int>(25);
            //Act
            var result = list.GetLast();
            //Assert
            Assert.AreEqual(25, result);
        }

        [Test]
        public void Opdracht10_MyListGetLast2547135Test()
        {
            //Arrange
            var recursion = new Recursion();
            var list = new MyList<int>(25);
            list.Add(47);
            list.Add(13);
            list.Add(5);
            //Act
            var result = list.GetLast();
            //Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Opdracht11_MyListCountAapNootMiesTest()
        {
            //Arrange
            var recursion = new Recursion();
            var list = new MyList<string>("aap");
            list.Add("noot");
            list.Add("mies");
            list.Add("geen idee wat daarna komt");
            //Act
            var result = list.Count();
            //Assert
            Assert.AreEqual(4, result);
        }
        
        [Test]
        public void Opdracht11_MyListEdgarsTest()
        {
            //Arrange
            var recursion = new Recursion();
            var list = new MyList<string>("aap");
            list.Add("noot");
            list.Add("geen idee wat daarna komt");
            //Act
            var result = list.Count();
            //Assert
            Assert.AreEqual(3, result);
        }
        
        [Test]
        public void Opdracht11_MyListEdgarsTest2()
        {
            //Arrange
            var recursion = new Recursion();
            var list = new MyList<string>("aap");
            list.Add("noot");
            list.Add("mies");
            list.Add("mifvses");
            list.Add("vf");
            list.Add("geen idee wat daarna komt");
            //Act
            var result = list.Count();
            //Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Opdracht12_MyListReverse2547135Test()
        {
            //Arrange
            var recursion = new Recursion();
            var list = new MyList<int>(25);
            list.Add(47);
            list.Add(13);
            list.Add(5);
            //Act
            var result = list.Reverse().GetLast();
            //Assert
            Assert.AreEqual(25, result);
        }
    }
}
