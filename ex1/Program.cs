////// Aula 02


/* Exercicio 01 com uso do switch
Console.WriteLine("1 - Bardo ");
Console.WriteLine("2 - Arqueiro ");
Console.WriteLine("3 - Guerreiro ");
Console.WriteLine("4 - Mago ");

int v = Convert.ToInt32(Console.ReadLine());

switch (v)
{
    case 1:
        Console.WriteLine( "Bardo" );
        break;
    case 2:
        Console.WriteLine("Arqueiro");
        break;
    case 3:
        Console.WriteLine("Guerreiro");
        break;
    case 4:
        Console.WriteLine("Mago");
        break;
    default:
        Console.WriteLine("Digite um número valido");
        break;
}
*/

/* Exercicio 02
Console.WriteLine("Qual cor voçê quer saber em inglês? ");
Console.WriteLine("1 - Azul ");
Console.WriteLine("2 - Vermelho ");
Console.WriteLine("3 - Amarelo ");
Console.WriteLine("4 - Verde ");

int c = Convert.ToInt32(Console.ReadLine());

switch (c)
{
    case 1:
        Console.WriteLine("Blue");
        break;
    case 2:
        Console.WriteLine("Red");
        break;
    case 3:
        Console.WriteLine("Yellow");
        break;
    case 4:
        Console.WriteLine("Green");
        break;
    default:
        Console.WriteLine("Digite um número valido");
        break;
}
*/

/*Exercicio 03

Console.WriteLine("Digite o número referente a cada nota para saber a frequência: ");
Console.WriteLine("1 - A = LÁ  ");
Console.WriteLine("2 - B = SI ");
Console.WriteLine("3 - C = DÓ ");
Console.WriteLine("4 - D = RÉ ");
Console.WriteLine("5 - E = MI ");
Console.WriteLine("6 - F = FÁ ");
Console.WriteLine("7 - G = SOL ");


int c = Convert.ToInt32(Console.ReadLine());
string x = "";
switch (c)
{
   case 1:
       Console.WriteLine("27.5 Hz");
       Console.WriteLine("Gostaria de saber a nota em sustenido ? " + "S = Sim N = Não");
       x = Console.ReadLine();
       if (x == "S" || x == "s")
       {
           Console.WriteLine("29.135233 Hz");
       }

       break;
   case 2:
       Console.WriteLine("30.867708 Hz");
       Console.WriteLine("Gostaria de saber a nota em sustenido ? " + "S = Sim N = Não");
       x = Console.ReadLine();
       if (x == "S")
       {
           Console.WriteLine("00 Hz");
       }
       break;
   case 3:
       Console.WriteLine("16.351597 Hz");
       Console.WriteLine("Gostaria de saber a nota em sustenido ? " + "S = Sim N = Não");
       x = Console.ReadLine();
       if (x == "S" || x == "s")
       {
           Console.WriteLine("17.323914 Hz");
       }

       break;

   case 4:
       Console.WriteLine("18.354046 Hz");
       Console.WriteLine("Gostaria de saber a nota em sustenido ? " + "S = Sim N = Não");
       x = Console.ReadLine();
       if (x == "S" || x == "s")
       {
           Console.WriteLine("19.445435 Hz");
       }

       break;

   case 5:
       Console.WriteLine("20.601725 Hz");
       Console.WriteLine("Gostaria de saber a nota em sustenido ? " + "S = Sim N = Não");
       x = Console.ReadLine();
       if (x == "S" || x == "s")
       {
           Console.WriteLine("00 Hz");
       }

       break;
   case 6:
       Console.WriteLine("21.826761 Hz");
       Console.WriteLine("Gostaria de saber a nota em sustenido ? " + "S = Sim N = Não");
       x = Console.ReadLine();
       if (x == "S" || x == "s")
       {
           Console.WriteLine("23.124651 Hz");
       }

       break;
   case 7:
       Console.WriteLine("24.499718 Hz");
       Console.WriteLine("Gostaria de saber a nota em sustenido ? " + "S = Sim N = Não");
       x = Console.ReadLine();
       if (x == "S" || x == "s")
       {
           Console.WriteLine("25.956537 Hz");
       }

       break;
   default:
       Console.WriteLine("Digite um número valido");
       break;
}

*/
//exercicio 04
//string a = Console.ReadLine().ToLowerInvariant(); 
//Console.WriteLine(a);
/*
for (int i = 1; i <= 20; i++)
{
    i = i + 1;
    Console.WriteLine(i);
}
*/
/* Exercicio 05
Console.Write("Digite um número: ");
int N = Convert.ToInt32(Console.ReadLine());
int soma = 0;

if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        soma += i;
    }
}
else
{
    for (int i = N; i <= 1; i++)
    {
        soma += i;
    }

}
Console.WriteLine($"A soma de 1 a {N} é: {soma}");
*/
/*exercicio 06
 * fatorial em for
Console.Write("Digite um número: ");
int N = Convert.ToInt32(Console.ReadLine());
int soma = N;


for (int i = N; i >= 1; i--)
{
    soma = soma*i;
   
}

Console.WriteLine($"Fatorial de {N} é: {soma}");

*/

/*int contador = 10;

while (contador > 0)
{
    Console.WriteLine(contador);
    System.Threading.Thread.Sleep(1000);
    contador--;
}
Console.WriteLine("Fogo!");
*/


int soma = 0;
int numero = 0;
bool condicao = true;


while (condicao == true)
{
    Console.Write("Digite um número, caso seja 0, o programa para...: ");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero == 0)
    {
        
        break;
    }
    else 
    { 
        if (numero % 2 ==0 ) {
            soma += numero;
            Console.WriteLine("O somatório atual é:" + soma);

        }
        else
        {
            soma -= numero;
            Console.WriteLine("O somátorio atual é:" + soma);

        }
       
    }
}
Console.WriteLine("O somatório Final é:" + soma);
