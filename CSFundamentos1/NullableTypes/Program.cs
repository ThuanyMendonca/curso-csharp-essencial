Console.WriteLine("Nullable types");

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

// Simplificando
int? j = null;
double? doub = null;
bool? existe = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

Console.WriteLine(j);
Console.WriteLine(doub);
Console.WriteLine(existe);


// Atribuindo um Nullable Type a um tipo por valor utilizando o operador ?? 
int? a1 = null;
int b1 = a1 ?? 0;
Console.WriteLine(b1);


// Atribuir um Nullable type a um tipo por valor: expressões

/* Caso de erro
    lint? x = 4;
    int y = 3;
    intz=×* y;
    Console.WriteLine(z);
    Console.ReadLine();

    Cannot implicitly convert type int?' to 'int'. An explicit
    conversion exists (are you missing a cast?)
*/


int? x = 4;
int? y = 3;
int? z = x * y;
Console.WriteLine(z);

// HasValue e Value

int? teste = 100;
if (teste.HasValue) {
    Console.WriteLine($"teste = {teste.Value}");
} else
{
    Console.WriteLine("teste não possui valor");
}

Console.ReadLine();