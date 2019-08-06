using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackThePlanet.UniversityAlgorithms;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSortTest();
        }

        private static void BubbleSortTest()
        {
            var bubbleSort = new BubbleSort();
            bubbleSort.Sort();


            Console.ReadLine();
        }
    }
}
