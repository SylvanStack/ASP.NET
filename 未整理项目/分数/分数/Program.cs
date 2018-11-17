using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 分数
{
    class Program
    {
        static void Main(string[] args)
        {
            fraction n1 = new fraction(6, 4);
            n1.show();
            fraction n2 = new fraction(5, 4);
            n2.show();
            n1.GetAdd(n2).show();
            n1.GetSub(n2).show();
            n1.GetMul(n2).show();
            n1.GetDiv(n2).show();
        }
    }
    class fraction
    {
        private int numerator=3;
        private int denominator =4;

        public fraction():this(1,1)
        {
        }

        public fraction(int numerator, int denominator)
        {
            this.denominator = denominator;
            this.numerator = numerator;
        }

        public fraction GetAdd(fraction other)
        {
            return new fraction(this.numerator+other.numerator,this.denominator*other.denominator);
        }

        public fraction GetSub(fraction other)
        {
            return new fraction(this.numerator - other.numerator, this.denominator * other.denominator);
        }

        public fraction GetMul(fraction other)
        {
            return new fraction(this.numerator * other.numerator, this.denominator * other.denominator);
        }

        public fraction GetDiv(fraction other)
        {
            return new fraction(this.numerator * other.denominator, this.denominator * other.numerator);
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (denominator > 0)
                {
                    value = denominator;
                }
            }
        } 
        
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                value = numerator;
            }
        }
        
        public fraction fractionsimp(int numerator, int denominator)
        {
            int min ,max;
            if (numerator < denominator)
            {
                min = numerator;
                max = denominator;
            }
            else
            {
                max = numerator;
                min = denominator;
            }
            while (max % min != 0)
            {
                int temp = max;
                max = min;
                min = temp % min;
            }

            numerator = numerator / min;
            denominator = denominator / min;
            return new fraction(numerator, denominator);
        }

        public void show()
        {
            Console.WriteLine("{0}/{1}", fractionsimp(numerator, denominator).numerator, fractionsimp(numerator, denominator).denominator);
        }
    }
}
