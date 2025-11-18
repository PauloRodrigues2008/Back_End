

namespace TheBasics
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;

        public void Ligar()
        {
            System.Console.WriteLine($"Ligando o veículo");
        }
      
       public void Desligar()
        {
            System.Console.WriteLine($"Veículo desligado");
        }
        
    }
}