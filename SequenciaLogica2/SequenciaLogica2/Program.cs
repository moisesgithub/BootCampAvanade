/*Desafio
Você terá desafio de escrever um programa que leia dois valores X e Y. 
A seguir, mostre uma sequência de 1 até Y, passando para a próxima linha a cada X números.

Entrada
O arquivo de entrada contém dois valores inteiros, (1 < X < 20) e (X < Y < 100000).

Saída
Cada sequência deve ser impressa em uma linha apenas, com 1 espaço em branco entre cada número, 
conforme exemplo abaixo. Não deve haver espaço em branco após o último valor da linha.

 
Exemplo de Entrada	
3 99
Exemplo de Saída
1 2 3
4 5 6
7 8 9
10 11 12
...
97 98 99

*/
using System;
namespace SequenciaLogica2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            for (int i = 1; i <= int.Parse(vet[1]); i++)
            {
                Console.Write(i);

                int x = int.Parse(vet[0]);
                if (i % x == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}

/*using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = ;
           
            //complete o código com sua solução

            for (                )
            {
                Console.Write(i);
                if (             )
                {
                    Console.WriteLine( );
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }*/