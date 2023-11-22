Console.WriteLine("## Estrutura If ##\n");

Console.WriteLine("Cliente especial (true/false)");
var resposta = Convert.ToBoolean(Console.ReadLine());

if (resposta) {
    Console.WriteLine("Desconto de 10%");
}

Console.WriteLine("Fim do processamento");

Console.ReadKey();
