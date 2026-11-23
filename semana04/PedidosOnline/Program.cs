using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Olá, Mundo! Este é o Projeto PedidosOnline.");
         
        CultureInfo cultura = CultureInfo.GetCultureInfo("en-US");

        
        
      

        
        Endereco endereco1 = new Endereco(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

     
        Cliente cliente1 = new Cliente("John Smith", endereco1);

       
        Pedido pedido1 = new Pedido(cliente1);

       
        Produto produto1 = new Produto("Notebook", "P001", 800, 1);
        Produto produto2 = new Produto("Mouse", "P002", 25, 2);
        Produto produto3 = new Produto("Keyboard", "P003", 50, 1);

        
        pedido1.AdicionarProduto(produto1);
        pedido1.AdicionarProduto(produto2);
        pedido1.AdicionarProduto(produto3);

       
        Console.WriteLine("__________________________________");
        Console.WriteLine("          PRIMEIRO PEDIDO");
        Console.WriteLine("__________________________________");

        Console.WriteLine(pedido1.GerarEtiquetaEmbalagem());

        Console.WriteLine(pedido1.GerarEtiquetaEnvio());

        Console.WriteLine("Total do pedido: " +
            pedido1.CalcularTotal().ToString("C", cultura));


        
        
        

        
        Endereco endereco2 = new Endereco(
            "Rua das Flores, 250",
            "Fortaleza",
            "Ceará",
            "Brasil"
        );

        
        Cliente cliente2 = new Cliente("Maria Silva", endereco2);

      
        Pedido pedido2 = new Pedido(cliente2);

        // Criando os produtos
        Produto produto4 = new Produto("Smartphone", "P004", 500, 1);
        Produto produto5 = new Produto("Headphone", "P005", 75, 2);

        
        pedido2.AdicionarProduto(produto4);
        pedido2.AdicionarProduto(produto5);

        
        Console.WriteLine("\n________________________________");
        Console.WriteLine("          SEGUNDO PEDIDO");
        Console.WriteLine("________________________________");

        Console.WriteLine(pedido2.GerarEtiquetaEmbalagem());

        Console.WriteLine(pedido2.GerarEtiquetaEnvio());

        Console.WriteLine("Total do pedido: " +
            pedido2.CalcularTotal().ToString("C", cultura));

        Console.WriteLine("\nFim dos pedidos!");
    }
}
    
