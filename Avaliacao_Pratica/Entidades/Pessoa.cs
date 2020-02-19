using System.Collections.Generic;

namespace Avaliacao_Pratica.Entidades
{
    abstract class Pessoa
    {
        public string Enderecos { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Contato>Lista_Contatos { get; set; }
    }
}
