using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman4303
{
    public class Kariawan
    {
        //Properties

        public string NIK {get; set;}
        public string Nama {get; set;}
        public int Gajibulanan {get; set;}

        public void InfoKariawan()
        {
            if (Gajibulanan >= 0)
            {
                Console.WriteLine("1. {0} {1}\t {2}", NIK, Nama, Gajibulanan);
            }
            else if (Gajibulanan < 0)
            {
                Console.WriteLine("1. {0} {1}\t 0", NIK, Nama);
            }
            else;
        }


    }


}