using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountItems
{
    internal class Program
    {
        static void CountItems<T>(List<T> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                bool alreadyCounted = false;
                int count = 1;

                for (int j = 0; j < i; j++)
                {
                    if (items[i].Equals(items[j]))
                    {
                        alreadyCounted = true;
                        break;
                    }
                }

                if (!alreadyCounted)
                {
                    for (int j = i + 1; j < items.Count; j++)
                    {
                        if (items[i].Equals(items[j]))
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{items[i]}: {count}");
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 1, 3, 2, 1 };
            CountItems(numbers);
        }
    }
}
