﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TretyakovDV.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            return Math.Round(Math.Sin(Math.Sqrt(x)) + (Math.Cos(Math.Pow(x, 2)) / 3 * Math.Pow(x, 3)) - Math.Sin(Math.Sqrt(Math.Pow(x, 2) - 1)), 3);
        }

    }
}
