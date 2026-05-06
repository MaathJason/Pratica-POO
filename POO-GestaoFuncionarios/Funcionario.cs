class Funcionario
{
    public Funcionario(string nomeFuncionario, string cargoFuncionario)
    {
        NomeFuncionario = nomeFuncionario;
        CargoFuncionario = cargoFuncionario;
    }

    public string NomeFuncionario { get; set; }
    public string CargoFuncionario { get; set; }


    public void InformacoesFuncionario()
    {
        Console.WriteLine($"Funcionário: {NomeFuncionario}");
        Console.WriteLine($"Cargo atual: {CargoFuncionario}");
    }

    public string Promover(string nomeCargo)
    {
        if (nomeCargo == CargoFuncionario)
            return "Erro: O cargo precisa ser diferente do atual!";

        if(!string.IsNullOrEmpty(nomeCargo))
        {
            CargoFuncionario = nomeCargo;

            return $"\nO funcionario {NomeFuncionario}, foi promovido para o cargo de {CargoFuncionario}";
        }

        return "Erro: Tente promover o funcionário novamente";
    }
}