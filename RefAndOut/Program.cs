using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                C# dilinde temel olarak iki veri türü vardır. Bunların birincisi referans türleri, ikincisi değer türleridir. 
                Değer türleri(int, double, decimal...) bir değişkenin değerini kopyalar. 
                Referans türler(string, class, array...) ise nesnenin bellek üzerindeki adresi ile işlem yapar.
                Metot içerisinde kullandığımız değer veri türlerini referans olarak kullanmak için "ref" ve "out" anahtar kelimeleri kullanılır
                "ref" ve "out" temelde aynı işi yapar ancak bir farkları var. 
            */

            int x = 10;
            int y = 30;

            var result = Add(x, y);
            var result2 = AddRef(ref x, y);
            var result3 = AddOut(out x, y);
            Console.WriteLine(result2);
            Console.WriteLine(x);


        }

        static int Add(int x, int y)
        {


            x = 30;
            return x + y;

        }

        //ref anahrat kelimesi kullanırsak metotda değişkene değer atmak zorunda kalmayız
        static int AddRef(ref int x, int y)
        {
            x = 30;
            return x + y;

        }

        //out anahrat kelimesi kullanırsak metotda değişkene değer atmak zorundayız
        static int AddOut(out int x, int y)
        {

            x = 30;
            return x + y;
        }
    }
}
