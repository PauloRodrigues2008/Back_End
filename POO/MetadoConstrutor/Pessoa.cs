
namespace MetadoConstrutor
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade = 0;

        // metedo construtor de Pessoa, possuindo parametros 
        // Parametros representa os valores para as suas respctivas props
        //ou seja, estamos inicializando valores para as props
        //nome e idade

        public Pessoa(string n,int i)
        {
            Nome = n; // inicializar com o valor de n
            Idade = i;  // inicializar com o valor de i
        }

        public void ExibirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}, Idade:{Idade}");
        }

    }
}