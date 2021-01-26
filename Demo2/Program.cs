using System;
using Demo2.Concrate;
using Demo2.Concrate.Entity;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu1 = new Oyuncu { Ad = "Ekrem" };
            Oyun oyun = new Oyun { Ad = "PUBG"};
            Kampanya kampanya = new Kampanya { Ad = "BlackHoliday" };

            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.Add(kampanya);

            Console.ReadLine();
        }
    }
}
