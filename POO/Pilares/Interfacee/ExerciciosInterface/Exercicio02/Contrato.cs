

namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Contrante = "";
        public string PrestadorServico = "";
        public string TextoClausulas = "";

        public Contrato(string Contratante, string contratada, string txtXClausulas)
        {
            Contratante = Contrante;
            PrestadorServico = contratada;
            TextoClausulas = txtXClausulas;
        }
        public void Imprimir()
        {
            System.Console.WriteLine(@$"
            Partes:
            Contrante: {Contrante}
            Contratada: {PrestadorServico}
            Cláusulas de Contarto:

            {TextoClausulas}
            
            
            
            ");
        }
    }
}