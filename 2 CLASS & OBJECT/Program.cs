using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_objec
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek class
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //input nilai objek
            saya.Nim = "4376";
            saya.Nama = "Jono";
            saya.IPK = "3.9";

            kamu.Nim = "4444";
            kamu.Nama = " paijo";
            kamu.IPK = "3.7";

            saya.registrasi();
            saya.IsiKrs();

            kamu.registrasi();
            kamu.IsiKrs();

            Console.ReadKey();

        }
    }
}
