using System.Globalization;

// Laskin toiminto

// datatyyppi muuttujaNimi = alkuarvo;
double munNumero1 = 0;
double munNumero2 = 0;

Console.Write("Anna eka numero: ");
string kayttajanSyote = Console.ReadLine();

munNumero1 = double.Parse(kayttajanSyote, CultureInfo.InvariantCulture);

Console.Write("Anna toka numero: "); 
kayttajanSyote = Console.ReadLine();

munNumero2 = double.Parse(kayttajanSyote, CultureInfo.InvariantCulture);

double summa = munNumero1 + munNumero2;

Console.WriteLine($"{munNumero1} -numeron ja {munNumero2} -numeron summatulos on {summa}");
Console.ReadKey();