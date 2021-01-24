using System;

namespace classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            


            Urün ürün1 = new Urün();
            ürün1.UrünAdi = "Güzel Saat";
            ürün1.Marka = "TULPAR";
            ürün1.DegerlendirmePuanı = " 4 puan";
            ürün1.IndirimsizFiyat = "400 TL ";
            ürün1.IndirimliFiyat = "300 TL İNDİRİMLİ FİYAT ";
            ürün1.KargoBedavaMı = true;

            if (ürün1.KargoBedavaMı == true)
            {
                Console.WriteLine("KARGO BEDAVA");
            }
            else
            {
                Console.WriteLine(" : ");
            }

            Urün ürün2 = new Urün();
            ürün2.UrünAdi = "Daha Güzel Saat";
            ürün2.Marka = "TULPAR";
            ürün2.DegerlendirmePuanı = " 5 puan";
            ürün2.IndirimsizFiyat = "500 TL";
            ürün2.IndirimliFiyat = "450 TL";
            ürün2.KargoBedavaMı = false;

            if (ürün1.KargoBedavaMı == true)
            {
                Console.Write
            }
            else
            {
                Console.WriteLine(" : ");
            }


            Urün[] ürünler = new Urün[] { ürün1, ürün2 };

            foreach (var Urün in ürünler)
            {
                Console.WriteLine(Urün.UrünAdi + " : " + Urün.Marka + " : " + Urün.DegerlendirmePuanı + " : " + Urün.IndirimsizFiyat + " : " + Urün.IndirimliFiyat + " : " + Urün.KargoBedavaMı);
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Urün
    {
        public string UrünAdi { get; set; }
        public string Marka { get; set; }
        public string DegerlendirmePuanı { get; set; }
        public string IndirimsizFiyat { get; set; }
        public string IndirimliFiyat { get; set; }
        public bool KargoBedavaMı { get; set; }

    }
}
