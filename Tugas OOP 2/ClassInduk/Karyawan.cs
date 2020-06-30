using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_OOP_2.ClassInduk
{
    abstract class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }

        //method
        public abstract double Gaji();
    }
}