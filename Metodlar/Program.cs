using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "ELMA";
            product1.Fiyati = 5;
            product1.Acıklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "karpuz";
            product2.Fiyati = 10;
            product2.Acıklama = "Has Bahşiş Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Acıklama);
                Console.WriteLine("-------------------------");

            }

            Console.WriteLine("-----------------Metotlar-------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12);
            sepetManager.Ekle2("Karpuzu", "Bahşiş karpuzu", 12);


            Console.WriteLine("Hello World!");
        }
    }
}
