using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresChapter2
{
    class MyArrayList
    {

        int MaxSize = 7;
        int size = 0;
        int capacity;
        object[] myArray;

        public MyArrayList()
        {
            this.myArray = new object[MaxSize];

        }
        public bool Add(object element)
        {
            if (this.size < MaxSize)
            {
                //Since the list is not full, add the item at the end
                this.myArray[this.size] = element;
                //Increase the count and return the new position
                this.size++;

                return true;
            }
            //If the item was not added, return false;
            Console.WriteLine("Item not added in list");
            return false;
        }

        public int Count
        {
            get
            {
                return size;
            }
        }
        public bool Insert(int pos, object itm)
        {
            if(size < MaxSize && pos>=0 && pos<=size)
            {
                for(int i=size;i > pos-1;i--)
                {
                    this.myArray[i + 1] = this.myArray[i];
                }

                this.myArray[pos] = itm;
                this.size++;
                return true;
            }
            return false;
        }
        public bool Contains(object element)
        {
                foreach (object a in myArray)
                {
                    if (a.ToString() == element.ToString())
                    {
                        return true;
                    }                   
                }
            return false;
        }

        public void Clear()
        {
            myArray = null;
            size = 0;
            this.myArray = new object[MaxSize];
        }

        public void Reverse()
        {
            object[] reverseArray = new object[MaxSize];
            int a = 0;
            int b = size;
            for(int i=size; a <= b; i--)
            {
                reverseArray[a] = myArray[i];
                a++;
            }
            myArray = reverseArray;

            
        }
        public void printArray()
        {
            if(size != 0)
            {
                foreach (object a in myArray)
                {
                    Console.WriteLine(a);
                }
            }         
            else
            {
                Console.WriteLine("ArrayList is empty");
            }
        }
    }
}
