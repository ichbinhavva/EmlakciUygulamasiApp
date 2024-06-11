using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakciUygulamasiApp
{
    public abstract class Ev1
    {
        private int katno;
        private int odasayisi;
        private double alan;
        protected StreamReader sr1;

        public int Odasayisi { get; set; }

        public int Katno { get; set; }

        public double Alan { get; set; }

        public virtual string EvBilgileri()
        {
            return $"Oda Sayısı: {odasayisi}\n Kat Numarası:{katno}\n Alan:{alan}";
        }

        public virtual string EvBilgileriGetir()
        {
            return sr1.ReadToEnd();
        }
    }
}
