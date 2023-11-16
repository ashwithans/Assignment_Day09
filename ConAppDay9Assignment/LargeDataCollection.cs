using System;
using System.Collections.Generic;

namespace ConAppDay9Assignment
{
    public class LargeDataCollection : IDisposable
    {
        private List<int> dataCollection;

        public LargeDataCollection(IEnumerable<int> initialData)
        {
            dataCollection = new List<int>(initialData);
            Console.WriteLine("Initial elements in the collection:");
            AccessElements();
        }

        public void AddElement(int element)
        {
            dataCollection.Add(element);
            Console.WriteLine($"Adding element: {element}");
        }

        public bool RemoveElement(int element)
        {
            bool removed = dataCollection.Remove(element);
            if (removed)
            {
                Console.WriteLine($"Removing element: {element}");
            }
            else
            {
                Console.WriteLine($"Element {element} not found to remove.");
            }
            return removed;
        }

        public void AccessElements()
        {
            Console.WriteLine("Elements in the collection:");
            foreach (var item in dataCollection)
            {
                Console.WriteLine(item);
            }
        }

        public void Dispose()
        {
            dataCollection.Clear();
            dataCollection = null;
            GC.Collect();
        }
    }
}
