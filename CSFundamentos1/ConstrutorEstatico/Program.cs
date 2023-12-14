Console.WriteLine("Construtor estático\n");

// Uma vez que o construtor estatico é executado, ele não executa novamente

// Invoca o construtor parametrizado e o estatico
Pessoa p1 = new(19, "Maria");
Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade minima: " + Pessoa.IdadeMinima);


// Invoca somente o construtor parametrizado
Pessoa p2 = new(24, "Manoel");
Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("Idade minima: " + Pessoa.IdadeMinima);

Console.ReadKey();
