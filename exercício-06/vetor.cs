// Criamos um array de 4 elementos e adicionamos os valores imediatamente
string[] jogosArray = new string[4] { "CS:GO", "Valorant", "CrossFire", "CS2" };

// Adiciomanos um foreach para percorrer o vetor é mostrar todos os jogos
foreach (var jogos in jogosArray)
{
    Console.WriteLine("Jogos de fps mais jogados: " + jogos);
}

Console.ReadLine();