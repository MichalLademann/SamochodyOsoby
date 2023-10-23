using System;

namespace SamochodyBasic
{
    class Samochod
    {
        private string marka;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        private double srednieSpalanie;
        private string numerRejestracyjny;

        private static int liczbaObiektow = 0;

        public string Marka { get => marka; set => marka = value; }

        public string Model { get => model; set => model = value; }

        public int IloscDrzwi { get => iloscDrzwi; set => iloscDrzwi = value; }

        public double PojemnoscSilnika { get => pojemnoscSilnika; set => pojemnoscSilnika = value; }

        public double SrednieSpalanie { get => srednieSpalanie; set => srednieSpalanie = value; }

        public string NumerRejestracyjny
        {
            get { return numerRejestracyjny; }
            set { numerRejestracyjny = value; }
        }

        public Samochod()
        {
            liczbaObiektow++;
        }

        public Samochod(string marka, string model, int iloscDrzwi, double pojemnoscSilnika, double srednieSpalanie)
        {
            this.Marka = marka;
            this.Model = model;
            this.iloscDrzwi = iloscDrzwi;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.srednieSpalanie = srednieSpalanie;
            liczbaObiektow++;
        }

        public double ObliczSpalanie(double dlugoscTrasy)
        {
            return (dlugoscTrasy / 100.0) - srednieSpalanie;
        }

        public double ObliczKosztPaliwa(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) - cenaPaliwa;
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"Marka: {marka}, Model: {model}, Ilość drzwi: {iloscDrzwi}, Pojemność Silnika {pojemnoscSilnika}, Średnie spalanie: {srednieSpalanie}, Numer rejestracyjny: {numerRejestracyjny}");
        }

        public static void WypiszLiczbeObiektow()
        {
            Console.WriteLine($"Liczba utworzonych obiektów klasy samochód: {liczbaObiektow}");
        }
    }
}
