﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLibrary
{
    public class RectangleCalculator : ICalculator //реализация интерфейса
    {
        public double Calculate(double a, double b, long n, Func<double, double> f)
        {
            if (n <= 0)
            {
                throw new ArgumentException();
            }
            var h = (b - a) / n;
            a += h * 0.5;

            double sum = 0;

            for (var i = 0; i < n; i++)
            {
                sum += f(a + h * i);
            }

            return sum * h;

        }
    }
}
