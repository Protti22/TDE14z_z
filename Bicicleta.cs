public class Bicicleta : Veiculo, IAceleravel
{
    public Bicicleta(string marca, string modelo) : base(marca, modelo)
    {

    }

    public void Acelerar()
    {
        Console.WriteLine($"A bicicleta da marca {Marca} e do modelo {Modelo} pedalando rapido");
        
    }

    public override void Ligar()
    {
        Console.WriteLine("Voce subiu na bicicleta");
    }
}