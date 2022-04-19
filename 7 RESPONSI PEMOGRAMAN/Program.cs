using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman4376
{
    class Program
    {
        static void Main(string[] args)
        {
            // objek Karyawan
            Karyawan karyawan1 = new Karyawan(); //object 1
            Karyawan karyawan2 = new Karyawan(); //object 2
            Karyawan karyawan3 = new Karyawan(); //object 3

            // properties 1
            karyawan1.NIK = "99999999";
            karyawan1.NAMA = "NITAY";
            karyawan1.Gaji = 3000000;
           
            // properties 2
            karyawan2.NIK = "12398765";
            karyawan2.NAMA = "JHONITAY";
            karyawan2.Gaji = 2000000;

            // properties 3
            // properties 1
            karyawan3.NIK = "64646464";
            karyawan3.NAMA = "PRASADDAS";
            karyawan3.Gaji = 2500000;

            //pemanggilan method
            if (karyawan1.Gaji < 0) { karyawan1.Gaji = 0; }
            if (karyawan2.Gaji < 0) { karyawan2.Gaji = 0; }
            if (karyawan3.Gaji < 0) { karyawan3.Gaji = 0; }
            Console.WriteLine("No. \tNIK\tNama\t\tGaji Bulanan");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.Gaji);
            Console.WriteLine("2. \t{0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.Gaji);
            Console.WriteLine("3. \t{0} {1}\t{2}", karyawan3.NIK, karyawan3.NAMA, karyawan3.Gaji);
            Console.WriteLine("\n");
            Console.WriteLine("SELAMAT ANDA NAIK GAJI SEBESAR 10% ");
            Console.WriteLine("\n");
            Console.WriteLine("No. \tNIK\tNama\t\tGaji Bulanan Baru");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.Gaji + (karyawan1.Gaji /10));
            Console.WriteLine("2. \t{0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.Gaji + (karyawan2.Gaji / 10));
            Console.WriteLine("3. \t{0} {1}\t{2}", karyawan3.NIK, karyawan3.NAMA, karyawan3.Gaji + (karyawan3.Gaji / 10));
            Console.ReadKey();
        }
    }
}
