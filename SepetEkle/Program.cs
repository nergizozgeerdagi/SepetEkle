using System;

namespace odev
{
    class product
    {
        public int id;
        public string firmaAdi;
        public string urunAdi;
        public string aciklama;
        public decimal fiyati;
        public double indirimMiktari;
        public double sepettekiIndirim;
    }

    class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product();
            product1.id = 0001;
            product1.firmaAdi = "DesignOTTO";
            product1.urunAdi = "A4 Evrak Rafı Organizer";
            product1.aciklama = "Masaüstü Evrak Rafı 30*35*32";
            product1.fiyati = 69.90m;
            product1.indirimMiktari = 5;
            product1.sepettekiIndirim = 3;

            product product2 = new product();
            product2.id = 0002;
            product2.firmaAdi = "Sanal Mobilya";
            product2.urunAdi = "Pluton Kose Kitaplık";
            product2.aciklama = "Kose Kitaplık 6 raf";
            product2.fiyati = 149.90m;
            product2.indirimMiktari = 10;
            product2.sepettekiIndirim = 2;

            product product3 = new product();
            product3.id = 0003;
            product3.firmaAdi = "Appa";
            product3.urunAdi = "Mouse Pad";
            product3.aciklama = "75*35 Masaüstü Mousepad";
            product3.fiyati = 74.90m;
            product3.indirimMiktari = 5;
            product3.sepettekiIndirim = 5;

            product product4 = new product();
            product4.id = 0004;
            product4.firmaAdi = "Lyra Proffessional";
            product4.urunAdi = "Silver Şampuan";
            product4.aciklama = "1000ml Kepek Önleyici Şampuan";
            product4.fiyati = 24.90m;
            product4.indirimMiktari = 0;
            product4.sepettekiIndirim = 5;

            product[] urunler = new product[] { product1, product2, product3, product4 };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Firma Adı : " + urunler[i].firmaAdi + "\n" + urunler[i].urunAdi + "\n" + urunler[i].aciklama +
                    " - Fiyatı : " + urunler[i].fiyati + "\nİndirim %" + urunler[i].indirimMiktari
                    + " - Sepette Extra %" + urunler[i].sepettekiIndirim);
                Console.WriteLine(new string('/', 15) + " For Döngüsü İle Listelendi" + new string('/', 15));

            }
            Console.WriteLine("\n");

            foreach (var urun in urunler)
            {
                Console.WriteLine("Firma Adı : " + urun.firmaAdi + "\n" + urun.urunAdi + "\n" + urun.aciklama +
                    " - Fiyatı : " + urun.fiyati + "\nİndirim %" + urun.indirimMiktari
                    + " - Sepette Extra %" + urun.sepettekiIndirim);

                Console.WriteLine(new string('-', 15) + " ForEach Döngüsü İle Listelendi" + new string('-', 15));
            }
            Console.WriteLine("\n");

            int a = 0;
            while (a < 4)
            {
                Console.WriteLine("Firma Adı : " + urunler[a].firmaAdi + "\n" + urunler[a].urunAdi + "\n" + urunler[a].aciklama +
                    " - Fiyatı : " + urunler[a].fiyati + "\nİndirim %" + urunler[a].indirimMiktari
                    + " - Sepette Extra %" + urunler[a].sepettekiIndirim);
                a++;
                Console.WriteLine(new string('+', 15) + " While Döngüsü İle Listelendi" + new string('+', 15));

            }
        }
    }


}

