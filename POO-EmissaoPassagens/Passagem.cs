class Passagem
{
    public Passagem(string passageiro, string destino)
    {
        Passageiro = passageiro;
        Destino = destino;
    }

    public string Passageiro { get; set; }
    public string Destino { get; set; }

    public void ExibirPassagem()
    {
        Console.WriteLine($"Passageiro: {Passageiro}");
        Console.WriteLine($"\nDestino: {Destino}");
    }
}