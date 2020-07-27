using System;

namespace Calisma12_MetodAndFunc
{
    enum BICIM { DIKEY, YATAY }

    class Program
    {
        public int IlkMetot(int a, int b)
        {
            return a + b;
        }
        static int IlkMetot1(int a, int b)
        {
            return a + b;
        }
        static void Yaz(object a)
        {
            Console.WriteLine(a.ToString());
        }
        static void DegerTipi(int deger)
        {
            deger = 50;
        }
        static void DegerTipiRef(ref int deger)
        {
            deger = 50;
        }
        static void DegerTipiOut(out int deger)
        {
            deger = 50;
        }
        static void DegerTipi(string[] deger)
        {
            deger[0] = "100";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            int sonuc = p.IlkMetot(5, 3);
            int sonuc1 = IlkMetot1(5, 3);
            // Console.WriteLine(sonuc);
            // Console.WriteLine(sonuc1);
            // Console.WriteLine(sonuc+sonuc1);
            int total = IlkMetot1(6, 9) + p.IlkMetot(8, 7) + 10;
            Yaz(sonuc);
            Yaz(sonuc1);
            Yaz(total);
            Yaz(sonuc1 + sonuc);
            Helper.Yaz(total);
            Helper.Yaz(10, sonuc, 10.25f);

            Yaz(Helper.EnBuyuk2(5, 4));

            // int sayi1, sayi2, sayi3;

            // Yaz("Sayıları Giriniz");
            // sayi1 = Convert.ToInt32(Console.ReadLine());
            // sayi2 = Convert.ToInt32(Console.ReadLine());

            // int max = Helper.EnBuyuk2(sayi1, sayi2);

            // Console.WriteLine("En büyük sayı :{0}", max);

            // Yaz("Sayıları Giriniz");
            // sayi1 = Convert.ToInt32(Console.ReadLine());
            // sayi2 = Convert.ToInt32(Console.ReadLine());
            // sayi3 = Convert.ToInt32(Console.ReadLine());

            // int max1 = Helper.EnBuyuk3(sayi1, sayi2, sayi3);

            // Console.WriteLine("Girilen 3 sayıdan en büyük sayı :{0}", max1);

            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 9 };
            Helper.DiziYaz(dizi, BICIM.YATAY);

            int deger = 10;

            Console.WriteLine("int deger-->" + deger);
            DegerTipi(deger);
            Console.WriteLine("int deger-->" + deger);

            DegerTipiRef(ref deger);
            Console.WriteLine("int deger-->" + deger);

            int o;
            DegerTipiOut(out o);
            Console.WriteLine("int deger-->" + deger);

            DegerTipi(deger);
            Console.WriteLine("int o -->" + o);

            string[] str = { "10", "50" };
            Console.WriteLine($"str[0]=>{str[0]}");
            DegerTipi(str);
            Console.WriteLine($"str[0]=>{str[0]}\n");
            while (args.Length != 0)
            {
                Console.WriteLine($"args[0]=>{args[0]}");

                for (int i = 0; i < args.Length; ++i)
                    Console.WriteLine($"args[{i}]=>{args[i]}");
                Helper.DiziYaz(args, BICIM.YATAY);
                Console.WriteLine("Çıkış için Q/q basınız.");
                string str1 = Console.ReadLine();
                if (str1.ToLower() == "q")
                    break;
                continue;
            }

            Console.WriteLine(Helper.Toplam(45, 63, 72, 28, 33, 39, 85, 90, 103, 108, 250));

            Double[] Uslusayilar = Helper.UstAlma(2, 5);
            foreach (double usluSayi in Uslusayilar)
                Console.WriteLine(usluSayi);

            Helper.Yaz(BICIM.YATAY, "deneme", 2, 3, 2.50, 2.25f);
            Console.WriteLine();
            Helper.Yaz(BICIM.DIKEY, "\ndeneme", 2, 3, 2.50, 2.25f);

            int s = 0;
            while (true)
            {
                Console.Write("\nKökü Alınacak Sayıları giriniz >>");
                string input = Console.ReadLine();
                if (input.ToLower() == "q")
                    break;
                //float[] sayi = { Convert.ToSingle(input) };
                float[] sayi = new float[s + 1];
                sayi[s] = Convert.ToSingle(input);



                double[] sayilarinKokleri = Helper.KareKokBul((Convert.ToDouble($"{sayi[s]}")));

                foreach (double kok in sayilarinKokleri)
                    Console.WriteLine($"{sayi[s]} kökü --> {kok}\n");
                s++;
            }

            Console.Write("\nFaktoriyelini almak istediğiniz sayıyı giriniz : ");
            int sayiFktrl = Convert.ToInt32(Console.ReadLine());
            int faktoriyeli = Helper.Faktoriel(sayiFktrl);
            Console.WriteLine($"{sayiFktrl} ' nın faktoriyeli -->>{faktoriyeli}");

            while (args.Length != 0)
            {
                double[] sayilarinKokler = new double[args.Length];
                for (int i = 0; i < args.Length; ++i)
                    sayilarinKokler[i] = Convert.ToDouble(args[i]); // Helper.KareKokBul((Convert.ToDouble($"{args[i]}")));
                double[] istenilenKokler = Helper.KareKokBul(sayilarinKokler);
                foreach (double kokler in istenilenKokler)
                    Console.WriteLine("Bulunan kökler >> " + kokler + " ");
                Console.WriteLine("Çıkış için Q/q basınız.");
                string str1 = Console.ReadLine();
                if (str1.ToLower() == "q")
                    break;
                continue;

            }









        }
    }
}
