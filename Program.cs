namespace ExercicioUm;

public class Program
{
    public static void Main(string[] args)
    {
        Combustivel carroGenerico = new Combustivel();
        Console.WriteLine("Informe o Consumo em Km/L:");
        carroGenerico.consumo = float.Parse(Console.ReadLine()!);
        Console.WriteLine($"\nConsumo Mpg: {carroGenerico.ConverterMPG()}\nConsumo L/100Km: {carroGenerico.ConverterLkm()}");
    }
}