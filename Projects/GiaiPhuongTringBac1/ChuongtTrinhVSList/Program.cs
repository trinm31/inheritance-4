using System;
using System.Collections.Generic;

namespace ChuongtTrinhVSList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------Solfware-------------------");
            int [] a;
            a = new int[10];
            for (int i=0; i < a.Length; i++)
            {
                Console.WriteLine("Nhap gia tri a {0}",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine("xuat asc");
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);

            Console.WriteLine("Xuat Dsc");
            for (int i = a.Length-1; i >= 0; i--)
                Console.WriteLine(a[i]);

            Console.WriteLine("tinh tong");
            int s = 0;
            for (int i=1; i< a.Length; i++)
            {
                s += a[i];
            }
            Console.WriteLine("tong= {0}",s);

            Console.WriteLine("set");

            
        }
        public void Set(int[] a, int x, int vt) => a[vt] = x;
    }
}
