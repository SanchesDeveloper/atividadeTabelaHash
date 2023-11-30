using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> tabelaHash = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("1. Inserir par Chave-Valor");
            Console.WriteLine("2. Exibir todos os dados");
            Console.WriteLine("3. Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    InserirDados(tabelaHash);
                    break;
                case "2":
                    ExibirDados(tabelaHash);
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void InserirDados(Dictionary<string, string> tabelaHash)
    {
        Console.Write("Insira o CPF: ");
        string cpf = Console.ReadLine();

        if (tabelaHash.ContainsKey(cpf))
        {
            Console.WriteLine("CPF já inserido. Tente novamente.");
            return;
        }

        Console.Write("Insira o Nome: ");
        string nome = Console.ReadLine();

        tabelaHash.Add(cpf, nome);
        Console.WriteLine("Dados inseridos com sucesso!");
    }

    static void ExibirDados(Dictionary<string, string> tabelaHash)
    {
        if (tabelaHash.Count == 0)
        {
            Console.WriteLine("Nenhum dado inserido ainda.");
            return;
        }

        Console.WriteLine("Dados armazenados:");

        foreach (var par in tabelaHash)
        {
            Console.WriteLine($"CPF: {par.Key}, Nome: {par.Value}");
        }
    }
}