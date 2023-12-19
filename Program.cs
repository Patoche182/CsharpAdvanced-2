using System;

namespace CsharpAdvanced_2
{

    internal class Program
    {
        public static int[] array1 = new int[4];

        static void Main(string[] args)
        {
            array1[0] = 9;
            array1[1] = 19;
            array1[2] = 2;
            array1[3] = 14;

            Console.WriteLine("array1[0] = {0}", array1[0]);
            Console.WriteLine("array1[1] = {0}", array1[1]);
            Console.WriteLine("array1[2] = {0}", array1[2]);
            Console.WriteLine("array1[3] = {0}", array1[3]);
        }
    }
}