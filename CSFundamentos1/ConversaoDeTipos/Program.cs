Console.WriteLine("Conversão de tipos");

// Conversão implícita:
int varInt = 100;
double varDouble = varInt;

Console.WriteLine(varDouble);



// Conversão explícita:
int num = 10;
int num1 = 4;

float resultado = num / num1;

Console.WriteLine(resultado); // 2

float resultado2 = (float)num / num1;
Console.WriteLine(resultado2); // 2.5

// Utilizando o ToString()

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.5678m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

// OverflowException

/* 
 * int numero = 10000;
 * Console.WriteLine(Convert.ToByte(numero)); // Value was either too large or too small for an unsigned byte
*/

Console.ReadLine();