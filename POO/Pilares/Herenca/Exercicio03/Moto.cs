namespace Exercicio_3
{
    public class Moto : Veiculo
    {
    public string TipoCapacete { get; set; }

    public Moto(string marca, string modelo, string tipoCapacete)
        : base(marca, modelo)
    {
        TipoCapacete = tipoCapacete;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Moto - Marca: {Marca}, Modelo: {Modelo}, Capacete: {TipoCapacete}");
    }
    }
}