/*Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. 
  A seguir, determine qual o quadrante ao qual pertence o ponto, 
  ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

Se o ponto estiver na origem, escreva a mensagem “Origem”.

Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

Entrada
A entrada contem as coordenadas de um ponto.

Saída
A saída deve apresentar o quadrante em que o ponto se encontra.

Exemplo de Entrada	Exemplo de Saída
4.5 -2.2                 Q4

0.1 0.1                  Q1

0.0 0.0                Origem

*/
using System;
namespace CoordenadasDeUmPonto
{
	class Program
	{
        static void Main(string[] args)
		{
            string[] arrValor = Console.ReadLine().Replace(",", ".").Split(' ');
            float x = float.Parse(arrValor[0]);
            float y = float.Parse(arrValor[1]);

            if (x != 0.0 || y != 0.0)
            {
                if (y == 0)
                {
                    Console.WriteLine("Eixo X");
                }
                else if (x == 0)
                {
                    Console.WriteLine("Eixo Y");
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Q2");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Q3");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Q4");
                }
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
	}
}
/*using System;
namespace CoordenadasDeUmPonto
{
    class Program
    {
        public static void Main()
        {
            string[] arrValor = Console.ReadLine().Replace(",", ".").Split(' ');
            float x = float.Parse(arrValor[0]);
            float y = float.Parse(arrValor[1]);

			if (x == 0.0 && y == 0.0)
			{
				Console.WriteLine("Origem");
			}
			else if (y == 0)
			{
				Console.WriteLine("Eixo X");
			}
			else if (x == 0)
			{
				Console.WriteLine("Eixo Y");
			}
			else if (x > 0 && y > 0)
			{
				Console.WriteLine("Q1");
			}
			else if (x < 0 && y > 0)
			{
				Console.WriteLine("Q2");
			}
			else if (x < 0 && y < 0)
			{
				Console.WriteLine("Q3");
			}
			else if (x > 0 && y < 0)
			{
				Console.WriteLine("Q4");
			}
    }
  }
}*/