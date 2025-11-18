

namespace Exercicio01
{
    public class Retangulo : IForma
    {
        public float Altura;
        public float Largura;
        public void CalcularArea()
        {
           System.Console.WriteLine($"A área do retangulo é:{Largura * Altura}");
        }
    }
}