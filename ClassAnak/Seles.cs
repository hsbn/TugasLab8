using System;
using System.Collections.Generic;
using System.Text;

namespace Program_karyawan
{
    public class Sales : Karyawan
    {
        public int TotalPenjualan { get; set; }
        public int Komisi { get; set; }
        public override double Gaji()
        {
            return TotalPenjualan * Komisi;
        }
    }
}
