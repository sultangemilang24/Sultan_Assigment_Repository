using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman4303
{
    class program
    {
        static void Main (string [] arg)
        {
            Kariawan Pablo = new Kariawan();
            Kariawan Jonu = new Kariawan();

            Pablo.NIK = "213450034";
            Jonu.NIK = "128491200";

            Pablo.Nama = "Pablo";
            Jonu.Nama = "Jonu";

            Pablo.Gajibulanan = 3000000;
            Jonu.Gajibulanan = -100000;

            Console.WriteLine("NIM\tNama\tGajibulanan");
            Console.WriteLine("====================================");

            Pablo.InfoKariawan();
            Jonu.InfoKariawan();

            Console.WriteLine("Dapat naikan gaji 10% kuy");

            Pablo.Gajibulanan = (3000000*(1/10))+3000000;

            Console.WriteLine("NIM\tNama\tGajibulanan");
            Console.WriteLine("====================================");

            Pablo.InfoKariawan();
            Jonu.InfoKariawan();


            
        }
    }
}