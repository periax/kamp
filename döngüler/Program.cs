using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılımcı Kursu";
            string kurs2 = "Programcı Kursu";
            string kurs3 = "Java Kursu";

            string[] kurslar = new string[] { "Yazılımcı Kursu", "Programcı Kursu", "Java Kursu","phyton"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }
    }
}
