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


            Console.WriteLine("Initial elements in the collection:");
            largeCollection.AccessElements();

            Console.Write("Enter an element to add: ");
            int elementToAdd = int.Parse(Console.ReadLine());
            Console.WriteLine($"Adding element: {elementToAdd}");
            largeCollection.AddElement(elementToAdd);

            Console.Write("Enter an element to remove: ");
            int elementToRemove = int.Parse(Console.ReadLine());
            Console.WriteLine($"Removing element: {elementToRemove}");
            largeCollection.RemoveElement(elementToRemove);

            Console.WriteLine("Elements in the collection after modifications:");
            largeCollection.AccessElements();

            largeCollection.Dispose();
            Console.ReadKey();
        }
    }
}
