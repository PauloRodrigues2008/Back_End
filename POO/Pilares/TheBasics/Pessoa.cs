    // namespace pode ser considerado a pasta do projeto
    //namespace é o modulo do sistema
    //namespace é como um pacote,
    namespace TheBasics
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;


        public Endereco EnderecoCompleto;


        public Pessoa(Endereco endereco){
            EnderecoCompleto = endereco;
            
        }




        

        public void Falar()
        {
            System.Console.WriteLine($"Óla, sou o {Nome} e tenho {Idade} anos");
        }
        
        public void Envelhecer()
        {
            Idade++;
        }
        

    }
}   