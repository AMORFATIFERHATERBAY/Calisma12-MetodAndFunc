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
                squrate[i] = Math.Sqrt(sayilar[i]);
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
        public static int Faktoriel(int a)
        {
            if (a == 0)
                return 1;
            return a * Faktoriel(a - 1);
        }
        public static int Fibonacci(int a)
        {
            if (a==0)
            return 0;
            if (a==1)
            return 1;
            return Fibonacci(a-1)+Fibonacci(a-2);
        }




    }

}
