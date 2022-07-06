using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_45_Fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;

            while (isWork == true)
            {
                Console.WriteLine("\n1. Выбрать бойцов для боя \n2. Начать драку \n3. Выход");

                switch (Console.ReadLine())
                {
                    case "1":

                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "5":
                        isWork = false;
                        break;

                    default:
                        Console.WriteLine("\nНеккоректный ввод\n");
                        break;
                }
            }
        }
    }

    class Fighter
    {

    }
}
