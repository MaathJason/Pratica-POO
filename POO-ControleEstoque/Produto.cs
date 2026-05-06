using System.Xml;

class Produto
{
    public Produto(string produto, int quantidadeInicial)
    {
        ProdutoNome = produto;
        QuantidadeEstoque = quantidadeInicial;
    }

    public string ProdutoNome { get; set; }
    private int QuantidadeEstoque {  get; set; }

    public string Retirar(int quantidadeProduto)
    {
        if (QuantidadeEstoque < quantidadeProduto)
            return $"Não foi possível reduzir a quantidade de {quantidadeProduto}. Estoque insuficiente";

        if(quantidadeProduto > 0)
        {
            int quantidadeEstoque = QuantidadeEstoque - quantidadeProduto;

            QuantidadeEstoque = quantidadeEstoque;

            return "Operação efetuada com sucesso";
        }

        return "Não foi possível efetuar a retirada. Tente novamente.";
    }

    public string ExibirEstoque()
    {
        return $"Produto: {ProdutoNome}\nEstoque: {QuantidadeEstoque}";
    }
}