using System;

namespace kamp
{
    class Program
    {
        static void Main(string[] args)
        {

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirişYapmişMi = true;
            double dolarDun = 7.50;
            double dolarBugun = 7.5 ;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
                 
            
            if (sistemeGirişYapmişMi == true)
            {
                Console.WriteLine("Ayaralr butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            

          

            
            



         
                
            
        }
    }
}
