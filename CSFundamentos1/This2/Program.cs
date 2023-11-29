Console.WriteLine("This e construtores");
Teste t1 = new Teste(888);

Console.ReadKey();

public class Teste
{
    public Teste(int num1, int num2)
    {
        Console.WriteLine($"Construtor com 2 parametros: {num1} e {num2}");
    }

    // aqui o : this(parametros) está chamando o construtor acima,
    // ele chama o primeiro construtor e depois o segundo

    public Teste(int num) : this(123, 456)
    {
        Console.WriteLine("Construtor com parametro " + num);
    }
}

