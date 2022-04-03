using System;

namespace Enum_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Günler.cuma);
           Console.WriteLine((int)Günler.pazar);

           int sıcaklık = 24;

           if(sıcaklık <= (int)HavaDurumu.normal)
           {
               Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekle!");
           }else if(sıcaklık>= (int)HavaDurumu.sıcak)
           {
               Console.WriteLine("Dışarıya çıkmak için çok sıcak!");
           }else if (sıcaklık >=(int)HavaDurumu.normal && sıcaklık < (int)HavaDurumu.cokSıcak)
           {
               Console.WriteLine("Hadi dışarı çıkalım!! :)");
           }
        }
    }

    enum Günler
    {
        pazartesi=1,
        salı,
        çarşamba,
        perşembe,
        cuma = 23,
        cumartesi,
        pazar
    }

    enum HavaDurumu
    {
        soguk = 5,
        normal = 20,
        sıcak = 25,
        cokSıcak =30
    }
}
