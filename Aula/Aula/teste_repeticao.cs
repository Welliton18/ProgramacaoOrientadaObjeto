using System;

class testeRepeticao {

    public void atividade_1() {

        /*
         * Vamos utilizar o condicional if para atender as seguintes especificacoes:
         * - Quando o sexo for masculino (M) imprimir:
         *    O Senhor <nome da pessoa>  e portador do rg... 
         * - Quando o sexo for feminino (F) imprimir:
         *    A Senhora <nome da pessoa> e portadora do rg ..
         * - Quando o sexo for invalido (diferente de F ou M) imprimir:
         *    O Senhor(a) <nome da pessoa> e portador(a)
         * - Quando a pessoa for CLT imprimir:
         *    esta registrado com o salario de R$ <salario>
         * - Quando a pessoa for Autonoma imprimir:
         *    foi contratado pelo valor de R$ <salario>
         */
        // Declaracao das variaveis
        String nome;
        String dataNascimento;
        String rg;
        String textNome;
        char sexo; // UTILIZE 'M' para MASCULINO e 'F' para FEMININO
        double salario;
        bool clt;

        Console.WriteLine("Qual o seu nome?");
        nome = Console.ReadLine();
        Console.WriteLine("Qual a sua data de Nascimento?");
        dataNascimento = Console.ReadLine();
        Console.WriteLine("Qual seu RG?");
        rg = Console.ReadLine();
        Console.WriteLine("Qual o Seu Sexo?(M ou F)");
        sexo = char.Parse(Console.ReadLine());
        Console.WriteLine("Qual seu Salário?");
        salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Você é CLT?");
        if(Console.ReadLine() == "Sim")
            clt = true;
        else
            clt = false;

        if(Char.Equals(sexo, "M")) {
            textNome = "A Senhora " + nome + ", ";
        } else {
            textNome = "O Senhor " + nome + ", ";
        }
        String textRg = "portador(a)do rg de numero " + rg + ", \n";
        String textNasc = " nascido em " + dataNascimento + ", ";
        String textSexo = " do sexo " + sexo + ", ";
        String textS = " esta registrado com o salario de R$ " + salario;
        Console.WriteLine(textNome + textRg + textNasc + textSexo + textS);

    }


    public void atividade_2() {
        /*
         * 
         * 1) Trocar a estrutura de if else utilizada para tratamento de masculino e feminino por um switch
         * 
         */
        String nome;
        String dataNascimento;
        String rg;
        String textNome;
        char sexo; // UTILIZE 'M' para MASCULINO e 'F' para FEMININO
        double salario;
        bool clt;

        Console.WriteLine("Qual o seu nome?");
        nome = Console.ReadLine();
        Console.WriteLine("Qual a sua data de Nascimento?");
        dataNascimento = Console.ReadLine();
        Console.WriteLine("Qual seu RG?");
        rg = Console.ReadLine();
        Console.WriteLine("Qual o Seu Sexo?(M ou F)");
        sexo = char.Parse(Console.ReadLine());
        Console.WriteLine("Qual seu Salário?");
        salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Você é CLT?");
        if(Console.ReadLine() == "Sim")
            clt = true;
        else
            clt = false;

        switch(sexo) {
            case 'F':
                textNome = "A Senhora " + nome + ", ";
                break;
            default:
                textNome = "O Senhor " + nome + ", ";
                break;
        }

        String textRg = "portador(a)do rg de numero " + rg + ", \n";
        String textNasc = " nascido em " + dataNascimento + ", ";
        String textSexo = " do sexo " + sexo + ", ";
        String textS = " esta registrado com o salario de R$ " + salario;
        Console.WriteLine(textNome + textRg + textNasc + textSexo + textS);
    }

    public void atividade_3() {
        char sLetra = 'F';
        while(sLetra <= 'Z') {
            Console.WriteLine(sLetra++);
        }
    }

    public void atividade_4() {
        int iNumero = 100;
        while(iNumero <= 200) {
            if(iNumero % 2 == 0) {
                Console.WriteLine(iNumero + " é divisivel por 2 ");
            }
            if(iNumero % 3 == 0) {
                Console.WriteLine(iNumero + " é divisivel por 3 ");
            }
            if(iNumero % 2 == 0 && iNumero % 3 == 0) {
                Console.WriteLine(iNumero + " é divisivel por 2 e divisivel por 3 e portanto é divisivel por 6");
            }
            iNumero++;
        }
    }

    public void atividade_5() {
        int limiteInferior = 14;
        int limiteSuperior = 1578;
        int iCount = 0;

        while(limiteInferior <= limiteSuperior) {
            if(limiteInferior % 6 == 0) {
                iCount++;
            }
            limiteInferior++;
        }
        String texto = "Quantidade de numeros divisiveis por 6 entre ";
        Console.WriteLine(texto + limiteInferior + " é " + limiteSuperior + " e : " + iCount);

    }
}
