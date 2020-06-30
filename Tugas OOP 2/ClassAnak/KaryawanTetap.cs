using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tugas_OOP_2.ClassInduk;

namespace Tugas_OOP_2.ClassAnak
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }


        //method inheritance
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}