using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Shapelist
    {
        public struct shapeli
        {
            public int dim;
            public int shape;
            public int R;
        }
    }
    abstract class Shape
    {

    }
    class Twodim : Shape
    {

    }
    class Threedim : Shape
    {

    }
    class Triangle : Twodim
    {
        private static double area { get; set; }
        private static int perimeter { get; set; }
        public double calarea(int r)
        {
            return area = (Math.Sqrt(3) / 4) * (Math.Pow(r, 2));
        }
        public int calperi(int r)
        {
            return perimeter = 3 * r;
        }
        public void print()
        {
            Console.WriteLine("AREA : {0} , PERIMETER : {1}", area, perimeter);
        }
    }
    class Square : Twodim
    {
        private static double area { get; set; }
        private static int perimeter { get; set; }
        public double calarea(int r)
        {
            return area = (Math.Pow(r, 2));
        }
        public int calperi(int r)
        {
            return perimeter = 4 * r;
        }
        public void print()
        {
            Console.WriteLine("AREA : {0} , PERIMETER : {1}", area, perimeter);
        }
    }
    class Circle : Twodim
    {
        private static double area { get; set; }
        private static double perimeter { get; set; }
        public double calarea(int r)
        {
            return area = (Math.Pow(r, 2)) * 3.14;
        }
        public double calperi(int r)
        {
            return perimeter = 2 * r * 3.14;
        }
        public void print()
        {
            Console.WriteLine("AREA : {0} , PERIMETER : {1}", area, perimeter);
        }
    }
    class Sphere : Threedim
    {
        private static double area { get; set; }
        private static double volume { get; set; }
        public double calarea(int r)
        {
            return area = 4 * Math.Pow(r, 2) * 3.14;
        }
        public double calvol(int r)
        {
            return volume = Math.Pow(r, 3) * 3.14 * 4.0 / 3;
        }
        public void print()
        {
            Console.WriteLine("AREA : {0} , VOLUME : {1}", area, volume);
        }
    }
    class Cube : Threedim
    {
        private static double area { get; set; }
        private static double volume { get; set; }
        public double calarea(int r)
        {
            return area = 6 * Math.Pow(r, 2);
        }
        public double calvol(int r)
        {
            return volume = Math.Pow(r, 3);
        }
        public void print()
        {
            Console.WriteLine("AREA : {0} , VOLUME : {1}", area, volume);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            List<Shapelist.shapeli> shapelist = new List<Shapelist.shapeli>();
            Shapelist.shapeli a = new Shapelist.shapeli();
            Triangle triangle = new Triangle();
            Square square = new Square();
            Circle circle = new Circle();
            Sphere sphere = new Sphere();
            Cube cube = new Cube();
            Console.WriteLine("도형");
            while (true)
            {
                int abc = 0;
                Shapelist.shapeli b = new Shapelist.shapeli();
                Console.WriteLine("원하는 차원의 수? (2,3)");
                int dim = Int32.Parse(Console.ReadLine());
                b.dim = dim;
                if (dim == 2)
                {
                    Console.WriteLine("정삼각형,정사각형,원 중에선택(1,2,3)");
                    int shape = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("한변의 길이 or 반지름의 길이?");
                    length = Int32.Parse(Console.ReadLine());
                    b.shape = shape;
                    b.R = length;
                    shapelist.Add(b);
                    for (int i = 0; i < shapelist.Count - 1; i++)
                    {
                        if ((dim == shapelist[i].dim) && (length == shapelist[i].R) && (shape == shapelist[i].shape))
                        {
                            Console.WriteLine("이미 존재하는 도형,크기 입니다.");
                            abc = 1;
                            break;
                        }
                    }
                    if (shape == 1 && abc == 0)
                    {
                        triangle.calarea(length);
                        triangle.calperi(length);
                        triangle.print();
                    }
                    else if (shape == 2 && abc == 0)
                    {
                        square.calarea(length);
                        square.calperi(length);
                        square.print();
                    }
                    else if (shape == 3 && abc == 0)
                    {
                        circle.calarea(length);
                        circle.calperi(length);
                        circle.print();
                    }
                }
                else if (dim == 3)
                {
                    Console.WriteLine("정육면체,구 중에선택(1,2)");
                    int shape = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("한변의 길이 or 반지름의 길이?");
                    length = Int32.Parse(Console.ReadLine());
                    b.shape = shape;
                    b.R = length;
                    shapelist.Add(b);
                    for (int i = 0; i < shapelist.Count - 1; i++)
                    {
                        if ((dim == shapelist[i].dim) && (length == shapelist[i].R) && (shape == shapelist[i].shape))
                        {
                            Console.WriteLine("이미 존재하는 도형,크기 입니다.");
                            abc = 1;
                            break;
                        }
                    }
                    if (shape == 1 && abc == 0)
                    {
                        cube.calarea(length);
                        cube.calvol(length);
                        cube.print();
                    }
                    else if (shape == 2 && abc == 0)
                    {
                        sphere.calarea(length);
                        sphere.calvol(length);
                        sphere.print();
                    }
                }
                else if (dim == 5)
                {
                    break;
                }
            }
        }
    }
}




