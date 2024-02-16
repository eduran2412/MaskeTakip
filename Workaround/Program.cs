
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SelamVer("ENGİN");
            SelamVer();
            int sonuc = Topla(3, 52);
            string[] öğrenciler = new string[3];
            öğrenciler[0] = "EREN";
            öğrenciler[1] = "ENGİN";
            öğrenciler[2] = "ALİ";
            for (int i = 0; i < öğrenciler.Length; i++)
            {
                Console.WriteLine(öğrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Sivas", "Antalya" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
  

            int sayi1 = 1;
            int sayi2 = 11;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);
            

            Person person1 = new Person();
            person1.FirstName = "EREN";
            person1.LastName = "DURAN";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 11111111111;

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
            yeniSehirler1.Add("Karaman");
            foreach (string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            PharmacyManager pharmacyManager = new PharmacyManager(new PersonManager());
            pharmacyManager.GiveMask(person1);

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("toplam: " + sonuc);
            return sayi1 + sayi2;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "EREN";
            string soyadı = "DURAN";
            int dogumYili = 1985;
            long tcNo = 11111111111;


            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}