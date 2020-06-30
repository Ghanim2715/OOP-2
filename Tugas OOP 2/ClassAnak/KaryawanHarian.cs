using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tugas_OOP_2.ClassInduk;

namespace Tugas_OOP_2.ClassAnak
{
    class KaryawanHarian : Karyawan
    {

        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }

        //method interface
        public override double Gaji()
        {
            return (UpahPerJam * JumlahJamKerja);
        }
    }
}