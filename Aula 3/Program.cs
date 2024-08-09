/*
Console.Write("Digite um número, para calcular a tabuada: ");
int numero = Convert.ToInt32(Console.ReadLine());

for  (int i = 1; i <= 10; i++)
{
    int x = numero * i;
    Console.WriteLine($"Tabuada {numero} x {i} = " + x);
}   
Console.ReadLine();
*/
/*
int n;

do
{
    Console.Write("Digite um número positivo:");
    n = Convert.ToInt32(Console.ReadLine());
} while (n <= 0);

Console.WriteLine($"Você digitou o número positivo: {n}");
Console.ReadLine();
*/
/*
double numero;
int numero2;
do
{
    Console.WriteLine("Digite um número inteiro:");
    numero = Convert.ToDouble(Console.ReadLine());
    numero2 = (int)numero;
}
while (numero2 != numero);
*/

double PesoOuro=0, peso = 0 ;
string nome , nomeOuro = "" , x;
bool R = true;

    
    while (R == true) 
    {
    Console.WriteLine("Digite seu nome:");
    nome = Console.ReadLine();
    Console.WriteLine("Digite o peso levantado:");
    peso = Convert.ToDouble(Console.ReadLine());
    if (peso > PesoOuro)
    {
        PesoOuro = peso;
        nomeOuro = nome;
    }
    Console.WriteLine("Calcular o resultado? Sim ou Não");
    x = Console.ReadLine().ToLowerInvariant();
    if (x == "sim")
    {
        R = false;  
    }
    } 
Console.WriteLine("Nome:" + nomeOuro  + " Peso  " + PesoOuro);
    


