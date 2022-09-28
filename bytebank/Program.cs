using System;
using System.Globalization;
using bytebank;
using bytebank.Titular;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Boas Vindas ao seu banco, byteBank!");

        Cliente sarah = new Cliente();
        sarah.Nome = "Sarah Silva";
        sarah.Profissao = "Professora";
        sarah.Cpf = "11111111-12";

        Cliente ester = new Cliente();
        ester.Nome = "Ester Almeida";
        ester.Profissao = "Advogada";
        ester.Cpf = "868524125-32";        

        ContaCorrente contaAndre = new ContaCorrente(159, "152869-x");
        contaAndre.Titular = new Cliente();
        contaAndre.Titular.Nome = " André Pereira";
        contaAndre.Titular.Profissao = "Auxiliar Administrativo";
        contaAndre.saldo = 100;
        Console.WriteLine();
        Console.WriteLine("Dados dos Clientes Cadastrados");
        Console.WriteLine();
        Console.WriteLine(sarah.ToString());
        Console.WriteLine(ester.ToString());
        Console.WriteLine("Nome:" + contaAndre.Titular.Nome + ", CPF:" + contaAndre.Titular.Cpf
            + ", Profissão:" + contaAndre.Titular.Profissao);     
        Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);
        Console.WriteLine();
        Console.WriteLine("Dados das Conta");
        Console.WriteLine(contaAndre.ToString());
        Console.WriteLine("Total de Contas: " + ContaCorrente.TotalDeContasCriadas);
        Console.WriteLine();
        


        Console.ReadKey();

    }
}

