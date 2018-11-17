using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复数
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(3, 4);
            Complex c3 = c1 * c2;

            Console.WriteLine(c1);
            Console.WriteLine(-c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
    class Complex
    {
        private int real;
        private int imag;

        public Complex(int real, int imag)
        {
            this.real = real;
            this.imag = imag;
        }

        public static Complex operator -(Complex c)	  // 重载 - （单目）
        {
            return new Complex(-c.real, -c.imag);
        }

        public static Complex operator +(Complex c1, Complex c2)// 重载+
        {
            return new Complex(c1.real + c2.real, c1.imag + c2.imag);
        }

        public static Complex operator -(Complex c1, Complex c2)// 重载-
        {
            return new Complex(c1.real - c2.real, c1.imag - c2.imag);
            //return c1 + new Complex(-c2.Real, -c2.imag);
            //return c1 + (-c2);
        }

        public static Complex operator *(Complex c1, Complex c2)// 重载*
        {
            return new Complex(c1.real * c2.real - c1.imag * c2.imag,
                               c1.real * c2.imag - c1.imag * c2.real);
        }

        public override string ToString()
        {
            string output = real.ToString();

            if (imag >= 0)
            {
                output += " + " + imag + "i";
            }
            else
            {
                output += " - " + (-imag) + "i";
            }

            return output;
        }
    }

}
