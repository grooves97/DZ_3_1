using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.	Написать программу, которая считывает символы с клавиатуры,
             * пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов*/
            int spaceSymbol = 0;
            ConsoleKeyInfo symbol;
            Console.WriteLine("Программа для подсчета пробелов! ");
            do
            {
                Console.WriteLine("Введите символ");
                Console.WriteLine("Введите для окнания точку ");
                symbol = Console.ReadKey();
                Console.Clear();

                Console.WriteLine(symbol.Key);
                if (symbol.KeyChar == ' ')
                {
                    Console.WriteLine("Пробел");
                    spaceSymbol++;
                    Console.WriteLine($"Количество введенных пробелов = {spaceSymbol}");
                }
                if(symbol.KeyChar == '.')
                {
                    break;
                }
            } while (true);

        }
    }
}


