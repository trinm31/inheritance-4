using System;

namespace PhuongTrinhBac2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao so b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao so c");
            double c = Convert.ToDouble(Console.ReadLine());
            double delta = (b / 2) * (b / 2) - a * c;
            
            Console.WriteLine("Phương trình nhập vào là:\n {0}x*x + {1}x + {2} = 0", a, b, c);

            Console.WriteLine("Delta phẩy = {0}", delta);
            switch (delta < 0)
            {
                case true:
                    Console.WriteLine("Chương trình vô nghiệm");
                    break;
                case false:
                    switch (delta == 0)
                    {
                        case true:
                            double x = (-b / 2) / a;
                            Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = {0}", x);
                            break;
                        default:
                            double x1 = 0;
                            double x2 = 0;

                            x1 = ((-b / 2) - Math.Sqrt(delta)) / a;
                            x2 = ((-b / 2) + Math.Sqrt(delta)) / a;

                            Console.WriteLine("Phương trình có 2 nghiệm phân biệt: ");
                            Console.WriteLine("x1 = {0}", x1);
                            Console.WriteLine("x2 = {0}", x2);
                            break;
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
