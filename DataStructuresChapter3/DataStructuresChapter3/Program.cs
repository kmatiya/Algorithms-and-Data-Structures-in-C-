using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresChapter3
{
    class Program
    {
        static void Main()
        {
            CArray nums = new CArray(10);
            Random rnd = new Random(100);
            for (int i = 0; i < 10; i++)
                nums.Insert((int)(rnd.NextDouble() * 100));
            Console.WriteLine("Before sorting: ");
            nums.DisplayElements();
            Console.WriteLine("During sorting: ");
            nums.BubbleSort();
            Console.WriteLine("After sorting: ");
            nums.DisplayElements();

            CArray nums1 = new CArray(10);
            Random rnd1 = new Random(100);
            for (int i = 0; i < 10; i++)
                nums1.Insert((int)(rnd1.NextDouble() * 100));

            Console.WriteLine("Selection Sorting");
            Console.WriteLine("Before sorting");
            nums1.DisplayElements();
            Console.WriteLine("After sorting: ");
            nums1.SelectionSort();
            nums1.DisplayElements();
            Console.ReadLine();


        }
    }
}
