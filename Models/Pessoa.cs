namespace Hospedes.Models
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string? Sobrenome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }   
        public Pessoa(string nome, string? sobrenome) : this(nome)
        {
            Sobrenome = sobrenome;
        }
    }
}
