using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresChapter16
{
    class Vertex
    {
        public bool wasVisted;
        public string label;
        public Vertex(string label)
        {
            this.label = label;
            this.wasVisted = false;
        }
    }
}
