//Tipos Primitivos
int numeroInteiro = 42;
long numeroLongo = 1234567890L;
float numeroFloat = 3.14f;
double numeroDouble = 3.14159265358979;
decimal numeroDecimal = 12345.6789m;
char caractere = 'A';
bool verdadeiroOuFalso = true;

// Strings
string texto = "Olá, mundo!";
string textoMultilinha = @"esta e uma string multilinha com @";

Console.WriteLine($"Número Inteiro: {numeroInteiro}");
Console.WriteLine($"Número Longo: {numeroLongo}");
Console.WriteLine($"Número Flutuante: {numeroFloat}");
Console.WriteLine($"Número Double: {numeroDouble}");
Console.WriteLine($"Número Decimal: {numeroDecimal}");
Console.WriteLine($"Caractere: {caractere}");
Console.WriteLine($"Booleano: {verdadeiroOuFalso}");
Console.WriteLine($"Texto: {texto}");
Console.WriteLine($"Texto Multilinha: {textoMultilinha}");

Console.ReadKey();