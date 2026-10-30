using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
       // A >= 90
       // B >= 80
       // C >= 70
       // D >= 60
       // F < 60
        Console.Write("de 1 à 100 qual foi sua nota? ");
        string notaFinal = Console.ReadLine();
        int numeroNota = int.Parse(notaFinal);
        int notaResto = numeroNota % 10;
        string sinal = "";

        if (notaResto >= 7 && numeroNota >60)
        {
            sinal = "+";
        }
        else if (notaResto <3 && numeroNota >60)
        {
            sinal = "-";
        }
        else
        {
            sinal = "";
        }

       
        

        if(numeroNota >= 90)
        {
           if (notaResto >= 7)
            {
                sinal = "";
            }
            Console.WriteLine($"parabens você tirou nota A{sinal} você passou");
        }

        else if(numeroNota >= 80)
        {

            Console.WriteLine($"parabens você tirou nota B{sinal} você passou");
        }
        else if(numeroNota >= 70)
        {

            Console.WriteLine($"parabens você tirou nota C{sinal} você está na média");
        }
        else if(numeroNota >= 60)
        {

            Console.WriteLine($"parabens você tirou nota D{sinal} você passou na média");
        }
        else
        {
            Console.WriteLine("sua nota foi F, mais sorte na próxima tentativa");
        }
    }
}                                                                                                           