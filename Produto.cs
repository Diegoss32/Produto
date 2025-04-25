public class Produto{
public string? Nome { get; set;}
public int codigoProduto{get; set;}
public int quantidade{get; set;}
public double preco{get; set;}

public Produto(){}


public Produto(string nome, int codigoProduto, int quantidade, double preco)
{
    Nome = nome;
    this.codigoProduto = codigoProduto;
    this.quantidade = quantidade;
    this.preco = preco;
}
public double valorTotal (){
    return quantidade * preco;
}
public void AdicionaProduto(int quantidadeAdicional)
{
    if (quantidadeAdicional > 0)
    {
        quantidade += quantidadeAdicional;
        Console.WriteLine($"{quantidadeAdicional} unidades adicionadas ao produto '{Nome}'. Quantidade atual: {quantidade}");
    }
    else
    {
        Console.WriteLine("Quantidade inválida para adicionar.");
    }
}
public static Produto[] removeProduto(Produto[] produtos, int codigoParaRemover)
{
    List<Produto> listaAtualizada = new List<Produto>();

    foreach (var produto in produtos)
    {
        if (produto.codigoProduto != codigoParaRemover)
        {
            listaAtualizada.Add(produto);
        }
    }

    return listaAtualizada.ToArray();  // <- retorno garantido!
}
public void RemoverQuantidade(int quantidadeParaRemover)
{
    if (quantidadeParaRemover <= 0)
    {
        Console.WriteLine("Quantidade inválida.");
    }
    else if (quantidadeParaRemover > quantidade)
    {
        Console.WriteLine($"Quantidade insuficiente. Estoque atual: {quantidade}");
    }
    else
    {
        quantidade -= quantidadeParaRemover;
        Console.WriteLine($"Removido {quantidadeParaRemover} unidade(s) do produto '{Nome}'. Estoque atual: {quantidade}");
    }
}
public override string ToString()
{
    return $"Nome: {Nome}, Código: {codigoProduto}, Quantidade: {quantidade}, Preço:R$ {preco:C}, Valor Total:R$ {valorTotal():C}";
}
}