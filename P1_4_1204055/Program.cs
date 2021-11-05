using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_4_1204055
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("MENU PERSEGI PANJANG\n");
            Console.Write("1. Hitung Luas\n");
            Console.Write("2. Hitung Keliling\n");
            Console.Write("3. Hitung Panjang Diagonal\n");
            
            Console.Write("\nMenu Pilihan: ");

            int angka = Convert.ToInt16(Console.ReadLine());

            if (angka == 1)
            {
                Console.WriteLine("\nLUAS PERSEGI PANJANG");

                Console.Write("\nMasukkan Panjang: ");

                int panjang = Convert.ToInt16(Console.ReadLine());

                Console.Write("Masukkan Lebar: ");

                int Lebar = Convert.ToInt16(Console.ReadLine());

                int c = panjang * Lebar;

                Console.WriteLine("\nLuas Persegi Panjang = " + c);
            }
            else if (angka == 2)
            {
                Console.WriteLine("\nKELILING PERSEGI PANJANG");

                Console.Write("\nMasukkan Panjang: ");

                int panjang = Convert.ToInt16(Console.ReadLine());

                Console.Write("Masukkan Lebar: ");

                int Lebar = Convert.ToInt16(Console.ReadLine());

                int c =  panjang + Lebar + panjang + Lebar;

                Console.WriteLine("\nKeliling Persegi Panjang = " + c);
            }
            else if (angka == 3)
            {
                Console.WriteLine("\nPANJANG DIAGONAL PERSEGI PANJANG");

                Console.Write("\nMasukkan Panjang: ");

                int panjang = Convert.ToInt16(Console.ReadLine());

                Console.Write("Masukkan Lebar: ");

                int Lebar = Convert.ToInt16(Console.ReadLine());

                int c = (panjang * panjang) + (Lebar * Lebar) ;
                double d = Math.Sqrt(c);
                Console.WriteLine("\nPanjang Diagonal Persegi Panjang = " + d);
            }
        }
    }
}
