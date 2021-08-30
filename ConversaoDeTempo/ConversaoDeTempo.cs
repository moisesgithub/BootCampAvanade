using System;
class MinhaClasse
{
    static void Main(string[] args)
    {
        var timeInSeconds = int.Parse(Console.ReadLine());

        var hours = timeInSeconds / (60 * 60);
        timeInSeconds = timeInSeconds % (60 * 60);
        var minutes = timeInSeconds / 60;
        var seconds = timeInSeconds % 60;

        Console.WriteLine($"{hours}:{minutes}:{seconds}");
    }
}

/*using System;

    class MinhaClasse {
        static void Main(string[] args) {
            var timeInSeconds = int.Parse(Console.ReadLine());

       //continue a solucao
            var hours = ;
            timeInSeconds =  ;
            var minutes =   ;
            var seconds =    ;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }*/