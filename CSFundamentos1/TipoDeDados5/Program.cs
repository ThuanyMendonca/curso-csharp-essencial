Console.WriteLine("Struct Datetime");


DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);

// Criando data especifica

DateTime dataHoje = new DateTime(2023, 09, 12);
Console.WriteLine(dataHoje);

// Definindo as horas
DateTime dataHoraHoje = new DateTime(2023, 09, 12, 14,10,05);
Console.WriteLine(dataHoraHoje);


// Operações com datas
DateTime hoje = DateTime.Now;
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);

// Adicionando dias, horas, etc
Console.WriteLine(hoje.AddDays(20));
Console.WriteLine(hoje.AddMonths(3));
Console.WriteLine(hoje.AddYears(2));
Console.WriteLine(hoje.AddHours(4));
Console.WriteLine(hoje.AddSeconds(39));

// Obter dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

// Obter data no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

// Obter hora no formato longo e curto
Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());

Console.ReadKey();