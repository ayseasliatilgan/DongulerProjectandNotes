internal class Program
{
     static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }

    private static void DonguMatrisExamples()
    {
        int n = 5;

        for (int i = 0; i < n; i++)
        {
            // for ( int j = 0; j <= i; j++) seklinde yazarsak bize satir atladikca artan bir goruntu ile sayilari verecektir 
            for (int j = 0; j < n; j++)
            {
                Console.Write(" * ");
            }
            // Console.WriteLine(); yazarsak eger bize bir kare ya da dikdortgen seklinde ortaya cikaracaktir ve yukaridaki tirnak isaretlerinin icerisinde belirledigimiz butun simgeler ile olabilir bu
        }
    }

    private static void forDonguBelirlenenSayilarExample()
    {
        // belirledigin iki sayi arasindaki sayilari veriyor
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            // bu islemle birlikte 3un katlarini null olarak kabul ediyoruz
            if (i % 3 == 0)
                continue;
            // eger biz if (i == 100) 
            // break; demis olsaydik bu sefer 100 dahil olmayacak sekilde baslangic sayisindan itibaren 99a keser
            Console.Write("{0,3}", i);
        }
    }

    private static void forDongukatlariexamples()
    {
        for (int i = 1; i <= 10; i++)
        {
            // carpan int ne kadar olursa o kadar carpar yani karesi kupu gibi
            Console.WriteLine("{0,3} {1,3}", i, i * i * i);
        }
    }

    private static void forDongunegativeexample()
    {
        // eger sifirdan once esittir koymazsak 0 ciktisi almiyor 
        // negatif versiyonu bize buyukten kucuge siralanisi veriyor
        for (int i = 100; i >= 0; i -= 5)
        {
            Console.WriteLine(i);
        }
    }

    private static void forDongupositiveexample()
    {
        for (int i = 0; i < 100; i += 5)
        {
            Console.WriteLine(i);
        }
    }

    private static void dowhileexample()
    {
        Console.WriteLine("Write a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 2;
        do
        {
            // Console.WriteLine(i);
            Console.Write("{0,3}", i);
            i = i + 2; // ya da i += 2;
        } while (i <= n);
    }

    private static void DonguOrnegi()
    {
        // i bizim icin sadece bir belirtici isim 
        int i = 10;
        while (i > 0)
        {
            // Console.WriteLine(); seklinde yazarsak satırlar olusur
            // Console.Write() yazarsak tek satirda islem yapar
            // Console.write( "{0,5}", i) yazarsak gelecek sayilar arasinda 5 karakterli bosluk biraktirmis oluruz
            // Console.Write("{0,-5}", i) yazarsak eger bu sefer soldan hiza almis oluruz
            // Eger sayilarin karesini almak istiyorsak Console.WriteLine("{0,5}\t", i) seklinde ya da  Console.WriteLine("{0,5} {1,-3}", i, i*i)
            Console.WriteLine("{0,-2} {1, -5}", i, i * i);
            i -= 1; // i = i - 1
        }
    }
}