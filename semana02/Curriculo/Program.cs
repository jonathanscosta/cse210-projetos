using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Olá, Mundo! Este é o Projeto Curriculo.");
        Curriculo meuCuriculo = new Curriculo();

        meuCuriculo._nome = "Jonathan";

        Emprego emprego1 = new Emprego();

        emprego1._empresa = "microsoft";
        emprego1._cargo = "Desenvolvedor";
        emprego1._anoInicio = 2026;
        emprego1._anoFim = 2030;

        Emprego emprego2 = new Emprego();
        emprego2._empresa = "Google";
        emprego2._cargo = "Desenvolvedor";
        emprego2._anoInicio = 2030;
        emprego2._anoFim = 2040;


        meuCuriculo._empregos.Add(emprego1);
        meuCuriculo._empregos.Add(emprego2);

        meuCuriculo.Exibir();
    }
}