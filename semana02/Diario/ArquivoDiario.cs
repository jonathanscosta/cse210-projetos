using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class ArquivoDiario
{
    private string _caminhoArquivo;

    public ArquivoDiario(string caminhoArquivo)
    {
        _caminhoArquivo = caminhoArquivo;
    }

    public void Salvar(List<Registro> entradas)
    {
        string json = JsonSerializer.Serialize(
            entradas,
            new JsonSerializerOptions { WriteIndented = true }
        );

        File.WriteAllText(_caminhoArquivo, json);

        Console.WriteLine("Diário salvo com sucesso!");
    }

    public List<Registro> Carregar()
    {
        if (!File.Exists(_caminhoArquivo))
        {
            Console.WriteLine("Nenhum arquivo de diário foi encontrado.");
            return new List<Registro>();
        }

        string json = File.ReadAllText(_caminhoArquivo);

        List<Registro> entradas =
            JsonSerializer.Deserialize<List<Registro>>(json);

        return entradas ?? new List<Registro>();
    }
}