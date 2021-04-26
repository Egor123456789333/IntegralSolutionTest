using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLibrary
{
    public class Simpson : ICalculator
    {
        public double Calculate(double a, double b, long n, Func<double, double> f)
        {
            if (n < 0) throw new ArgumentException();
            double h = (b - a) / n;
            double sum = 0;
            double sum2 = 0;

            for (int k = 1; k <= n; k++)
            {
                double xk = a + k * h;
                if (k <= n - 1)
                {
                    sum += f(xk);
                }

                double xk_1 = a + (k - 1) * h;
                sum2 += f((xk + xk_1) / 2);
            }

            double result = h / 3 * (1 / 2 * f(a) + sum + 2 * sum2 + 1 / 2 * f(b));
            return result;
        }
    }
}
