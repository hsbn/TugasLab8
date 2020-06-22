using System;
using System.Collections.Generic;
using System.Text;

namespace Program_karyawan
{
    public class KaryawanHarian : Karyawan
    {
        public int JamKerja { get; set; }
        public int Bayaranperjam { get; set; }
        public override double Gaji()
        {
            return JamKerja * Bayaranperjam;
        }
    }
}
