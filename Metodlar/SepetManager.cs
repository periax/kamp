using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete  Eklendi : " + product.Adi);
        }
           
        public void Ekle2(string productAdi, string Acıklama, double fiyat)
        {
            Console.WriteLine("Sepete  Eklendi : " + productAdi);
        }
    }
}
