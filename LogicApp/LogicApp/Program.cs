bool isSateista = true;
bool hasSateenvarjo = false;

if (!isSateista)
{
    Console.WriteLine("Ei ole sateista!");
} else if (isSateista && !hasSateenvarjo)
{
    Console.WriteLine("Sateista, joten otetaan sateenvarjo käyttöön!");
    hasSateenvarjo = true;
} else if (hasSateenvarjo)
{
    Console.WriteLine("Sataa ja nyt on sateenvarjo käytössä!");
}

Console.ReadKey();