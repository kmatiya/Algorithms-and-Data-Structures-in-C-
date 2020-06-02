using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataStructuresChapter4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            managementEntities database = new managementEntities();
            var a = database.Employees;
            //double[] myArray = new double[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
            //double binarySearchedPosition = Array.BinarySearch(myArray, 11);
            //Console.WriteLine("Position =" + binarySearchedPosition);
            Console.WriteLine("The following is the list of all the employees in the managment database");
            foreach(var p in a)
            {
                Console.WriteLine(p.EmployeeId + " " + p.Name + " " + p.Gender + " " + p.City + " " + p.Department.Name);
            }

            Console.ReadLine();
        }
    }
}
