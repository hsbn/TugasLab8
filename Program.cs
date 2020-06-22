using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_karyawan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Inheritance, Polymorphsim, Abstraction & Collection";

            // Membuat objek untuk semua karyawan

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "123-234-345";
            karyawanTetap.Nama = "Agus Purnomo";
            karyawanTetap.Bayaran = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "124-321-366";
            karyawanHarian.Nama = "Erika Sintia Labela";
            karyawanHarian.Bayaranperjam = 13000;
            karyawanHarian.JamKerja = 8;

            Sales sales = new Sales();
            sales.NIK = "163-393-346";
            sales.Nama = "Andrew Fuller";
            sales.TotalPenjualan = 30;
            sales.Komisi = 45000;

            // Objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3}", noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
