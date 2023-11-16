using MemoryManagementExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay9Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LargeDataCollection largeCollection = new LargeDataCollection(new int[] { 1, 2, 3, 4, 5 });

            largeCollection.AddElement(6);
            largeCollection.RemoveElement(3);
            largeCollection.AccessElements();
            largeCollection.Dispose();
        }
    }
}
