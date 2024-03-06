using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator|BY ALIM DAMA WICAKSONO|";

            Console.Write("masukkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("masukkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("1.penjumlahan");
            Console.WriteLine("2.pengurangan");
            Console.WriteLine("3.perkalian");
            Console.WriteLine("4.pembagian");

            Console.WriteLine("Pilih Menu");
            int pilih;
            pilih = Convert.ToInt32(Console.ReadLine());
            switch (pilih) 
            { 
                case 1:
                    Console.WriteLine("Hasil = " );
                    Console.WriteLine(a + b);
                    Console.ReadKey(); break;

                case 2:
                    Console.WriteLine("Hasil = ");
                    Console.WriteLine(a - b);
                    Console.ReadKey(); break;  
                    
                case 3:
                    Console.WriteLine("Hasil = ");
                    Console.WriteLine(a * b);
                    Console.ReadKey(); break;

                case 4:
                    Console.WriteLine("Hasil = ");
                    Console.WriteLine(a / b);
                    Console.ReadKey(); break;

               
                default:
                    Console.WriteLine("Menu Tidak Tersedia");
                    Console.ReadKey(true); break;
            }

        }   
    }
}
