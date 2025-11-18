namespace Exercicio_4
{
    public class Professor : Pessoa
    {
    public string Disciplina { get; set; }

    public Professor(string nome, int idade, string disciplina)
        : base(nome, idade)
    {
        Disciplina = disciplina;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Professor - Nome: {Nome}, Idade: {Idade}, Disciplina: {Disciplina}");
    }
    
    }
}