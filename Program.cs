using SamochodyBasic;

Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0);
Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);

Garaz g1 = new Garaz("ul. Garażowa 1", 1);
Garaz g2 = new Garaz("ul. Garażowa 2", 2);

Osoba o1 = new Osoba("Jan", "Kowalski");
Osoba o2 = new Osoba("Anna", "Nowak");

g1.WprowadzSamochod(s1);
g2.WprowadzSamochod(s2);

o1.DodajSamochod("ABC123");
o2.DodajSamochod("DEF456");

Console.WriteLine("Informacje o garażu g1:");
g1.WypiszInfo();

Console.WriteLine("\nInformacje o garażu g2:");
g2.WypiszInfo();

Console.WriteLine("\nInformacje o osobie o1:");
o1.WypiszInfo();

Console.WriteLine("\nInformacje o osobie o2:");
o2.WypiszInfo();

Console.ReadKey();