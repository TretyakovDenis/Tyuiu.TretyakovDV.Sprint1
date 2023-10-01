using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TretyakovDV.Sprint1.Task5.V5.Lib;

namespace Tyuiu.TretyakovDV.Sprint1.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Третьяков Д.В. | ПКТб-23-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                       *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                     *");
            Console.WriteLine("* Задание #5                                                                      *");
            Console.WriteLine("* Вариант #5                                                                      *");
            Console.WriteLine("* Выполнил: Третьяков Денис Викторович | ПКТб-23-1                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу: Присвоить целой            *");
            Console.WriteLine("* переменной d первую цифру из дробной части положительного вещественного числа x *");
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