using System;
using System.Collections.Generic;
using System.Text;

namespace Program_karyawan
{
    public class KaryawanTetap : Karyawan
    {
        public double Bayaran { get; set; }
        public override double Gaji()
        {
            return Bayaran;
        }
    }
}
