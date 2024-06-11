using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakciUygulamasiApp
{
    public class SatilikEv1 : Ev1
    {
        private double satisfiyat;
        public double Satisfiyat { get; set; }
        string dosyayolu = "C:\\Users\\runav\\source\\repos\\C# Dersleri\\EmlakciUygulamasiApp\\SatiliklikEv1.txt";

        public override string EvBilgileriGetir()
        {
            StreamReader sr = File.OpenText(dosyayolu);
            return sr.ReadToEnd();
        }

        public void EvKayit(List<string> list)
        {

            using (StreamWriter sw = new StreamWriter(dosyayolu))
            {
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                    sw.WriteLine("***********************************");
                }
            }

        }

        public virtual string EvBilgileri()
        {
            return $"{base.EvBilgileri()} \nFiyat : {satisfiyat}";
        }


    }
}
