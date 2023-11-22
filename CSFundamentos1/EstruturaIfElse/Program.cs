Console.WriteLine("## Estrutura If/Else ##\n");

Console.WriteLine("Informe a nota do aluno: \t");

var nota = Convert.ToInt32(Console.ReadLine());

if (nota > 5)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}

Console.WriteLine("Fim do processamento");

Console.ReadKey();
