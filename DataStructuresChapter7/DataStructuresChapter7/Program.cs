using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresChapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Mike,McMillan,3000,W. Scenic,North Little Rock,AR,72118";
            string[] sdata;
            char[] delimeter = new char[] { ',' };
            sdata = data.Split(delimeter);
            foreach (string word in sdata)
            {
                Console.Write(word + " ");
            }
            string joined;
            joined = String.Join(",", sdata);
            Console.Write(joined);
            string s1 = "foobar";
            string s2 = "foobar";
            if(s1.Equals(s2))
            {
                Console.WriteLine("\nThey are the same.");
            }
            else
            {
                Console.WriteLine("They are not the same");
            }
            Console.WriteLine("\n\n\nStringBuilder Class");
            StringBuilder stBuff = new StringBuilder("Ken Thompson");
            Console.WriteLine("Length of stBuff3: " + stBuff.Length);
            Console.WriteLine("Capacity of stBuff3: " + stBuff.Capacity);
            Console.WriteLine("Maximum capacity of stBuff3: " + stBuff.MaxCapacity);
            Console.ReadLine();
        }
    }
}
