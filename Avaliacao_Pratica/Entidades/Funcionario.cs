using System;
using System.Globalization;
namespace Avaliacao_Pratica.Entidades
{
    class Funcionario : PessoaFisica
    {
        public DateTime DataContratacao { get; set; }
        public double Salario { get; set; }

        public Funcionario(string cpf, DateTime dataNascimento, int idade, DateTime dataContratacao, double salario)
            : base(cpf, dataNascimento, idade)
        {
            DataContratacao = dataContratacao;
            Salario = salario;
        }
    }
}
