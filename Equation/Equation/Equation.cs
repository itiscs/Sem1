using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    class Equation
    {
        protected int count = int.MaxValue;
     
        public static Equation CreateEquation(params double[] par)
        {
            switch(par.Length)
            {
                case 1:
                    return new Equation0(par[0]);
                case 2:
                    return new Equation1(par[0], par[1]);
                case 3:
                    return new Equation2(par[0], par[1], par[2]);
            }
            return new Equation();

        }
        
        public virtual void Solve()
        {
            Console.WriteLine("Решаем уравнение");
        }
        
        public virtual void PrintSol()
        {
            Console.WriteLine("Выводим решение");
        }

        public override 
    }

    class Equation0:Equation
    {
        protected double c;
        
        public Equation0(double c)
        {
            this.c = c;
        }
        
        public override void Solve()
        {
            if (c == 0)
                count = int.MaxValue;
            else
                count = 0;
        }

        public override void PrintSol()
        {
            if(count == int.MaxValue)
                Console.WriteLine("решение вся числовая ось");
            if(count == 0)
                Console.WriteLine("Нет решений");
        }
    }

    class Equation1 : Equation0
    {
        protected double b;
        protected double x1;

        public Equation1(double b, double c):base(c)
        {
            this.b = b;
        }

        public override void Solve()
        {
            count = 1;
            x1 = -c / b;
        }

        public override void PrintSol()
        {
            Console.WriteLine($"один корень: x={x1}");
        }
    }

    class Equation2 : Equation1
    {
        protected double a;
        protected double x2;

        public Equation2(double a, double b, double c) : base(b,c)
        {
            this.a = a;
        }

        public override void Solve()
        {
            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                count = 0;
            }
            else if(D==0)
            {
                count = 1;
                x1 = -b / (2 * a);
            }
            else
            {
                count = 2;
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
            }
            
        }

        public override void PrintSol()
        {
            switch(count)
            {
                case 0:
                    Console.WriteLine("Рациональных корней нет");
                    break;
                case 1:
                    base.PrintSol();
                    break;
                case 2:
                    Console.WriteLine($"Два корня:{x1} {x2}");
                    break;
            }
        }
    }


}
