
using System.Collections.Generic;
using System.Text;

public class Pedido
{
  
    private List<Produto> _produtos;
    private Cliente _cliente;

    
    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    
    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }


    public Cliente GetCliente()
    {
        return _cliente;
    }

    
    public void SetCliente(Cliente cliente)
    {
        _cliente = cliente;
    }

   
    public decimal CalcularTotal()
    {
        decimal total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.CalcularCustoTotal();
        }

        
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

    
    public string GerarEtiquetaEmbalagem()
    {
        StringBuilder etiqueta = new StringBuilder();

        etiqueta.AppendLine("ETIQUETA DE EMBALAGEM");
        etiqueta.AppendLine("________________________________");

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
        etiqueta.AppendLine("________________________________");
        etiqueta.AppendLine($"Cliente: {_cliente.GetNome()}");
        etiqueta.AppendLine(_cliente.GetEndereco().ObterEnderecoCompleto());

        return etiqueta.ToString();
    }
}
