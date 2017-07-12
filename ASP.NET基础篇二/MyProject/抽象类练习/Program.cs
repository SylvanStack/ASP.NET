using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape circle = new LX(5,4);
            Console.WriteLine("面积:{0}----周长：{1}",circle.Mj(),circle.Zc());
        }
    }

    public abstract class Shape
    {
        public abstract double Zc();//求周长
        public abstract double Mj();//求面积
    }

    public class Circle : Shape
    {
        public double R { get; set; }

        public Circle(double  r)
        {
            this.R = r;
        }

        public override double Mj()
        {
            return Math.PI * R * R;
        }
        public override double Zc()
        {
            return Math.PI * 2 * R;
        }
    }

    public class Rectangle : Shape
    {
        public double L { get; set; }
        public double W { get; set; }

        public Rectangle(double l,double w)
        {
            this.L = l;
            this.W = w;
        }

        public override double Mj()
        {
            return L*W;
        }
        public override double Zc()
        {
            return 2*(L+W);
        }
    }
    public class LX : Shape
    {
        public double L { get; set; } //对角线
        public double W { get; set; }

        public LX(double l, double w)
        {
            this.L = l;
            this.W = w;
        }

        public override double Mj()
        {
            return L * W/2;
        }
        public override double Zc()
        {
            // return 4*Math.Sqrt(L/2*L/2+W/2*W/2)+Math;
            double num = L / 2 * L / 2 + W / 2 * W / 2;
            return 4 * Math.Pow(num, 0.5);
        }
    }
}
