using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LathianClassDanObject
{
    public class Mahasiswa
    {
        //properties
        public string Nim { set; get; }
        public string Nama { set; get; }
        public float Ipk { set; get; }

        //method
        public void Registrasi()
        {
            Console.WriteLine("Nama : {0}", Nama);
            Console.WriteLine("NIM : {0}", Nim);
            Console.WriteLine("IPK : {0}", Ipk);
            Console.WriteLine("Telah Melakukan Registrasi");
        }

        public void IsiKrs()
        {
            Console.WriteLine("{0} sedang melakukan proses KRS\n",Nama);
        }
    }

}
