using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SV sv1 = new SVCNTT("A01", "Nhan", "2005", 10, 9.5, 7);
            SV sv2 = new SVNV("N01", "Vuong", "2005", 5, 10);
            Console.WriteLine(sv1.ToString());
            Console.WriteLine(sv2.ToString());
            

        }
    }
}
