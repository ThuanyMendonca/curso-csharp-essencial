Console.WriteLine("Saída de dados: Formatação");

int idade = 25;
string nome = "Maria";

Console.WriteLine(idade);
Console.WriteLine(nome);

// utilizando o operador +
Console.WriteLine(nome + " tem " + idade + " anos");

// utilizando interpolação $ {}
Console.WriteLine($"{nome} tem {idade} anos");

// utilizando place holders: usa {} com numeração com o inicio em zero
Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadLine();
