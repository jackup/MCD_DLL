using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_DLLCagirma
{
    class Program
    {
        static void Main(string[] args)
        {
            MCD_DLL.Class1 c1 = new MCD_DLL.Class1();
            decimal a = c1.Carp(15, 8);
            Console.WriteLine(a);
        }
    }
}
