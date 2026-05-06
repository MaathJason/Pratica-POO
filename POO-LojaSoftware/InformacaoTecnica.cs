class InformacaoTecnica
{
    public InformacaoTecnica(int tamanhoMb, string sistemaOperacional)
    {
        TamanhoMB = tamanhoMb;
        SistemaOperacional = sistemaOperacional;
    }

    public int TamanhoMB { get; set; }
    public string SistemaOperacional { get; set; }
}