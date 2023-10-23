using System;
using System.Collections.Generic;

namespace SamochodyBasic
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private string[] numeryRejestracyjne = new string[3];
        private int liczbaSamochodow = 0;

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public string Imie
        {
            get { return this.imie; }
            set { this.imie = value; }
        }

        public string Nazwisko
        {
            get { return this.nazwisko; }
            set { this.nazwisko = value; }
        }

        public void DodajSamochod(string numerRejestracyjny)
        {
            if (liczbaSamochodow < 3)
            {
                numeryRejestracyjne[liczbaSamochodow] = numerRejestracyjny;
                liczbaSamochodow++;
            }
            else
            {
                Console.WriteLine("Nie można dodać więcej samochodów. Osiągnięto limit.");
            }
        }

        public bool UsunSamochod(string numerRejestracyjny)
        {
            for (int i = 0; i < liczbaSamochodow; i++)
            {
                if (numeryRejestracyjne[i] == numerRejestracyjny)
                {
                    numeryRejestracyjne[i] = null;
                    liczbaSamochodow--;
                    Console.WriteLine($"Samochód o numerze rejestracyjnym {numerRejestracyjny} został usunięty.");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            Console.WriteLine($"Nie znaleziono samochodu o numerze rejestracyjnym {numerRejestracyjny}.");
            return false;
        }

        public void WypiszInfo()
        {
            Console.WriteLine($"Osoba: {imie} {nazwisko}");
            Console.WriteLine($"Liczba posiadanych samochodów: {liczbaSamochodow}");
            Console.WriteLine("Numery rejestracyjne posiadanych samochodów:");
            for (int i = 0; i < liczbaSamochodow; i++)
            {
                Console.WriteLine($"{i + 1}. {numeryRejestracyjne[i]}");
            }
        }
    }
}
