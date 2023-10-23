using System;
using System.Collections.Generic;

namespace SamochodyBasic
{
    class Garaz
    {
        private string adres;
        private int pojemnosc;
        private List<Samochod> samochody = new List<Samochod>();
        private int liczbaSamochodow = 0;

        public Garaz()
        {
            this.adres = "nieznany";
            this.pojemnosc = 0;
        }

        public Garaz(string adres, int pojemnosc)
        {
            this.adres = adres;
            this.pojemnosc = pojemnosc;
        }

        public int Pojemnosc
        {
            get { return this.pojemnosc; }
            set { this.pojemnosc = value; }
        }

        public string Adres
        {
            get { return this.adres; }
            set { this.adres = value; }
        }

        public void WprowadzSamochod(Samochod nowySamochod)
        {
            if (this.liczbaSamochodow <= this.pojemnosc)
            {
                this.samochody.Add(nowySamochod);
                this.liczbaSamochodow++;
            }
            else
            {
                Console.WriteLine("Garaż jest pełny. Nie można wprowadzić samochodu.");
            }
        }

        public Samochod WyprowadzSamochod()
        {
            if (this.liczbaSamochodow > 0)
            {
                Samochod ostatniSamochod = samochody[liczbaSamochodow - 1];
                this.samochody.RemoveAt(this.liczbaSamochodow - 1);
                this.liczbaSamochodow--;
                return ostatniSamochod;
            }
            else
            {
                Console.WriteLine("Garaż jest pusty. Nie można wyprowadzić samochodu.");
                return null;
            }
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"Adres garażu: {this.adres}");
            Console.WriteLine($"Pojemnosc garażu: {this.pojemnosc}");
            Console.WriteLine($"Liczba Samochodow w garażu: {this.liczbaSamochodow}");

            Console.WriteLine("Samochody w garażu:");
            foreach (Samochod s in this.samochody)
            {
                s.WypiszInfo();
            }
        }
    }
}
