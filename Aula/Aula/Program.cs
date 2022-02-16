using System;

namespace Aula {
    class Atividade {

        static void Main(){
            string sNome;
            string sDataNascimento;
            string sRg;
            char sSexo;
            double iSalario;

            Console.WriteLine("Qual o seu Nome?");
            sNome = Console.ReadLine();

            Console.WriteLine("Qual sua Data de nascimento?");
            sDataNascimento = Console.ReadLine();

            Console.WriteLine("Qual o seu RG?");
            sRg = Console.ReadLine();

            Console.WriteLine("Qual o seu Sexo(M ou F)?");
            sSexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu Salário?");
            iSalario = double.Parse(Console.ReadLine());

            Console.WriteLine("O Senhor(a) " + sNome + ", portador(a) do RG de número " + sRg +
                               ", nascido em " + sDataNascimento + ", do sexo (" + sSexo + "), está registrado com o salário de R$" + iSalario + ".");
        }
    }
}
