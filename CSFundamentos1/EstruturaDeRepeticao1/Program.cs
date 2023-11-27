Console.WriteLine("## Estrutura de repetição ##\n");

// goto
int i = 1;

repetir:

Console.WriteLine($"i = {i}");
i++;

if (i <= 10)
    goto repetir;

Console.WriteLine("Fim do processamento");



// While
var j = 1;

while(j <= 10)
{
    Console.WriteLine($"j = {j}");
    j++;
}

// while (saindo de um loop com o break
while(true) {
    Console.WriteLine("Digite um número: (digite 999 para sair)");
    int numero = Convert.ToInt32(Console.ReadLine());

    if(numero == 999) {
        break;
    }

    if(numero % 2 == 0) {
        Console.WriteLine($"O número {numero} é PAR");
    } else {
        Console.WriteLine($"O número {numero} é IMPAR");
    }
}

// while aninhado
int x = 0;
while (x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.Write($"{x},{y}");
        y++;
    }
    x++;
    Console.WriteLine();
}


// do while
var k = 1;

do
{
    Console.WriteLine($"k = {k}");
    k++;

    if(k > 7)
    {
        break;
    }
} while (k <= 10);

Console.WriteLine("Fim do processamento...");

Console.ReadKey();