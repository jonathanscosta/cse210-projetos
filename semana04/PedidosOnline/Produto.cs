
using System;

public class Produto
{
    
    private string _nome;
    private string _idProduto;
    private decimal _preco;
    private int _quantidade;

    
    public Produto(string nome, string idProduto, decimal preco, int quantidade)
    {
        _nome = nome;
        _idProduto = idProduto;
        _preco = preco;
        _quantidade = quantidade;
    }

    
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

    
    public decimal CalcularCustoTotal()
    {
        return _preco * _quantidade;
    }
}
