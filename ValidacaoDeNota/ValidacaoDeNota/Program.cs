using System;
class ValidacaoDeNota
{
    public static void Main()
    {
        double soma = 0;
        int contador = 0;

        do
        {
            double notaEntrada = double.Parse(Console.ReadLine());

            if (notaEntrada < 0 || notaEntrada > 10)
            {
                Console.WriteLine("nota invalida");
            }
            else
            {
                contador++;
                soma += notaEntrada;
            }
        } while (contador < 2);

        Console.WriteLine("media = " + (soma / 2).ToString("N2"));
    }
}

/*using System;

class Desafio {
  public static void Main() {
    double somaDasNotas = 0;
    int contador = 0;
      
    do {
      double notaEntradaConsole = double.Parse(Console.ReadLine());

      if(notaEntradaConsole < 0 || notaEntradaConsole > 10) {
        Console.WriteLine("nota invalida");
      } else {
        contador++;
        somaDasNotas += notaEntradaConsole; 
      }
    } while (contador < 2);
    
    Console.WriteLine("media = " + (somaDasNotas / 2).ToString("N2"));
  }
}*/