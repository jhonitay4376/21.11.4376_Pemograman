using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOSEN
{
    class Program
    {
        static void Main(string[] args)
        {
            dosen Data1 = new dosen();
            Data1.Dosen();
            Console.Write("input Nama dosen yang mengajar   : ");
            Data1.Nama = Console.ReadLine();
            Console.Write("input NIK dosen yang mengajar    : ");
            Data1.NIK = Convert.ToInt32(Console.ReadLine());
            Console.Write("input Gender dosen yang mengajar : ");
            Data1.Gender = Console.ReadLine();
            Console.Write("input mata kuliah yang diajarkan {0} : ",Data1.Nama);
            Data1.Course = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Data Dosen");
            Data1.Dosen();
            Data1.attDosen(Data1.Nama, Data1.NIK, Data1.Gender);
            Data1.addCourse(Data1.Course);
            Console.ReadLine();
        }
    }
}
