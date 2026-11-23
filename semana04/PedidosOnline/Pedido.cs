
using System.Collections.Generic;
using System.Text;

public class Pedido
{
    // Atributos privados
    private List<Produto> _produtos;
    private Cliente _cliente;

    // Construtor
    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    // Adiciona um produto ao pedido
    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    // Getter do cliente
    public Cliente GetCliente()
    {
        return _cliente;
    }

    // Setter do cliente
    public void SetCliente(Cliente cliente)
    {
        _cliente = cliente;
    }

    // Calcula o custo total dos produtos
    // e adiciona o valor único do envio
    public decimal CalcularTotal()
    {
        decimal total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.CalcularCustoTotal();
        }

        // Define o custo do envio
        if (_cliente.MoraNosEUA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    // Gera a etiqueta de embalagem
    public string GerarEtiquetaEmbalagem()
    {
        StringBuilder etiqueta = new StringBuilder();

        etiqueta.AppendLine("ETIQUETA DE EMBALAGEM");
        etiqueta.AppendLine("------------------------------");

        foreach (Produto produto in _produtos)
        {
            etiqueta.AppendLine(
                $"Produto: {produto.GetNome()} | ID: {produto.GetIdProduto()}");
        }

        return etiqueta.ToString();
    }

    // Gera a etiqueta de envio
    public string GerarEtiquetaEnvio()
    {
        StringBuilder etiqueta = new StringBuilder();

        etiqueta.AppendLine("ETIQUETA DE ENVIO");
        etiqueta.AppendLine("------------------------------");
        etiqueta.AppendLine($"Cliente: {_cliente.GetNome()}");
        etiqueta.AppendLine(_cliente.GetEndereco().ObterEnderecoCompleto());

        return etiqueta.ToString();
    }
}
