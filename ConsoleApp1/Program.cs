using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // create and fill array
            int[] array = new int[4];           
            for (int i = 0; i < 4; i++)
            {
                array[i] = random.Next(-10, 10);
                Console.Write(array[i] + " ");
            }

            // find index of first negative element
            int index_negative = 0;
            for (int i = 0; i < 4; i++)
            {
                if (array[i] < 0)
                {
                    index_negative = i;
                    break;
                }
                else
                {
                    continue;
                }
            }

            // find index of last positive element
             int index_positive = 0;
            for (int i = 4 - 1; i > 0; i--)
            {
                if (array[i] > 0)
                {
                    index_positive = i;
                    break;
                }
                else
                {
                    continue;
                }
            }

            int buffer;
            buffer = array[index_positive];
            array[index_positive] = array[index_negative];
            array[index_negative] = buffer;

            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write(array[i] + " ");
            }





        }
    }
}
