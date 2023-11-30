Console.WriteLine("## Passando argumentos por referência utilizando out ##\n");

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new Circulo();
//double perimetro = circulo.CalculaPerimetro(raio);
//double area = circulo.CalculaArea(raio);

//Console.WriteLine($"Perímetro {perimetro}");
//Console.WriteLine($"Area {area}");


// utilizando out - ele armazena o valor da variavel area e retorna o valor do parametro
// porque passa a referencia do local de memoria da variavel area
double circunferencia = circulo.CalculaAreaPerimetro(raio, out double area);
Console.WriteLine($"Perímetro {circunferencia}");
Console.WriteLine($"Area {area}");

Console.ReadKey();


public class Circulo
{
    public double CalculaArea(double raio)
    {
        double area = Math.PI * Math.Pow(raio, 2);

        return area;
    }

    public double CalculaPerimetro(double raio)
    {
        double perimetro = 2 * Math.PI * raio;

        return perimetro;
    }

    // utilizando out
    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;

        return perimetro;
    }
}