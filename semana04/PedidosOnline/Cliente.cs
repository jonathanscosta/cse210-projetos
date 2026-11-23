
public class Cliente
{
    // Atributos privados
    private string _nome;
    private Endereco _endereco;

    // Construtor
    public Cliente(string nome, Endereco endereco)
    {
        _nome = nome;
        _endereco = endereco;
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

    public Endereco GetEndereco()
    {
        return _endereco;
    }

    public void SetEndereco(Endereco endereco)
    {
        _endereco = endereco;
    }

    // Verifica se o cliente mora nos EUA
    public bool MoraNosEUA()
    {
        return _endereco.EhNosEUA();
    }
}
