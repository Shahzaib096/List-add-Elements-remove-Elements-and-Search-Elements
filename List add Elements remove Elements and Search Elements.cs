using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_add_Elements_remove_Elements_and_Search_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Size of List :");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int> { };
            for(int i=0;i<n;i++)
            {
                Console.Write("Enter Elements {0} :", i);
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("Enter Value You Want To Find :");
            int value = int.Parse(Console.ReadLine());
            int index = numbers.IndexOf(value);
            if(index==-1)
            {
                Console.Write(" Element Not Found");
            }
            else
            {
                Console.Write($"Element {numbers[index]} at index {index}");
            }
            Console.WriteLine();
            foreach(int item in numbers)
            {
                Console.Write(" "+item);
            }
            Console.ReadLine();
        }
    }
}
