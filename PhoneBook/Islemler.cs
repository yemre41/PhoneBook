using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
     class Islemler
    {
        public List<Sabitler>Kisiler=new List<Sabitler>();  
        
        public void KisiList() {
            Kisiler.Add(new Sabitler() { Name = "Yunus", Surname = "Emre", Number = "05051130532" });
            Kisiler.Add(new Sabitler() { Name = "Yakup", Surname = "Eryarsoy", Number = "05051130533" });
            Kisiler.Add(new Sabitler() { Name = "Birgul", Surname = "Eryarsoy", Number = "05076522099" });
        }

        public void KisiAdd()
        {
            Console.WriteLine("Lütfen isim girin..\n");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soy ad girin...\n");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen numara girin...\n");
            string number = Console.ReadLine();

            Kisiler.Add(new Sabitler { Name = name, Surname = surname, Number = number });

            Console.WriteLine("Kişi Eklenmiştir");
            Console.ReadKey();
            
        }
        public void KisiDelete()
        {
            KisiList();
            Console.WriteLine("Silmek İstediğiniz Kisinin Adını veya Soyadını giriniz..");
            string silincek = Console.ReadLine();
            foreach (var item in Kisiler)
            {
                if (item.Name==silincek||item.Surname==silincek)
                {
                    Console.WriteLine(item.Name + " " + item.Surname + " " + item.Number + " Kişiyi silmek istiyor musun (Y,N)");
                    char choice = char.Parse(Console.ReadLine());
                    if (choice=='Y')
                    {
                        Kisiler.Remove(item);
                        Console.WriteLine(item.Name+" "+item.Surname+" "+item.Number + " Başarı ile silindi");
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız");
                        Console.ReadKey();
                        
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("*Yeniden denemek için      : (2)");
                var secim = Console.ReadLine();
                if (secim == "1") { return; }
                else if (secim == "2") { KisiDelete(); }
                else { Console.WriteLine("Gecersiz bir karakter girdiniz "); Console.ReadKey(); }
                }
                
            }

        }
        public void KisiGüncelleme()
        {
            int dongu = 1;
            KisiList();
            Console.WriteLine("Numarasını değiştireceğiniz kişinin Adını veya Soyadını giriniz...");
            string adsoyad=Console.ReadLine();
            foreach (var item in Kisiler)
            {
                if (adsoyad==item.Name||adsoyad==item.Surname)
                {
                    Console.WriteLine("Yeni Numarayı giriniz..");
                    string numara = Console.ReadLine();
                    item.Number=numara;
                    Console.WriteLine($"Yeni numara   :{item.Number}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Rehberde bu isimde bir numara yoktur..");
                    Console.ReadKey();
                }
            }


        }
        public void KisiListeleme()
        {
            KisiList();
            Console.Clear();
            Console.WriteLine("*****TELEFONREHBERİ*****");
            foreach (var item in Kisiler)
            {
                Console.WriteLine($"İsim     :{ item.Name}");
                Console.WriteLine($"Soyisim    :{item.Surname}");
                Console.WriteLine($"Numara     :{item.Number}");
            }
            Console.WriteLine($"Kişi sayısı    ={Kisiler.Count}");
            Console.ReadKey();

        }
        public void KisiArama()
        {
            Console.Clear();
            Console.WriteLine("Arama Yapmak Istediginiz Turu Seciniz...");
            Console.WriteLine("*******************");
            Console.WriteLine("İsme ve Soyisme göre (1)");
            Console.WriteLine("Numaraya göre(2)");
            string secim = Console.ReadLine();

            foreach (var item in Kisiler)
            {
                if (secim=="1")
                {
                    Console.WriteLine("Ad veya Soyad girinizz..");
                    string adsoyad = Console.ReadLine();

                    if (adsoyad==item.Name||adsoyad==item.Surname)
                    {
                        Console.WriteLine("İsim : " + item.Name);
                        Console.WriteLine("Soyisim : " + item.Surname);
                        Console.WriteLine("Telefon Numarası : " + item.Number);
                        Console.WriteLine();
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir kayıt bulunamadı");
                        Console.ReadKey();
                    }
                }
                if (secim=="2")
                {
                    Console.WriteLine("Numara giriniz...");
                    string numuara = Console.ReadLine();
                    Console.WriteLine("İsim : " + item.Name);
                    Console.WriteLine("Soyisim : " + item.Surname);
                    Console.WriteLine("Telefon Numarası : " + item.Number);
                    Console.WriteLine();
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Böyle bir kayıt bulunamadı");
                    Console.ReadKey();
                }
            }

        }

            

            

     }

}

