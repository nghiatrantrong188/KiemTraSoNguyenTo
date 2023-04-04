// See https://aka.ms/new-console-template for more information
using System;
namespace KiemTraSoNguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int so = -1;
            while(so!=0)
            {
                Console.Write("Nhap mot so: ");
                so = Convert.ToInt32(Console.ReadLine());            
                if(so < 2)
                Console.WriteLine(so + " khong phai la mot so nguyen to");
                else
                {
                    int i = 2;
                    bool check = true;
                    while (i <= Math.Sqrt(so))
                    {
                        if (so % i == 0)
                        {
                            check = false;
                            break;
                        }
                        i++;
                    }
                    if (check)
                    {
                        Console.WriteLine(so + " la mot so nguyen to");                    
                    }
                    else
                    {
                        Console.WriteLine(so + " khong phai la so nguyen to");
                    }
                }
            }
        }
    }
}
