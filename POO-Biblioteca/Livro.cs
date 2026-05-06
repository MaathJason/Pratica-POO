class Livro
{
    public Livro(string Titulo, string Autor)
    {
        LivroTitulo = Titulo;
        LivroAutor = Autor;
    }
    public string LivroTitulo { get; set; }
    public string LivroAutor { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Titulo do livro: {LivroTitulo}\n");
        Console.WriteLine($"Autor do livro: {LivroAutor}");
    }
}