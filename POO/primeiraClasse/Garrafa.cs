

namespace PrimeiraClasse
{
    public class Garrafa
    {
        //Propriedades
        public string cor = "";
        public double capacidade;
        public string marca = "";
        public string modelo = "";

        //Métodos
        public void abrir()
        {
            System.Console.WriteLine("Clack (garrafa abrindo)");
        }

        public void fechar()
        {
            System.Console.WriteLine("Click (garrafa fehcnado)");
        }

        public void encher()
        {
            System.Console.WriteLine("Garrafa enchendo (Glup, glup)");
        }


        public void esvaziar()
        {
            System.Console.WriteLine("Garrafa esvaziando (Glup, glup)");
        }
        
    }
}