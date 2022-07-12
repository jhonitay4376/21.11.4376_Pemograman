using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penjualan
{ 
    class Program
    {
        static List<Produk> daftarProduk = new List<Produk>();
        static Produk prod = new Produk();
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilihan Menu Aplikasi\n");
            Console.WriteLine("1. Tambah produk");
            Console.WriteLine("2. Hapus produk");
            Console.WriteLine("3. Tampilkan produk");
            Console.WriteLine("4. Keluar\n");
        }

        static void TambahProduk()
        {
            Console.Clear();
            prod = new Produk();
            string TJ;
            Console.WriteLine("Tambah data prdoduk");
            Console.Write("Kode Produk   : ");
            prod.KodeProduk = Console.ReadLine();
            Console.WriteLine("Tanggal  : ");
            prod.Tanggal = Console.ReadLine();
            Console.Write("Nama Customer   : ");
            prod.NamaCstmr = Console.ReadLine();
            Console.Write("Jenis [T/K]  : ");
            TJ = Console.ReadLine();
            if (TJ == "T")
            {
                prod.Jenis = "Tunai";
            }
            else if (TJ == "K")
            {
                prod.Jenis = "Kredit";
            }
            Console.Write("Total Nota   : ");
            prod.HargaJual = Convert.ToInt32(Console.ReadLine());
            daftarProduk.Add(prod);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            Console.WriteLine("Hapus Data Produk\n");
            Console.Write("Kode Produk : ");
            string kodep = Console.ReadLine();
            var itemRemove = daftarProduk.SingleOrDefault(f => f.KodeProduk == kodep);
            if (itemRemove == null)
            {
                Console.WriteLine("Kode Produk Tidak Ditemukan");
            }
            else
            {
                daftarProduk.Remove(itemRemove);
                Console.WriteLine();
                Console.WriteLine("Data Produk Berhasil Dihapus");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            int no = 1;
            Console.WriteLine("Data Produk\n");
            foreach (Produk objProd in daftarProduk)
            {
                Console.WriteLine("{0}.{1},{2},{3},{4},{5}", no, objProd.KodeProduk, objProd.Tanggal, objProd.NamaCstmr, objProd.Jenis, objProd.HargaJual);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
