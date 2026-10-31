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
        string letra = "";

        
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
            else if (notaResto < 3)
            {
                sinal = "-";
            }
            else
            {
                sinal = "";
            }
            letra = "A";
            
        }

        else if(numeroNota >= 80)
        {

           letra = "B";
        }
        else if(numeroNota >= 70)
        {

            letra = "C";
        }
        else if(numeroNota >= 60)
        {

            letra = "D";
        }
        else
        {
            letra = "F";
        }
        

        if(numeroNota >= 80)
        {
            Console.WriteLine($"Parabéns Você tirou a nota {letra}{sinal}");
        }
        else if(numeroNota >=70 && numeroNota < 80)
        {
            Console.WriteLine($"Você tirou a nota {letra}{sinal} passou na média");
        }
        else if(numeroNota < 70)
        {
            Console.WriteLine($"Você tirou a nota {letra}{sinal} mais sorte na próxima vez");
        }
        else
        {
            Console.WriteLine($"Você tirou a nota {letra}{sinal} mais sorte na próxima vez");
        }
        
    }
}                                                                                                           