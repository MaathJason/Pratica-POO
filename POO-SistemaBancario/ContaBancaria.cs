class ContaBancaria
{
    public ContaBancaria(string conta, double saldo)
    {
        NumeroConta = conta;
        Saldo = saldo;
    }

    public string NumeroConta { get; set; }
    public double Saldo { get; set; }

    public void Depositar(double valor)
    {
        Saldo = valor;

        Console.WriteLine($"Conta: {NumeroConta}\nSaldo atual: {Saldo}");
    }
}