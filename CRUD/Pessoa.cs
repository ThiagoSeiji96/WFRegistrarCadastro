namespace CRUD
{
    public class Pessoa
    {
        public Pessoa(int id, string nome, string email, string cPF)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CPF = cPF;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        public void Atualizar(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}