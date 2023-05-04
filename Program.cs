using System;

namespace Domaci20230504
{
    class Program
    {
        static void Main(string[] args)
        {
            Kontakti k1 = new Kontakti("Milan", "verlic", "0654620301");
            k1.DodajBroj("0643333333");
            k1.DodajBroj("0643333333");
            k1.DodajBroj("0661234567");
            k1.DodajBroj("0647654321");
            Console.WriteLine(k1);
            k1.IzbrisiBroj("0643333333");
            Console.WriteLine(k1);
            k1.IzbrisiBroj("0643333334");
            Console.WriteLine(k1);

            Kontakti k2 = new Kontakti("Mile", "elimc", "06522222222");
            k2.DodajBroj("0643333333");

            Adresar a1 = new Adresar();
            a1.Dodaj(k1);
            a1.Dodaj(k2);
            string sharefajl = @"C:StvarnoNeKontam.txt";
            a1.Share(sharefajl,"0654620301");

            string backupFajl = @"C:Backup.txt";
            a1.Backup(backupFajl);

            string resivfajl = @"C:Receive.txt";
            a1.Receive(resivfajl);

        }
    }
}
