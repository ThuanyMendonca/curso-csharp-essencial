// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Pessoa()
{
    public static int IdadeMinima;

    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("\n Executando o construtor parametrizado");
        Idade = idade;
        Nome = nome;
    }

    public Pessoa()
    {

    }

    static Pessoa()
    {
        Console.WriteLine("\nExecutando o construtor estático");
        Console.WriteLine("\n Inicializando o campo estático");
        IdadeMinima = 18;

    }

}