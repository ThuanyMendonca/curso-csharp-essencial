Console.WriteLine("## Parâmetros opcionais ##\n");

// Os parâmetros opcionais devem serem declarados após a declaração dos parâmetros obrigatórios

Email email = new Email();

// enviando apenas parâmetros obrigatórios
email.Enviar("teste@teste.com.br");

// utilizando argumentos nomeados
email.Enviar("meuemail@gmail.com", assunto: "Nova agenda");

// forma padrão
email.Enviar("teste@teste.com.br", "Nova Reunião", "Definição de arquitetura");

Console.ReadKey();


public class Email
{
    // parâmetros opcionais - os valores são definidos na declaração dos parâmetros 
    public void Enviar(string destino, string titulo = "Reunião", string assunto = "Organização e métricas")
    {
        Console.WriteLine($"Destino: {destino}, Titulo: {titulo}, Assunto: {assunto}");
    }
}
