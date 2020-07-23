using System;

namespace GiaiPhuongTringBac1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Chương trình giải phương trình bậc 1: ax+b=c");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Nhap vao so a");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao so b");
            Double b = Convert.ToDouble(Console.ReadLine());
            
            if (a==0 && b==0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem");
            }
            else if (a==0 && b!=0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                Console.WriteLine(tinhnghiem(a, b));
            }
            Console.ReadKey();
        }

        private static string tinhnghiem(double a, double b)
        {
            return $"Nghiem cua phuong trinh la:{(double)-b / a}";
        }
    }
}
