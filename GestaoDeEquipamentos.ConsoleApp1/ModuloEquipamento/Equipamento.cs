using GestaoDeEquipamentos.ConsoleApp.ModuloFabricante;

namespace GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;

public class Equipamento
{
    public int Id;
    public string Nome;
    public Fabricante Fabricante;
    public decimal PrecoAquisicao;
    public DateTime DataFabricacao;

    public string Validacao()
    {
        string erros = "";
        if (string.IsNullOrWhiteSpace(Nome))
            erros += "O campo 'Nome' não pode ser vazio.\n";

        if (Nome.Length < 3)
            erros += "O campo 'Nome' deve ter no mínimo 3 caracteres\n";

        if (PrecoAquisicao <= 0)
            erros += "O campo 'Preço de Aquisição' deve ser maior que zero\n";

        if (DataFabricacao > DateTime.Now)
            erros += "A data de fabricação não pode ser maior que a data atual\n";

        return erros;
    }

    public Equipamento(string nome, decimal precoAquisicao, DateTime dataFabricacao, Fabricante fabricante)
    {
        Nome = nome;
        PrecoAquisicao = precoAquisicao;
        DataFabricacao = dataFabricacao;
        Fabricante = fabricante;
    }

    public string ObterNumeroSerie()
    {
        string tresPrimeirosCaracteres = Nome.Substring(0, 3).ToUpper();

        return $"{tresPrimeirosCaracteres}-{Id}";
    }
}