
using System;

public class Produto
{
    // Atributos privados: protegidos pelo encapsulamento
    private string _nome;
    private string _idProduto;
    private decimal _preco;
    private int _quantidade;

    // Construtor: recebe os dados para criar um produto
    public Produto(string nome, string idProduto, decimal preco, int quantidade)
    {
        _nome = nome;
        _idProduto = idProduto;
        _preco = preco;
        _quantidade = quantidade;
    }

    // Getters e Setters
    public string GetNome()
    {
        return _nome;
    }

    public void SetNome(string nome)
    {
        _nome = nome;
    }

    public string GetIdProduto()
    {
        return _idProduto;
    }

    public void SetIdProduto(string idProduto)
    {
        _idProduto = idProduto;
    }

    public decimal GetPreco()
    {
        return _preco;
    }

    public void SetPreco(decimal preco)
    {
        _preco = preco;
    }

    public int GetQuantidade()
    {
        return _quantidade;
    }

    public void SetQuantidade(int quantidade)
    {
        _quantidade = quantidade;
    }

    // Calcula o custo total do produto
    public decimal CalcularCustoTotal()
    {
        return _preco * _quantidade;
    }
}
