using System;
class URI
{
    static void Main(string[] args)
    {
        int[] contador = new int[3];
        int cod;
        do
        {
            cod  = Convert.ToInt32(Console.ReadLine());

            switch (cod)
            {
                case 1:
                    contador[0]++;
                        break;
                case 2:
                    contador[1]++;
                    break;
                case 3:
                    contador[2]++;
                    break;
                case 4:
                    break;
                default:
                    continue;
            }
        }
        while (cod != 4 );

        Console.WriteLine("Muito Obrigado!");
        Console.WriteLine("Alcool: " + contador[0]);
        Console.WriteLine("Gasolina: " + contador[1]);
        Console.WriteLine("Diesel: " + contador[2]);
    }
}

/*using System; 

class URI {

    static void Main(string[] args) { 

            do
            {
                
                 = Convert.ToInt32(Console.ReadLine());
                
                switch ()
                {
                    case 1:
                     
                    case 2:
                      
                    case 3:
                        
                    case 4:
                   
                        break;
                    default:                       
                        continue;
                }
            }
       
         while ( );

    }

}*/