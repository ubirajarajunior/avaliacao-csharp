namespace Avaliacao_Pratica.Entidades
{
    class Contato
    {
        public int Celular { get; set; }
        public int Id { get; set; }
        public int Telefone { get; set; }
        public Periodo Vigencia { get; set; }

        public Contato(int celular, int id, int telefone, Periodo vigencia)
        {
            Celular = celular;
            Id = id;
            Telefone = telefone;
            Vigencia = vigencia;
        }
    }
}
