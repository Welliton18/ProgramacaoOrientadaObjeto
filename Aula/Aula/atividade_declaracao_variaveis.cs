using Model;
using System;

class AtividadeDeclaracaoVariaveis {

    static void Main(){
        testeRepeticao oRepeticao = new testeRepeticao();

        //oRepeticao.atividade_1();
        //oRepeticao.atividade_2();
        //oRepeticao.atividade_3();
        //oRepeticao.atividade_4();
        //oRepeticao.atividade_5();

        atividadeArray oAtividadeArray = new atividadeArray();
        Console.WriteLine("Atividade 1:");
        oAtividadeArray.atividade_1();

        Console.WriteLine("");
        Console.WriteLine("Atividade 2:");
        oAtividadeArray.atividade_2();

        Console.WriteLine("");
        Console.WriteLine("Atividade 3:");
        oAtividadeArray.atividade_3();
    }

    static void primeiraAtividade() {
        ModelPessoa oPessoa = new ModelPessoa();

        Console.WriteLine("Qual o seu Nome?");
        oPessoa.Nome = Console.ReadLine();

        Console.WriteLine("Qual sua Data de nascimento?");
        oPessoa.DataNascimento = Console.ReadLine();

        Console.WriteLine("Qual o seu RG?");
        oPessoa.Rg = Console.ReadLine();

        Console.WriteLine("Qual o seu Sexo(M ou F)?");
        oPessoa.Sexo = char.Parse(Console.ReadLine());

        Console.WriteLine("Qual o seu Salário?");
        oPessoa.Salario = double.Parse(Console.ReadLine());

        Console.WriteLine("O Senhor(a) " + oPessoa.Nome + ", portador(a) do RG de número " + oPessoa.Rg +
                            ", nascido em " + oPessoa.DataNascimento + ", do sexo (" + oPessoa.Sexo +
                            "), está registrado com o salário de R$" + oPessoa.Salario + ".");
    }

}
