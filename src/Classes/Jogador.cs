namespace ConceitosReflection.Classes;

public class Jogador
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Idade { get; set; }
    public string Email{ get; set; }
    public int IdPersonagem{ get; set; }

    public Jogador(int id, string name, DateTime idade, string email, int idPersonagem)
    {
        Id = id;
        Name = name;
        Idade = idade;
        Email = email;
        IdPersonagem = idPersonagem;
    }

}

