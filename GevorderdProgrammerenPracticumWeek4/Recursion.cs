using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek4
{
    public class Recursion
    {
        /// <summary>
        /// Berekent fibonacci getallen zoals besproken in de les
        /// Fibonacci: 0 1 1 2 3 5 8 13 21 34
        /// </summary>
        /// <param name="n">het hoeveelste fibonacci getal berekent moet worden</param>
        /// <returns>getal n uit de fibonaccie reeks</returns>
        public int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        /// <summary>
        /// calculates the sum of 1/1 + 1/2 + 1/4 + 1/8 + 1/16 + ... + 1/(2^n)
        /// </summary>
        /// <param name="n">defines when the calculation has to stop</param>
        /// <returns>the calculated value</returns>
        public double Row(int n)
        {
            //return n <= 1 ? 1 : (2 / Row(1 - n));
            
            if (n <= 1)
                return 1;
            return 1 / Row(n -1);
        }

        /// <summary>
        /// Calculates power in a simple way
        /// </summary>
        /// <param name="b">base (grondtal)</param>
        /// <param name="e">exponent (macht)</param>
        /// <returns>result of base^exponent</returns>
        public long SimplePow(int b, int e)
        {
            if (e == 0)
                return 1;
            return b * SimplePow(b, e - 1);
        }

        /// <summary>
        /// Calculates power in a fast way
        /// </summary>
        /// <param name="b">base (grondtal)</param>
        /// <param name="e">exponent (macht)</param>
        /// <returns>result of base^exponent</returns>
        public long FastPow(int b, int e)
        {
            if (e == 0)
                return 1;
            return b * FastPow(b, e - 1);
        }

        /// <summary>
        /// Detects if given string s is a palindrome
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>true if s is a palindrome, false otherwise</returns>
        public bool IsPalindroom(string s)
        {
            if (s.Length == 1 || s.Length == 0) //added check for even cases
                return true;
            if (s[0] != s[s.Length - 1])
                return false;

            return IsPalindroom(s.Substring(1, s.Length - 2));
        }

        /// <summary>
        /// calculates the sum of elements of a list filled with integers
        /// </summary>
        /// <param name="list">the input list</param>
        /// <returns>the sum of elements</returns>
        public int Sum(List<int> list)
        {
            if (list.Count == 1)
                return list[0];

            var o = list[0];
            list.Remove(o);
            list[0] += o;

            return Sum(list);
        }

        /// <summary>
        /// Checks if a list of integers is sorted ascending
        /// </summary>
        /// <param name="list">list of integers</param>
        /// <returns>true if the list is sorted ascending</returns>
        public bool IsSorted(List<int> list)
        {
            if (list.Count <= 1)
                return true;

            var x = list[0];
            list.Remove(x);
            var y = list[0];

            if (x > y)
                return false;

            return IsSorted(list);
        }

        /// <summary>
        /// merges two sorted lists into one sorted list
        /// </summary>
        /// <param name="a">sorted list</param>
        /// <param name="b">sorted list</param>
        /// <returns>sorted list</returns>
        public List<int> Merge(List<int> a, List<int> b)
        {
            if (a.Count == 0)
                return b;
            if (b.Count == 0)
                return a;

            var li = new List<int>();

            var ai = a[0];
            var bi = b[0];

            if (ai < bi)
            {
                li.Add(ai);
                a.Remove(ai);
            }
            else
            {
                li.Add(bi);
                b.Remove(bi);
            }

            li.AddRange(Merge(a, b));
            return li;
        }

        /// <summary>
        /// Sorts a list of integers by using merge
        /// </summary>
        /// <param name="list">unsorted list</param>
        /// <returns>sorted list</returns>
        public List<int> MergeSort(List<int> list)
        {
            return list.Count <= 1 ? list : Merge(MergeSort(list.Take(list.Count / 2).ToList()),MergeSort(list.Skip(list.Count / 2).ToList()) );
        }
    }
}
