using System;

namespace CsharpAdvanced_2
{

    internal class Program
    {
        public static int[] array1 = new int[] {14, 12, 51, 95};
        public static int[] array1bis = new int[4];
        public static int[,] array2 = new int[2,3];
        public static int[,] array3 = { { 11, 22, 33 }, { 54, 1001, 9 } };

        static void Main(string[] args)
        {
            //array1[0] = 9;
            //array1[1] = 19;
            //array1[2] = 2;
            //array1[3] = 14;

            Console.WriteLine("Valeurs de Array1 :");

            foreach (int i in array1)
            {
                Console.WriteLine("i = {0}", i);
            }

            Console.WriteLine("Valeurs de Array3 :");

            //foreach (int i in array3)
            //{
            //    Console.WriteLine("i = {0}", i);
            //}

            Console.WriteLine("Nombre dimension de array3 = {0}", array3.Rank); // Connaitre le nombres de dimension d'un tableau
            
            Console.WriteLine("array3[0,2] = {0}", array3[0,2]);

            for (int i = 0; i < array3.Rank; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Array3[{0},{1}] = {2}", i, j, array3[i, j]);
                }
            }

            Console.WriteLine("array3 Lenght = {0}", array3.Length);
            array1bis = (int[])array1.Clone();

            //Console.WriteLine("array1[0] = {0}", array1[0]);
            //Console.WriteLine("array1[1] = {0}", array1[1]);
            //Console.WriteLine("array1[2] = {0}", array1[2]);
            //Console.WriteLine("array1[3] = {0}", array1[3]);
        }
    }
}