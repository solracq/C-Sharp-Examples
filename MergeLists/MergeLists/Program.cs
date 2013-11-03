using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list
            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);

            // Converting list to array
            int[] array = a.ToArray();

            //creating an array
            int[] b = new int[3];
            b[0] = 5;
            b[1] = 6;
            b[2] = 7;

            //Adding Range
            a.AddRange(b);

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

            int[] array1 = {11,12,13,14,15};
            int[] array2 = { 16, 17, 18, 19, 20 };

            Console.WriteLine("Array 1");
            foreach (int i in array1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Array 2");
            foreach (int i in array2)
            {
                Console.WriteLine(i);
            }

            List<int> list = new List<int>();
            list.AddRange(array1);
            list.AddRange(array2);

            Console.WriteLine("Final List");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            int[] array3 = list.ToArray();
            Console.WriteLine("Final Merged Array");
            foreach (int i in array3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
