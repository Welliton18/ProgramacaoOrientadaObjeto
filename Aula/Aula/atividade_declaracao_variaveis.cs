﻿using Model;
using System;

class AtividadeDeclaracaoVariaveis {

    static void Main(){
        testeRepeticao oTeste = new testeRepeticao();
        oTeste.atividade_5();
        //primeiraAtividade();
        /*
        bool bOk = true;
        bool bNotOk = false;

        Console.WriteLine("Valor ok: " + bOk);
        Console.WriteLine("Valor ok: " + bNotOk);
        Console.ReadKey();*/
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
