

namespace Exemplos
{
    public class Pessoal : Animal
    {
        public override void FazerSom()
        {
           System.Console.WriteLine($"Olá ");
        }

        public override void Mover()
        {
           System.Console.WriteLine($"pow pow");
        }
    }
}