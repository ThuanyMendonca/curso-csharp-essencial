Console.WriteLine("## Métodos e sobrecargas ##\n");

Email email = new Email();

email.Enviar("empresa.com.br");
email.Enviar("endereço", "assunto");
email.Enviar("endereco", 12.45);
email.Enviar(45.67, "endereco");

Console.ReadKey();


public class Email
{

    // Sobrecarga - quando possui o mesmo nome, porém com assinatura diferente
    // como a quantidade de parametros e tipo dos parametros

    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Assunto padrão");
    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Assunto padrão: {assunto}");
    }

    public void Enviar(string endereco, double valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Proposta comercial");
        Console.WriteLine($"{valor}");
    }

    public void Enviar(double valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Pagamento fornecedor");
        Console.WriteLine($"{valor}");
    }
}

