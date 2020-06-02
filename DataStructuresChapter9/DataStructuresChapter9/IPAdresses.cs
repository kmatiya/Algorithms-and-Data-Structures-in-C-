using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresChapter9
{
    class IPAdresses:DictionaryBase
    {
        public IPAdresses()
        {

        }
        public void Add(string name,string ip)
        {
            base.InnerHashtable.Add(name, ip);
        }
        public string Item(string name)
        {
            return base.InnerHashtable[name].ToString();
        }
        public void Remove(string name)
        {
            base.InnerHashtable.Remove(name);
        }
    }
}
