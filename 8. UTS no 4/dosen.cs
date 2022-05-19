using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOSEN
{
    class dosen
    {
        public int id;
        public int NIK;
        public string Nama;
        public string Gender;
        public string Course;

        public void Dosen()
        {
            Console.WriteLine("Dosen Pengampu  : Kamarudin, M.Kom");
            Console.WriteLine("Mata Kuliah     : Pemrograman (ST021)");
        }

        public void attDosen(string nama,int nik, string gender)
        {
            Console.WriteLine("Dosen pengajar  : {0}",nama);
            Console.WriteLine("NIK Dosen       : {0}",nik);
            Console.WriteLine("Gender Dosen    : {0}",gender);
        }

        public void addCourse(string course)
        {
            Console.WriteLine("Mata Kuliah     : {0}",course);
        }
    }
}
