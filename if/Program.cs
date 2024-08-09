Console.WriteLine("Exemplo com 'if':");

Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());
int m = 0 ;
if (numero > 0)
    {
    Console.WriteLine("O número é positivo.");
    }
else if (numero == 0)
{
    Console.WriteLine("O número é zero.");
}
else
    {
    Console.WriteLine("O numéro não é positivo");
        }




Console.WriteLine("Exemplo com 'if' e 'else':");



if (numero % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número é ímpar.");
}



if (numero % 3 == 0)
{
    m = numero * 5;
    Console.WriteLine("Resultado: " +  m);
}
else
{
    m = numero * 3;
    Console.WriteLine("Resultado: " + m);
}
            