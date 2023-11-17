Console.WriteLine("Informe o valor de x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y:");
int y = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine($"soma de x + y = {x+y}");
//Console.WriteLine($"subtração de x - y = {x-y}");
//Console.WriteLine($"multiplicação de x * y = {x*y}");
//Console.WriteLine($"divisão de x * y = {x/y}");
//Console.WriteLine($"módulo de x % y = {x%y}");

Console.WriteLine($"\n Raiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"\n Potência de x elevado a y = {Math.Pow(x,y)}");
Console.WriteLine($"\n Valor mínimo entre x e y = {Math.Min(x,y)}");
Console.WriteLine($"\n Valor máximo entre x e y = {Math.Max(x, y)}");
Console.WriteLine($"\n Valor do cosceno de x = {Math.Cos(x)}");
Console.WriteLine($"\n Valor do seno de x = {Math.Sin(x)}");


Console.ReadKey();