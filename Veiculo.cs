public abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    // Construtor
    protected Veiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public abstract void Ligar();
    public void Desligar()
    {
        Console.WriteLine("O Veiculo esta desligando");
    }
}
