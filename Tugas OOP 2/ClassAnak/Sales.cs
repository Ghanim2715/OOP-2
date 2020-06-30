using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tugas_OOP_2.ClassInduk;

namespace Tugas_OOP_2.ClassAnak
{
    class Sales : Karyawan
    {
        public double Komisi { get; set; }

        public double JumlahPenjualan { get; set; }


        //method interface
        public override double Gaji()
        {
            return (Komisi * JumlahPenjualan);
        }
    }
}