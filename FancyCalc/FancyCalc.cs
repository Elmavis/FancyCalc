using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {
        public double Add(int a, int b)
        {
            return a + b;
        }


        public double Subtract(int a, int b)
        {
            return a - b;
        }


        public double Multiply(int a, int b)
        {
            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            if (expression == null)
                throw new ArgumentNullException();
            string[] arr = expression.Split(new char[] { '+', '-', '*' });
            double a, b;
            a = Double.Parse(arr[0]);
            b = Double.Parse(arr[1]);
            char sign = expression.ToCharArray()[arr[0].Length];

            if (sign == '+')
                return Add((int)a, (int)b);
            if (sign == '-')
                return Subtract((int)a, (int)b);
            //if (sign == '*')
            return Multiply((int)a, (int)b);
        }
    }
}