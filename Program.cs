// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

Produto p = new Produto();
Console.WriteLine("Bem-vindo ao sistema de gerenciamento de produtos!");
Console.Write("digite quantos produtos ira cadastra: ");
int n= int.Parse(Console.ReadLine()!);
Produto[] produtos = new Produto[n];
for(int i = 0; i < n; i++){
    Console.Write("digite o nome do produto: ");
    string? Nome = Console.ReadLine();

    Console.Write("digite o codigo do produto: ");
    int codigoProduto = int.Parse(Console.ReadLine()!);

    Console.Write("digite a quantidade do produto: ");
    int quantidade = int.Parse(Console.ReadLine()!);    

    Console.Write("digite o preco do produto: ");
    double preco = double.Parse(Console.ReadLine()!);   

    produtos[i] = new Produto(Nome, codigoProduto, quantidade, preco);
    Console.WriteLine($"Produto {i + 1} cadastrado com sucesso!");
    Console.WriteLine("--------------------------");
}

Console.WriteLine("\nLista de produtos cadastrados:");
foreach (var produto in produtos)
{
    Console.WriteLine(produto);
}


Console.WriteLine("--------------------------");
while (true)
{
        Console.WriteLine("Menu:");
        Console.WriteLine("1 - Adicionar produto ao estoque");
        Console.WriteLine("2 - Remover produto inteiro");
        Console.WriteLine("3 - Remover quantidade de produto");
        Console.WriteLine("4 - Exibir produtos");
        Console.WriteLine("5 - Sair");
        Console.Write("Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine()!);

    if (opcao == 1)
    {
        Console.Write("Digite o código do produto para adicionar ao estoque: ");
        int codigo = int.Parse(Console.ReadLine()!);

        Console.Write("Digite a quantidade a ser adicionada: ");
        int quantidadeAdicionar = int.Parse(Console.ReadLine()!);

       
        foreach (var produto in produtos)
        {
            if (produto.codigoProduto == codigo)
            {
                produto.AdicionaProduto(quantidadeAdicionar);
                break;
            }
        }
    }
    else if (opcao == 2)
    {
        Console.Write("Digite o código do produto que deseja remover: ");
        int codigoRemover = int.Parse(Console.ReadLine()!);

        produtos = Produto.removeProduto(produtos, codigoRemover);
    }
    else if (opcao == 3)
    {
        Console.Write("Digite o código do produto: ");
        int codigo = int.Parse(Console.ReadLine()!);

        Console.Write("Digite a quantidade a ser removida: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        
        foreach (var produto in produtos)
        {
            if (produto.codigoProduto == codigo)
            {
                produto.RemoverQuantidade(quantidade);
                break;
            }
        }
    }
    else if (opcao == 4)
    {
        
        Console.WriteLine("\nLista de produtos cadastrados:");
        foreach (var produto in produtos)
        {
            Console.WriteLine(produto);
        }
    }
    else if (opcao == 5)
    {
        break; 
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
    }

    Console.WriteLine(); 
}


Console.WriteLine("\nLista de produtos cadastrados:");
foreach (var produto in produtos)
{
    Console.WriteLine(produto);
}