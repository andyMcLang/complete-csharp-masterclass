// Laskin toiminto

// datatyyppi muuttujaNimi = alkuarvo;
int munNumero1 = 0;
int munNumero2 = 0;

Console.Write("Anna eka numero kokonaisena: ");
string kayttajanSyote = Console.ReadLine();

munNumero1 = int.Parse(kayttajanSyote);

Console.Write("Anna toka numero kokonaisena: "); 
kayttajanSyote = Console.ReadLine();

munNumero2 = int.Parse(kayttajanSyote);

int summa = munNumero1 + munNumero2;

Console.WriteLine($"'{munNumero1}' -numeron ja '{munNumero2}' -numeron summatulos on {summa}");
Console.ReadKey();