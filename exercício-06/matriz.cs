// Criamos um arrays multidimensional de 4 elementos na forma de 2x2(como se fosse um quadrado)
var matrizArray = new int[2, 2] { { 57, 96 }, { 73, 65 } };

// Vai percorrer os valores na matriz
foreach (var num in matrizArray)
{
    Console.WriteLine($"{num}");
}

Console.WriteLine("------------------------------");
// Por exemplo se eu especificar o valor na matrix na posição de linha 0 e coluna 1, vai ser o 96
Console.WriteLine("Valor [0,1] da matriz: " + matrizArray[0, 1]);

Console.ReadLine();