Console.WriteLine("## Exemplo prático de métodos e sobrecarga ## \n");

Cadastro cadastro = new Cadastro();

var cliente = cadastro.Registrar();
cadastro.ExibirDados(cliente);

// alterando a renda
cliente = cadastro.Registrar(cliente);
cadastro.ExibirDados("Novos dados", cliente);

Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }

    public Cliente()
    {

    }
}

public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new Cliente("Maria", 26, 3000);
        return cliente;
    }

    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 5000;
        return cliente;
    }

    public void ExibirDados(Cliente cliente)
    {
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString("c")}");
    }

    public void ExibirDados(string texto, Cliente cliente)
    {
        Console.WriteLine($"\t{texto}\t");
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString("c")}");
    }
}