using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LathianClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa Saya = new Mahasiswa();
            Mahasiswa Kamu = new Mahasiswa();

            Saya.Nim = "18.11.1999";
            Saya.Nama = "Asep";
            Saya.Ipk = 3.8f;

            Kamu.Nim = "18.11.2000";
            Kamu.Nama = "Painem";
            Kamu.Ipk = 3.9f;

            Saya.Registrasi();
            Saya.IsiKrs();

            Kamu.Registrasi();
            Kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
