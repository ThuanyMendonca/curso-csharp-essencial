Console.WriteLine("\n Propriedades");

Produto p1 = new();
p1.Nome = "Maria";
p1.Preco = 10.00;
p1.EstoqueMinimo = 20;


p1.Exibir();
Console.ReadKey();

public class Produto
{
    private string? nome;
    public string? Nome
    {
        get { return nome?.ToUpper(); }
        set { nome = value; }
    }

    private double preco;
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 5.00)
                preco = 5.00;
            else
                preco = value;
        }
    }

    private double desconto = 0.05;
    public double Desconto
    {
        get { return desconto; }
    }

    public double PrecoFinal
    {
        get { return Preco - (Preco * Desconto); }
    }

    private int minimo;
    public int EstoqueMinimo
    {
        set { minimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco.ToString("c")} \n{Desconto.ToString("c")} \n{PrecoFinal.ToString("c")} \n{minimo}");
    }


}
