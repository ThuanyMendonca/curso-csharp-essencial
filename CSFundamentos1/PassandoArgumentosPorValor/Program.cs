Console.WriteLine("## Passando argumentos por valor ##\n");

int x = 20;

Console.WriteLine("Valor de x antes de passar por valor" + x);

Calculo calc = new Calculo();
calc.Dobrar(x);


Console.WriteLine($"Valor de x depois de passar por valor {x}");

Console.ReadKey();


public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine($"Valor do parâmetro y no método dobrar {y}");
    }
}

