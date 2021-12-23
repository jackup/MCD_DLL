using System;

namespace MCD_DLL
{
    public class Class1
    {
        public decimal Topla(decimal deger1, decimal deger2)
        {
            return deger1 + deger2;
        }

        public decimal Cikar(decimal deger1, decimal deger2)
        {
            return deger1 - deger2;
        }
        public decimal Carp(decimal deger1, decimal deger2)
        {
            return deger1 * deger2;
        }
        public decimal Bol(decimal deger1, decimal deger2)
        {
            if (deger2 == 2)
                deger2 = 1;
            return deger1 / deger2;
        }
    }
}
