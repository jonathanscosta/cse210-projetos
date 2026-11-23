
public class Endereco
{
    // Atributos privados
    private string _rua;
    private string _cidade;
    private string _estado;
    private string _pais;

    // Construtor
    public Endereco(string rua, string cidade, string estado, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }

    // Getters e Setters
    public string GetRua()
    {
        return _rua;
    }

    public void SetRua(string rua)
    {
        _rua = rua;
    }

    public string GetCidade()
    {
        return _cidade;
    }

    public void SetCidade(string cidade)
    {
        _cidade = cidade;
    }

    public string GetEstado()
    {
        return _estado;
    }

    public void SetEstado(string estado)
    {
        _estado = estado;
    }

    public string GetPais()
    {
        return _pais;
    }

    public void SetPais(string pais)
    {
        _pais = pais;
    }

    // Verifica se o endereço pertence aos Estados Unidos
    public bool EhNosEUA()
    {
        return _pais.Equals("USA", System.StringComparison.OrdinalIgnoreCase)
            || _pais.Equals("United States", System.StringComparison.OrdinalIgnoreCase);
    }

    // Retorna todos os dados do endereço
    public string ObterEnderecoCompleto()
    {
        return $"{_rua}\n{_cidade}, {_estado}\n{_pais}";
    }
}
