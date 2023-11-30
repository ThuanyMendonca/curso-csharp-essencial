Console.WriteLine("## Argumentos nomeados ##\n");

Email email = new Email();

// padrão - com a ordem dos parâmetros
email.Enviar("teste@teste.com.br", "URGENTE", "assunto teste");


// nomeado - fora da ordem dos parâmetros
email.Enviar(destino: "teste1@gmail.com", assunto: "Reunião", titulo: "TESTE");

Console.ReadKey();


public class Email
{
   public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"Destino: {destino}, Titulo: {titulo}, Assunto: {assunto}");
    }
}
