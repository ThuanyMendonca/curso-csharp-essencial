﻿Console.WriteLine("## Operadores de atribuição ##\n");

// usando operadores de atribuição com tipos numéricos

var x = 10;

Console.WriteLine($"Valor inicial de x = {x}");
Console.WriteLine($"x += 5 {x += 5}");
Console.WriteLine($"x -= 3 {x -= 3}");
Console.WriteLine($"x *= 4 {x *= 4}");
Console.WriteLine($"x /= 5 {x /= 5}");
Console.WriteLine($"x %= 5 {x %= 5}");

// usando operadores de atribuição com tipo string
var y = "123";
y += "456";
Console.WriteLine(y);


Console.ReadKey();