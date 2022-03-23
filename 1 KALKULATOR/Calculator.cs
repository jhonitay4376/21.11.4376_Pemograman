using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // JUDUL //
            first:
            Console.Title = ("APLIKASI CALKULATOR");
            Console.WriteLine();

            // PEMILIHAN OPERATOR//
            Console.Write(" PILIH MENU CALKULATOR : ");
            Console.WriteLine();
            Console.WriteLine(" ");

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine(" ");

            Console.Write("input nomor 1-4 : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(" ");

            if (x == 1)
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("input nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("hasil penambahan {0} + {1} = {2}", a, b, penambahan(a, b));

                Console.WriteLine("tekan sembarang keyboard untuk keluar");
                Console.ReadKey();

            }
            else if (x == 2)
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("input nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("hasil penambahan {0} - {1} = {2}", a, b, pengurangan(a, b));

                Console.WriteLine("tekan sembarang keyboard untuk keluar");
                Console.ReadKey();

            }
            else if (x == 3)
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("input nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("hasil penambahan {0} * {1} = {2}", a, b, perkalian(a, b));

                Console.WriteLine("tekan sembarang keyboard untuk keluar");
                Console.ReadKey();

            }
            else if (x == 4)
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("input nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("hasil penambahan {0} / {1} = {2}", a, b, pembagian(a, b));

                Console.WriteLine("tekan sembarang keyboard untuk keluar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("MAAF, INPUT YANG ANDA LAKUKAN SALAH");
                Console.WriteLine("tekan sembarang keyboard untuk mengulangi");
                Console.ReadKey();
                Console.Clear();
                goto first;
            }

        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }

    }
}
