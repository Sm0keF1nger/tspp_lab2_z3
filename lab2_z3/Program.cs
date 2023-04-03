using System;
using System.Security.Cryptography.X509Certificates;

namespace lab2_z3
{
    public class Program
    {


        static public int[] Massive(int length)
        {
            int[] b = new int[length];

            while (true)
            {
                try
                {
                    Console.WriteLine("Виберіть спосіб розрахунку\n 1: Рандомайзер 2: Самостійний ввід даних");
                    string InsertSwitch = Console.ReadLine();
                    int SwitchNum = int.Parse(InsertSwitch);

                    if (SwitchNum != 1 && SwitchNum != 2)
                    {
                        throw new FormatException();
                    }

                    switch (SwitchNum)
                    {
                        case 1:
                            b = new int[length];

                            Random aRand = new Random();

                            for (int i = 0; i < length; i++)
                            {
                                b[i] = aRand.Next(-100, 101);
                            }
                            Console.WriteLine("Введений масив:");
                            var str = string.Join(" ", b);
                            Console.WriteLine(str);
                            break;
                        case 2:
                            b = new int[length];

                            for (int i = 0; i < length; i++)
                            {
                                Console.WriteLine($"Введiть число масива під номером {i + 1}: ");
                                string insertNum = Console.ReadLine();
                                int MassNum = int.Parse(insertNum);
                                b[i] = MassNum;
                            }
                            Console.WriteLine("Введений масив:");
                            var st = string.Join(" ", b);
                            Console.WriteLine(st);
                            break;
                    }
                    return b;
                    break;
                }

                catch(FormatException)
                {
                    Console.WriteLine("Некоректнi данi, спробуйте ще");
                }

            }

            
        }

        static public int Sum(int []b)
        {
            int minIndex = 0;
            int minElement = b[0];
            for (int i = 1; i < b.Length; i++)
            {
                if (b[i] < minElement)
                {
                    minIndex = i;
                    minElement = b[i];
                }
            }

            int sum = 0;
            for (int i = minIndex + 1; i < b.Length; i++)
            {
                sum += b[i];
            }
            Console.WriteLine($"Сума елементів масиву після мінімального = {sum}");
            return sum;
        }

        static public double Dob(int []b)
        {
            double dob = 1;

            foreach (int x in b)
            {
                if (x < 0)
                {
                    dob *= x;
                }
            }
            if (dob == 1)
            Console.WriteLine("В масивi вiдсутнi вiд'ємнi елементи");
            else
                Console.WriteLine($"Добуток від'ємних чисел = {dob}");
            return dob;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введiть довжину масива:");
                    string insertL = Console.ReadLine();
                    int length = int.Parse(insertL);

                    int[] array = Massive(length);
                    Dob(array);
                    Sum(array);

                    Console.ReadLine();
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Некоректнi данi, спробуйте ще");
                }
            }
        }
    }
}
