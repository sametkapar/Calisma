using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HesapmakinesiFunctions
{
    internal class Hesaplama
    {

        public double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }
        public double Carp(double sayi1, double sayi2)
        {
            return sayi1 * sayi2;
        }
        public double Cikar(double sayi1, double sayi2)
        {
            return sayi1 - sayi2;

        }
        public double Bol(double sayi1, double sayi2)
        {
            double bol = 0;
            if (sayi1 > sayi2 && sayi2 != 0)
            {
                bol = sayi1 / sayi2;
            }
            return bol;
        }
        public double UsAl(double taban, double us)
        {
            double sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }
            return sonuc;


        }
    }
}
