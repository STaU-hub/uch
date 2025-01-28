using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS_Пр_01_Zhiveinov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string  input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
  
                string line = "--";
                Console.Write("    ");
                for (int i=1; i < (number + 1); i++)
                {
                    Console.Write(string.Format("{0,4}", i));
                    line = line + "----";
                }
                Console.WriteLine();
                Console.WriteLine("     " + line);

 
                for (int i = 1; i < (number + 1); i++)
                {
                    line = line + "--";
                    Console.Write(string.Format("{0,3}|", i));
                    for (int z = 1; z < (number + 1); z++)
                    {
                        Console.Write(string.Format("{0,4}", i*z));
                     
                    }
                    Console.WriteLine();

                }


            }

            else 
            {
                Console.WriteLine($"Ошибка, введите число");
            }


            string zxc = Console.ReadLine();
        }
    }
}
