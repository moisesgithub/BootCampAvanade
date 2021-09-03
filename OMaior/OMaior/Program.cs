using System;
class Program
{    
    static void Main(string[] args)
    {        
        string[] vet = Console.ReadLine().Split(' ');

        int MAIORAB = (int.Parse(vet[0]) + int.Parse(vet[1]) 
                    + Math.Abs(int.Parse(vet[0]) 
                    - int.Parse(vet[1]))) / 2;

        int MAIOR = (MAIORAB + int.Parse(vet[2]) 
                  + Math.Abs(MAIORAB 
                  - int.Parse(vet[2]))) / 2;

        Console.WriteLine($"{MAIOR} eh o maior");
    }    
}

/*using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            //complete declarando as variáveis

            int MAIORAB = (                )/2;

            int MAIOR = (                ) / 2;

            Console.WriteLine($"{MAIOR} eh o maior");
                        
        }
    }*/