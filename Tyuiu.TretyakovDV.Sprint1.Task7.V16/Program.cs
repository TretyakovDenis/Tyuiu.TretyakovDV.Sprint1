using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TretyakovDV.Sprint1.Task7.V16.Lib;

namespace Tyuiu.TretyakovDV.Sprint1.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                DataService ds = new DataService();

                Console.Title = "Спринт #1 | Выполнил: Третьяков Д.В. | ПКТб-23-1";
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("* Спринт #1                                                                       *");
                Console.WriteLine("* Тема: Создание итогового решения по спринту                                     *");
                Console.WriteLine("* Задание #7                                                                      *");
                Console.WriteLine("* Вариант #16                                                                     *");
                Console.WriteLine("* Выполнил: Третьяков Денис Викторович | ПКТб-23-1                                *");
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                        *");
                Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным      *");
                Console.WriteLine("*  значениям данных, вводимых пользователем.                                      *");
                Console.WriteLine("*                                                                                 *");
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                                 *");
                Console.WriteLine("***********************************************************************************");

                double x;
                Console.WriteLine("Введите значение Х:");
                x = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("*РЕЗУЛЬТАТ:                                                                       *");
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine(ds.Calculate(x));
                Console.ReadKey();
            }
        }
    }
}