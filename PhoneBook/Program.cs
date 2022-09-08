using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak Istediginiz Islemi Seciniz..");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            
            string secim = Console.ReadLine();
            Islemler islem = new Islemler();
            switch (secim)
            {
                case "1":
                    islem.KisiAdd();                   
                    break;
                case "2":
                    islem.KisiDelete();
                    break;
                case "3":
                    islem.KisiGüncelleme();
                    break;
                case "4":
                    islem.KisiListeleme();
                    break;
                case "5":
                    islem.KisiArama();
                    break;

            }
        }
    }
}
