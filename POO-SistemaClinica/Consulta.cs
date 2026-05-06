class Consulta
{
    public Consulta(string paciente, string medico, DateTime data)
    {
        NomePaciente = paciente;
        NomeMedico = medico;
        DataConsulta = data;
    }

    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }
    public bool Reagendada { get; set; }

    public void Reagendar(DateTime dataReagendamento)
    {
        DataConsulta = dataReagendamento;
        Reagendada = true;
    }

    public void ExibirConsulta()
    {
        Console.WriteLine($"Consulta marcada com {NomeMedico} para o paciente {NomePaciente}");

        if(Reagendada)
            Console.WriteLine($"Nova Data: {DataConsulta.ToString("dd/MM/yy")}\n");
        else
            Console.WriteLine($"Data: {DataConsulta.ToString("dd/MM/yy")}\n");
    }
}