Console.WriteLine("## Métodos com retorno ## \n");

Calculadora c1 = new Calculadora();
Console.WriteLine(c1.Somar(100, 40));

Console.ReadKey();

public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        var soma = n1 + n2;
        return soma;
    }

    public int Subtrair(int n1, int n2)
    {
        var subtracao = n1 - n2;
        return subtracao;
    }

    public int Multiplicar(int n1, int n2)
    {
        var multiplicacao = n1 * n2;
        return multiplicacao;
    }

    public int Dividir(int n1, int n2)
    {
        var divisao = n1 / n2;
        return divisao;
    }
}

