Console.WriteLine("## Passando argumentos por referencia ## \n");

int x = 20;

Console.WriteLine("Valor de x antes de passar por valor" + x);

Calculo calc = new Calculo();
calc.Dobrar(ref x); // passando x por referencia


Console.WriteLine($"Valor de x depois de passar por valor {x}");

Console.ReadKey();


public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine($"Valor do parâmetro y no método dobrar {y}");
    }
}
