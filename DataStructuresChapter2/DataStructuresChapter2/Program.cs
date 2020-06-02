using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace DataStructuresChapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList grades = new ArrayList();
             grades.Add(100);
             grades.Add(84);
             int position;
             position = grades.Add(77);
             Console.WriteLine("The grade 77 was added at position:" + position);
             int total = 0;
             grades.Insert(1, 99);
             grades.Insert(3, 80);
             double average = 0.0;
             foreach(object grade in grades)
             {
                 total += (int)grade;
             }
             average = total / grades.Count;
             Console.WriteLine("The average grade is:" + average);
             Console.WriteLine("The current capacity of grades is:" + grades.Capacity);
             Console.WriteLine("The number of grades in grades is:" + grades.Count);
             if(grades.Contains(99))
             {

                 grades.Remove(99);
                 Console.WriteLine("99 has been removed from database");

             }
             else
             {
                 Console.Write("Object not in ArrayList.");
             }*/
            /*ArrayList names = new ArrayList();
            names.Add("Mike");
            names.Add("Beata");
            names.Add("Raymond");
            names.Add("Bernica");
            names.Add("Jennifer");
            Console.WriteLine("The original list of names:");
            foreach(object name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            string[] newNames = new string[] { "David", "Michael" };
            ArrayList moreNames = new ArrayList();
            moreNames.Add("Terrill");
            moreNames.Add("Donnie");
            moreNames.Add("Mayo");
            moreNames.Add("Clayton");
            moreNames.Add("Alisa");
            names.InsertRange(0, newNames);
            names.AddRange(moreNames);
            Console.WriteLine("The new list of names: ");
            foreach (object name in names)
            {
                Console.WriteLine(name);
            }

            ArrayList someNames = new ArrayList();
            someNames = names.GetRange(2,4);
            Console.WriteLine("someNames sub-ArrayList: ");
            foreach(object name in someNames)
            {
                Console.WriteLine(name);
            }*/
            ArrayList b = new ArrayList();
            
            MyArrayList grades = new MyArrayList();
            grades.Add(100);
            grades.Add(102);
            grades.Add(321);
            
            Console.WriteLine("Insert succesful:"+ grades.Insert(0,20));
            grades.printArray();
            Console.WriteLine("Count is " + grades.Count);
            Console.WriteLine("Contains: " + grades.Contains(100));
            Console.WriteLine("Reverse the object");
            grades.Reverse();
            grades.printArray();
            
            Console.ReadLine();
        }
    }
}
