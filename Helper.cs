using System;

namespace Calisma12_MetodAndFunc
{
    //enum BICIM { DIKEY, YATAY }
    class Helper
    {
        public static void Yaz(object str)
        {
            Console.WriteLine(str.ToString());
        }
        public static void Yaz(object str1, object str2, object str3)
        {
            Console.WriteLine("{0}, {1}, {2}", str1, str2, str3);
            return;
        }
        public static int EnBuyuk2(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
        public static int EnBuyuk3(int a, int b, int c)
        {
            return EnBuyuk2(a, EnBuyuk2(b, c));
        }
        public static int EnBuyuk4(int a, int b, int c, int d)
        {
            return EnBuyuk2(a, EnBuyuk2(d, EnBuyuk2(b, c)));
        }
        public static void DiziYaz(Array dizi, BICIM b)
        {
            foreach (Object i in dizi)
                if (b == BICIM.YATAY)
                    Console.Write(i.ToString() + " ");
                else
                    Console.WriteLine(i.ToString());
            Console.WriteLine();
        }

        public static int Toplam(params int[] sayilar)
        {
            if (sayilar.Length == 0)
                return 0;
            int toplam = 0;
            foreach (int s in sayilar)
                toplam += s;
            return toplam;

        }
        public static double[] UstAlma(double sayi, params double[] sayilar)
        {
            double[] power = new double[sayilar.Length];
            double[] p = { };
            if (sayilar.Length == 0)
                return p;
            for (int i = 0; i < sayilar.Length; ++i)
                power[i] = Math.Pow(sayilar[i], sayi);
            //foreach(double d in power)
            return power;

        }
        public static double[] KareKokBul(params double[] sayilar)
        {
            double[] squrate = new double[sayilar.Length];
            double[] p = { };
            if (sayilar.Length == 0)
                return p;
            for (int i = 0; i < sayilar.Length; ++i)
            squrate[i]=Math.Sqrt(sayilar[i]);
            return squrate;
        }
        
        public static void Yaz(BICIM b, params object[] nesne)
        {
            if (nesne.Length == 0)
                return;
            if (b == BICIM.YATAY)
                foreach (object o in nesne)
                    Console.Write(o.ToString() + " ");
            else
                foreach (object o in nesne)
                    Console.WriteLine(o.ToString());
        }




    }
    // class Program
    // {
    //     public int IlkMetot(int a, int b)
    //     {
    //         return a + b;
    //     }
    //     static int IlkMetot1(int a, int b)
    //     {
    //         return a + b;
    //     }
    //     static void Yaz(object a)
    //     {
    //         Console.WriteLine(a.ToString());
    //     }

    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Hello World!");
    //         Program p = new Program();
    //         int sonuc = p.IlkMetot(5, 3);
    //         int sonuc1 = IlkMetot1(5, 3);
    //         // Console.WriteLine(sonuc);
    //         // Console.WriteLine(sonuc1);
    //         // Console.WriteLine(sonuc+sonuc1);
    //         int total = IlkMetot1(6, 9) + p.IlkMetot(8, 7) + 10;
    //         Yaz(sonuc);
    //         Yaz(sonuc1);
    //         Yaz(total);
    //         Yaz(sonuc1 + sonuc);
    //         Helper.Yaz(total);
    //         Helper.Yaz(10, sonuc, 10.25f);

    //         Yaz(Helper.EnBuyuk2(5, 4));

    //         int sayi1, sayi2, sayi3;

    //         Yaz("Sayıları Giriniz");
    //         sayi1 = Convert.ToInt32(Console.ReadLine());
    //         sayi2 = Convert.ToInt32(Console.ReadLine());

    //         int max = Helper.EnBuyuk2(sayi1, sayi2);

    //         Console.WriteLine("En büyük sayı :{0}", max);

    //         Yaz("Sayıları Giriniz");
    //         sayi1 = Convert.ToInt32(Console.ReadLine());
    //         sayi2 = Convert.ToInt32(Console.ReadLine());
    //         sayi3 = Convert.ToInt32(Console.ReadLine());

    //         int max1 = Helper.EnBuyuk3(sayi1, sayi2, sayi3);

    //         Console.WriteLine("Girilen 3 sayıdan en büyük sayı :{0}", max1);

    //         int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 9 };
    //         Helper.DiziYaz(dizi, BICIM.YATAY);




    //     }
    // }
}
