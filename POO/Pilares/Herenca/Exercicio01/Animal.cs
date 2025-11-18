

namespace Exercicio01
{
    public class Animal 
    {
    
        // Método virtual pode ser sobrescrito nas classes filhas
        public virtual void FazerSom()
        {
            Console.WriteLine("O animal faz um som...");
        }
    
    }
}