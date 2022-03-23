using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_objec
{
    class Mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public string IPK { get; set; }

        public void registrasi()
        {
            Console.WriteLine("Nama : {0}", Nama);
            Console.WriteLine("Nim  : {0}", Nim);
            Console.WriteLine("IPK  : {0}", IPK);
            Console.WriteLine("Telah melakukan registrasi");
        }
        public void IsiKrs()
        {
            Console.WriteLine("{0} sedang melakukan proses Krs\n ", Nama);
        }
    }
}
