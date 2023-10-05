# una-lista-06-csharp

## Una Betim
### Turma de Ciência da computação, turno da noite
- Integrantes do grupo:
- Arthur Batista Ra: 622122110
- Rafael Mundim  Ra: 622120488
- Gabryel Júnio  Ra: 622221044
- Pedro Lara     Ra: 622121264
- Ryan Augusto   Ra: 62112295
- Rodrigo Duarte Ra: 62110491
  
- Exercício 6 😄⚡

Explique o que é um vetor, uma matriz e um cubo em estrutura de dados.
```
As estuturas de dados são formas de armazenamento e organização de dados na memória de um computador para ser usado de forma mais eficiente, no caso dos vetores, matrizes e os cubos são uma estrutura homogênea que são chamadas de arrays fazendo ser possível acessar elementos individuas através da posição de índice.
Os arrays são separados em tipos:
Unidimensional: Vetor
Cada elemento é acessado por um índice que representa sua posição no vetor.
Bidimensional: Matriz
Armazena elementos organizados em linhas e colunas, sendo acessados por dois índices, um para a linha e outro para a coluna.
Tridimensional: Cubo;
Os elementos de um cubo são acessados por três índices.
```
Escreva em C# exemplos de um vetor e de uma matriz
### Exemplo de vetor
```
// Criamos um array de 4 elementos e adicionamos os valores imediatamente
string[] jogosArray = new string[4] { "CS:GO", "Valorant", "CrossFire", "CS2" };

// Adiciomanos um foreach para percorrer o vetor é mostrar todos os jogos
foreach (var jogos in jogosArray)
{
    Console.WriteLine("Jogos de fps mais jogados: " + jogos);
}

Console.ReadLine();
```
### Exemplo de matriz
```
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
```
// Por exemplo se eu especificar o valor na matrix na posição de linha 0 e coluna 1, vai ser o 96
Console.WriteLine("Valor [0,1] da matriz: " + matrizArray[0, 1]);

Console.ReadLine();

 
