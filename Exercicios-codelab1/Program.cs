using System;
using System.Collections.Generic;
//Exercicio 1 - Fatorial de um número
Console.WriteLine("Informe um número para que o fatorial seja calculado: ");
int numFatorial = Convert.ToInt32(Console.ReadLine());
int multiplicador = numFatorial;
int resultado = numFatorial;
while (multiplicador > 1)
{
  resultado *= --multiplicador;
}

Console.WriteLine($"O fatorial de {numFatorial} é: {resultado}");


//Exercicio 2 - Lista de números

Console.WriteLine("Quantos números você deseja adicionar?");
int tamanho = Convert.ToInt32(Console.ReadLine());
int[] valores = new int[tamanho];

for (int i = 0; i < tamanho; i++)
{
  Console.WriteLine($"Adicione o {i + 1}º valor");
  valores[i] = Convert.ToInt32(Console.ReadLine());
}
