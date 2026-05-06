class Filme
{
    public Filme(string titulo, int classificacaoEtaria)
    {
        Titulo = titulo;
        ClassificacaoEtaria = classificacaoEtaria;
    }

    public string Titulo { get; set; }
    public int ClassificacaoEtaria { get; set; }

    private bool PodeAssistir(int idade)
    {
        if(idade < ClassificacaoEtaria)
            return false;
        else 
            return true;
    }

    public string ExibirResultado(int idadeUsuario)
    {
        if (!PodeAssistir(idadeUsuario))
            return $"Usuários com {idadeUsuario} não podem assistir ao filme {Titulo}";
        else 
            return $"Usuários com {idadeUsuario} podem assistir ao filme {Titulo}";

    }
}