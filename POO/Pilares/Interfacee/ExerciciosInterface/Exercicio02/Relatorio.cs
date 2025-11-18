

namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string Nome = "";
        public string textoRelatorio = "";


        public Relatorio(string responsavel, string textoRelatorio)
        {
            Nome = responsavel;
            textoRelatorio = textoRelatorio;
        }
        
        public void Imprimir()
        {
            System.Console.WriteLine($"Responsável: {Nome}...");
            System.Console.WriteLine(textoRelatorio);
            System.Console.WriteLine($"--");
        }
    }
}