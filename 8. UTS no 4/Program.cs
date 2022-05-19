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
            dosen Data = new dosen();
            Console.WriteLine("Default Data");
            Data.Dosen();
            Console.WriteLine(" ");
         
                Console.Write("input Nama dosen    : ");
                Data.Nama = Console.ReadLine();
                Console.Write("input NIK dosen     : ");
                Data.NIK = Convert.ToInt32(Console.ReadLine());
                Console.Write("input Gender dosen  : ");
                Data.Gender = Console.ReadLine();
                Console.Write("input mata kuliah yang diajarkan {0} : ", Data.Nama);
                Data.Course = Console.ReadLine();
            

            Console.Clear();

            Console.WriteLine("DATA DOSEN");
            Data.Dosen();   
            
            
                Data.attDosen(Data.Nama, Data.NIK, Data.Gender);
                Data.addCourse(Data.Course);
                Console.ReadLine();
            
        }
    }
}
