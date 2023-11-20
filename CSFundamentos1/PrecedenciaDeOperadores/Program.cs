Console.WriteLine("Precedência de Operadores");

int x = 10 - 2 * 3; // 10 - 6 = 4
Console.WriteLine(x);

// alterando a precedencia
int y = (10 - 2) * 3; // 8 * 3 = 24
Console.WriteLine(y);

bool a = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine(a);

bool b = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(b);

Console.ReadKey();