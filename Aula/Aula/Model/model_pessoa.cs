using System;
using System.Collections.Generic;
using System.Text;

namespace Model {
    class ModelPessoa {

        private string nome;
        private string dataNascimento;
        private string rg;
        private char sexo;
        private double salario;

        public string Nome { get => nome; set => nome = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Rg { get => rg; set => rg = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public double Salario { get => salario; set => salario = value; }
    }
}
