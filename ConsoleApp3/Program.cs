using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введи любое число");
            //int i = int.Parse(Console.ReadLine());
            //if (i == 0)
            //{
            //    Console.WriteLine("GG");

            //}
            //else
            //{
            //    Console.WriteLine(i * i);

            //}
            //Console.WriteLine("Введи первое число");
            //int k = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введи второе число");
            //int l = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введи третЬье число");
            //int h = int.Parse(Console.ReadLine());
            //if (k > l && k > h)
            //{
            //    Console.WriteLine(k);

            //}
            //else if (l > k && l > h)
            //{
            //    Console.WriteLine(l);
            //}
            //else if (h > l && h > k)
            //{
            //    Console.WriteLine(h);
            //}
            //else
            //{
            //    Console.WriteLine("Числа равны");
            //}
            //Console.WriteLine("Введите значение");
            //var userString = Console.ReadLine();
            //int result;

            //for (int i = 1; i < 4; i++)
            //{
            //    if (int.TryParse(userString,out result))
            //    {
            //        int g = int.Parse(userString);
            //        g *= 3;
            //        if (i == 3)
            //        {
            //            Console.WriteLine(g);
            //        }
            //    }    
            //    else
            //    {
            //        Console.WriteLine(userString);
            //    }

            //}
            //if (int.TryParse(userString, out result))
            //{
            //    Console.WriteLine(int.Parse(userString) *3);


            //}
            //else
            //{

            //    for (int b = 1; b<6; b++)
            //    {
            //        Console.WriteLine(userString);
            //    }
            //}
            //if (int.Parse(userString)
            Console.WriteLine("Введите значение");
            int lenght = int.Parse(Console.ReadLine());
            int[] massiv = new int[lenght];
            Random rnd = new Random();
            for (int i = 0; i<lenght; i++)
            {
                massiv[i] = rnd.Next(0, 101); 
            }

            foreach (int u in massiv)
            {
                Console.Write(u+", ");
            }
            Console.WriteLine();
            Console.WriteLine(massiv[4]);

            Console.ReadKey();

        }
    }
}
