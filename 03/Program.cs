Console.Write("Digite um número de 1 até 4: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero == 1)
{
    Console.WriteLine(numero + " Bardo");
}
else if (numero == 2)
{
    Console.WriteLine(numero + " Arqueiro");
}
else if (numero == 3)
{
    Console.WriteLine(numero + " Guerreiro");
}
else if (numero == 4)
{
    Console.WriteLine(numero + " Mago");
}
else
{
    Console.WriteLine("O número não é valido.");
}



