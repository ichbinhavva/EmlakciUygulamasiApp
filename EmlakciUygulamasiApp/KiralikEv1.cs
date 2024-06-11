using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakciUygulamasiApp
{
    public class KiralikEv1 : Ev1
    {
        public KiralikEv1() { }

        private double kira;
        private double depozito;
        public double Depozito { get ; set; }

        public double Kira { get; set; }
 
        public override string EvBilgileriGetir()
        {
            StreamReader sr = File.OpenText("C:\\Users\\runav\\source\\repos\\C# Dersleri\\EmlakciUygulamasiApp\\KiralikEv1.txt");
            return sr.ReadToEnd();

        }

        public void EvKayit(List<string> list)
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\runav\\source\\repos\\C# Derslerii\\EmlakciUygulamasiApp\\KiralikEv1.txt"))
            {
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                    sw.WriteLine("*********************************");
                }
            }

        }

        public virtual string EvBilgileri()
        {
            return $"{base.EvBilgileri()} +\n Kira:{kira}\n Depozito:{depozito}";
        }
    }
}
