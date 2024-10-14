 using System;
// DEGER DONDURMEYEN
 namespace DegerDondurmeyen
{
    class program 
    {
        private static void mesaj()

        {
            Console.WriteLine("Adsiz Sansiz Bir Jude");
            
        }

        static void Main(string[] args)
        {
            mesaj();
        }
        
    }
}


// DEGER DONDUREN

namespace DegerDonduren
{
    class Program
    {
        private static int topla(int a, int b)
        {
            int k = a + b;
            return k;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Toplam: " + topla(45,5));
        }
    }
}

//PARAMETRE ALAN VE DEGER DONDUREN

namespace ParametreAlanveDegerDonduren
{
    class Program
    {
        private static int Kup(int S1)

        {
            int KupDeger = S1 * S1 * S1;
            return KupDeger;
        }

        static void Main(string[] args)
        {
            Console.Write("Sayi Giriniz: ");
            int Sayi = int.Parse(Console.ReadLine());
            Console.Write("Sonuc:" + Kup(Sayi));
        }
    }
}

using System;
using System.Runtime.CompilerServices;
// PARAMETRE ALAN VE GERIYE DEGER DONDURMEYEN
namespace ParametreAlanVeGeriyeDegerDondurmeyen
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Lutfen isminizi giriniz: ");
            string isim = Console.ReadLine(); 

            Console.Write("Lutfen soyisminizi giriniz: ");
            string soyisim = Console.ReadLine(); 

            
            Mesaj(isim, soyisim);
        }
        static void Mesaj(string isim, string soyisim)
        {
            Console.WriteLine("Hoş Geldiniz " + isim + " " + soyisim);
        }
    }

}