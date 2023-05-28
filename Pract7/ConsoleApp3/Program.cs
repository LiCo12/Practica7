using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Pract7
{
    class Base
    {
        public int a, b;
        List<int> pryamo = new List<int>(); 
        
        public Base() 
        {
           
            pryamo.Add(a);
            pryamo.Add(b);

        }
        public int this[int index]
        {
            get
            {    
                if(index==0)
                {
                    return a;
                }
                if(index==1)
                {
                    return b;
                }    
                else
                {
                    Console.WriteLine("Неккоректное значение");
                    return 0;
                }
            }
            set
            {
                if (index == 0)
                {
                    pryamo[a] = value;
                }
                if (index == 1)
                {
                    pryamo[b] = value;
                }
                else
                {
                    Console.WriteLine("Неккоректное значение");

                }
            }
        } 
        public int Perim()
        {
            return (a + b) * 2;
        }
        public int S()
        {
            return a * b;
        }
    }
    class Triangle
    {
        public double a1, b1, c1,p; 

        List<double> treyg = new List<double>(); 
        public Triangle()
        {
            treyg.Add(a1);
            treyg.Add(b1);
            treyg.Add(c1);
        } 
        public double this[int index1]
        {
            get
            {
                if (index1 == 0 )
                {
                    return a1;
                }
                if (index1 == 1)
                {
                    return b1;
                }
                if (index1 == 2)
                {
                    return c1;
                }
                else
                {
                    Console.WriteLine("Неккоректное значение индекса");
                    return 0;
                }      
            } 
            set
            {
                if(index1==0)
                {
                    treyg[0] = value;
                }
                if (index1 == 1)
                {
                    treyg[1]=value;
                }
                if (index1 == 2)
                {
                    treyg[2] = value;
                }
                else
                {
                    Console.WriteLine("Неккоректный индекс");
                }
            }
        }
        public double Perim1()
        {
            return a1 + b1 + c1;
        }
        public double S1()
        {
            double p = Perim1() / 2.0;
            double result = Math.Sqrt(p * (p - this[0]) * (p - this[1]) * (p - this[2]));
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int A, B,A1,B1,C1;
            Console.WriteLine("Прямоугольник");
            Console.Write("Введите значение стороны А-");
            A=Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение  сторны В-");
            B = Convert.ToInt32(Console.ReadLine());
            Base rectangle = new Base();
            rectangle.a = A;
            rectangle.b = B;
            int a = rectangle.a;
            int b = rectangle.b;
            Console.WriteLine("Значение сторон прямоуглольника:" + a + ',' + b);
            int perimeter = rectangle.Perim();
            int s = rectangle.S();
            Console.WriteLine("Периметр:" + perimeter);
            Console.WriteLine("Площадь:" + s);
            Console.WriteLine("Треугольник");
            Console.Write("Введите значение стороны А-");
            A1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение  сторны В-");
            B1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение стороны С-");
            C1 = Convert.ToInt32(Console.ReadLine());
            Triangle triangle = new Triangle();
            triangle.a1 = A1; triangle.b1 = B1; triangle.c1 = C1;
            double perimetr = triangle.Perim1();
            double s1 = triangle.S1();
            Console.WriteLine("Периметр:" + perimetr);
            Console.WriteLine("Площадь:" + s1);
        }   
    }
}
