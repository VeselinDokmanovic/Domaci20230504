using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci20230504
{
    class Kontakti
    {
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private string glavniBroj;
        public string GlavniBroj
        {
            get { return glavniBroj; }
            set { glavniBroj = value; }
        }

        List<string> ostaliBrojevi = new List<string>();

        public Kontakti()
        {

        }
        public Kontakti(string ime, string prezime, string glavniBroj)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.glavniBroj = glavniBroj;
        }

        public bool DodajBroj(string dodatniBroj)
        {
            if(dodatniBroj == glavniBroj || ostaliBrojevi.Contains(dodatniBroj))
            return false;

            ostaliBrojevi.Add(dodatniBroj);
            return true;
        }
        public bool IzbrisiBroj(string dodatniBroj)
        {
            if(!ostaliBrojevi.Contains(dodatniBroj))
                return false;

            ostaliBrojevi.Remove(dodatniBroj);
            return true;
        }
        public override string ToString()
        {
            return $"{ime}, {prezime}, {glavniBroj}{IspisiOstaleBrojeve()}";
        }
        private string IspisiOstaleBrojeve()
        {
            int i = 0;
            string listaBrojeva = ", [";
            foreach (var item in ostaliBrojevi)
            {
                if (i == 0)
                    listaBrojeva += $"{item}";
                else 
                listaBrojeva += $", {item}";

                i++;
            }
            listaBrojeva += "]";
            return listaBrojeva;
        }

    }

}
