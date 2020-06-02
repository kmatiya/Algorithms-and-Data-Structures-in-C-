using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresChapter9
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAdresses myIPs = new IPAdresses();
            myIPs.Add("Mike", "192.155.12.1");
            myIPs.Add("David", "192.155.12.2");
            myIPs.Add("Bernica", "192.155.12.3");
            Console.WriteLine("There are " + myIPs.Count + " IP addresses");
            Console.WriteLine("David's ip address: " + myIPs.Item("David"));
            myIPs.Clear();
            Console.WriteLine("There are " + myIPs.Count + " IP addresses");
            KeyValuePair<string, int> mcmillan = new KeyValuePair<string, int>("McMillan", 99);
            Console.WriteLine(mcmillan.Key);
            Console.WriteLine(mcmillan.Value);
            Console.ReadLine();
        }
    }
}
