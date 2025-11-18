
namespace Exercicio01;
public class Gato : Animal
    {
        // Sobrescrevendo o método da classe base
        public override void FazerSom()
        {
            Console.WriteLine("Miau!");
        }
    }