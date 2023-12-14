Console.WriteLine("## Métodos estáticos ##\n");

// ao declarar como static os métodos passam a partecerem a classe e não o objeto/instancia da classe
var soma = Calculadora.Somar(100, 40);
var subtrair = Calculadora.Subtrair(100, 40);
var multiplicar = Calculadora.Multiplicar(100, 40);
var dividir = Calculadora.Dividir(100, 40);


Console.WriteLine(soma);
Console.WriteLine(subtrair);
Console.WriteLine(multiplicar);
Console.WriteLine(dividir);

Console.ReadKey();

public class Calculadora
{
    public static int Somar(int n1, int n2)
    {
        var soma = n1 + n2;
        return soma;
    }

    public static int Subtrair(int n1, int n2)
    {
        var subtracao = n1 - n2;
        return subtracao;
    }

    public static int Multiplicar(int n1, int n2)
    {
        var multiplicacao = n1 * n2;
        return multiplicacao;
    }

    public static int Dividir(int n1, int n2)
    {
        var divisao = n1 / n2;
        return divisao;
    }
}