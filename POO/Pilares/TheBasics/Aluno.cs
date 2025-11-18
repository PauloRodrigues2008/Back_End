
namespace TheBasics
{
    public class Aluno : Pessoa
    {
        //Criar um construtor na classe aluno que recebe o endereço
        //e chama o construtor dsa classe mãe (base) e repassa o 
        //endereço para ela

        public Aluno(Endereco endereco) : base(endereco)
        {
        }
        public string RA;
        public float NotaFinal;
        public string Curso;
          
            
    }
}