using System;
namespace Avaliacao_Pratica.Entidades
{
    class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }

        public PessoaFisica(string cpf, DateTime dataNascimento, int idade) 
        {
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Idade = idade;
        }
    }
}
