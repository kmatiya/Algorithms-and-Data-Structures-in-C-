using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataStructuresChapter1
{
    class Chapter1
    {
        static void Main(string[] args)
        {
            Collection names = new Collection();
            names.Add("David");
            names.Add("Bernica");
            names.Add("Raymomd");
            names.Add("Clayton");
            foreach(object name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Number of names: "+ names.Count());
            names.Remove("Raymond");
            Console.WriteLine("Number of names: " + names.Count());
            names.Clear();
            Console.WriteLine("Number of names: " + names.Count());
            Console.ReadLine();
            
        }
    }
}
