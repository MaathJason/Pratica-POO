class ProdutoDigital
{
    public ProdutoDigital(string nome, double preco, InformacaoTecnica info)
    {
        NomeProdutoDigital = nome;
        PrecoProdutoDigital = preco;
        InfoTecnica = info;
    }

    public string NomeProdutoDigital { get; set; }
    public double PrecoProdutoDigital { get; set; }
    public InformacaoTecnica InfoTecnica { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {NomeProdutoDigital}");
        Console.WriteLine($"Preço: {PrecoProdutoDigital}");
        Console.WriteLine($"Tamanho: {InfoTecnica.TamanhoMB} MB");
        Console.WriteLine($"Sistema Operacional: {InfoTecnica.SistemaOperacional}");
    }

}