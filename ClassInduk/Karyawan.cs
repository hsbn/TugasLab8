using System;
using System.Collections.Generic;
using System.Text;

namespace Program_karyawan
{
    public abstract class Karyawan
    {
        public string Nama { get; set; }
        public string NIK { get; set; }
        public abstract double Gaji();
    }
}
