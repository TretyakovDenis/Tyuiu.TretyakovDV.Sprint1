using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TretyakovDV.Sprint1.Task6.V7.Lib;

namespace Tyuiu.TretyakovDV.Sprint1.Task6.V7
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
                Console.WriteLine("* Задание #5                                                                      *");
                Console.WriteLine("* Вариант #5                                                                      *");
                Console.WriteLine("* Выполнил: Третьяков Денис Викторович | ПКТб-23-1                                *");
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                        *");
                Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова,            *");
                Console.WriteLine("* удалив из них последнюю букву.                                                  *");
                Console.WriteLine("*                                                                                 *");
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                                 *");
                Console.WriteLine("***********************************************************************************");

                string x;
                Console.WriteLine("Введите значение Х:");
                x = Console.ReadLine();


                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("*РЕЗУЛЬТАТ:                                                                       *");
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine(ds.DeleteLastLetter(x));
                Console.ReadKey();
            }
        }
    }
}