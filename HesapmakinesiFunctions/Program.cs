using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HesapmakinesiFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] islemler = { "Toplama", "Çıkarma", "Çarpma", "Bölme", "Üs alma" };

            Console.WriteLine("-*-*-BASİT HESAP MAKİNESİ-*-*-");
            Hesaplama nesne = new Hesaplama();

            Console.Write("1. sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
           
            
            for (int i = 0; i < islemler.Length; i++)
            {
                Console.WriteLine((i+1) + " - " + islemler[i]);
               
            }

            Console.WriteLine("İşlem numarası seçiniz");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine(sayi1 + " + " +sayi2 +" = " +nesne.Topla(sayi1, sayi2));
                    break;
                case 2:
                    Console.WriteLine(sayi1 + " - " + sayi2 + " = " + nesne.Cikar(sayi1, sayi2));
                    break;
                case 3:
                    Console.WriteLine(sayi1 + " * " + sayi2 + " = " + nesne.Carp(sayi1, sayi2));
                    break;
                case 4:
                    Console.WriteLine(sayi1 + " / " + sayi2 + " = " + nesne.Bol(sayi1, sayi2));
                    break;
                case 5:
                    Console.WriteLine(sayi1 + " ^ " + sayi2 + " = " + nesne.UsAl(sayi1, sayi2));
                    break;
            }







        }
    }
}
