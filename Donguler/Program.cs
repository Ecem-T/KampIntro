using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
            Console.WriteLine("--------");

            //array
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu", "Programlamaya Başlangıç İçin Temel Kurs",
                "Java", "Python", "C#"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Sayfa Sonu");

            Console.WriteLine("For bitti");
            Console.WriteLine("---------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            


            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------");

            for (int i = 1; i <=10; i=i+1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------");

            for (int i = 1; i <=10; i=i+2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------");

            for (int i = 1; i <=10; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
