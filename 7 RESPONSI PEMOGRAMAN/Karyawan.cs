using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman4376
{
    class Karyawan
    {
        // constructor default
        public Karyawan()
        {

        }
        // overload constructor 
        public Karyawan(string nama, string nik, int gaji)
        {
            NAMA = nama;
            NIK = nik;
            Gaji = gaji;
        }
        // properties
        public string NAMA { get; set; }
        public string NIK { get; set; }
        public int Gaji { get; set; }


    }
}
