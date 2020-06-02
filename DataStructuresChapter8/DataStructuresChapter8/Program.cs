using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DataStructuresChapter8
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex("the");
            string str1 = "the quick brown fox jumped over the lazy dog";
            /*Match matchSet;
            int matchPos;
            matchSet = reg.Match(str1);
            if(matchSet.Success)
            {
                matchPos = matchSet.Index;
                Console.WriteLine("Found match at position: " + matchPos);
            }*/
            MatchCollection matchSet;
            matchSet = reg.Matches(str1);
            if(matchSet.Count > 0)
            {
                foreach(Match aMatch in matchSet)
                {
                    Console.WriteLine("Found a match at: " + aMatch.Index);
                }
            }

            Console.ReadLine();
        }
    }
}
