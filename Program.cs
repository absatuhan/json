using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personel> Personellerim = new List<Personel>();
            for (int i = 0; i < 1000; i++)
            {
                Personel p1 = new Personel();
                p1.Id=Guid.NewGuid();
                p1.Isim=FakeData.NameData.GetFirstName();
                p1.Soyisim=FakeData.NameData.GetSurname();
                p1.EmailAdres = $"{p1.Isim}.{p1.Soyisim}@{FakeData.NetworkData.GetDomain()}";
                p1.TelefonNumarasi=FakeData.PhoneNumberData.GetPhoneNumber();
                Personellerim.Add(p1);              
            }
            Console.WriteLine("Bilgileriniz Json formatinda C://JsonIslemlerim//Personellerim.json olarak kayit edilecektir");
            if (Directory.Exists("c://JsonIslemlerim//"))
            {
                // ilgili klasor varsa herhangi bir islem yapmiyoruz
            }
            else
            {
                Directory.CreateDirectory("c://JsonIslemlerim//");
            }
            string JsonPersonellerim = Newtonsoft.Json.JsonConvert.SerializeObject(Personellerim);
            File.WriteAllText("c://JsonIslemlerim//Personellerim.json", JsonPersonellerim);

            Console.WriteLine("Json export islemi tamamlandi");


        }
    }
}
