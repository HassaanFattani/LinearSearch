using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16[] array = new Int16[100];
            Int16 search, c, number;

            Console.WriteLine("Enter the number of elements in array\n");
            number = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter " + number.ToString() + " numbers\n");

            for (c = 0; c < number; c++)
            {
                array[c] = new Int16();
                array[c] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Enter the number to search\n");
            search = Convert.ToInt16(Console.ReadLine());

            for (c = 0; c < number; c++)
            {
                if (array[c] == search)     /* if required element found */
                {
                    Console.WriteLine("" + search.ToString() + " is present at location " + (c + 1).ToString() +
                    ".\n");
                    break;
                }
            }
            if (c == number)
                Console.WriteLine(search.ToString() + " is not present in array.\n");

            Console.ReadLine();
        }
    }
}
