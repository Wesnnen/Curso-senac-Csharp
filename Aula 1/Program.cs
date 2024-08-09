// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Exemplo de declaração de variaveis
int numero = 42;
int numero2 = 22;
string mensagem = "Este é um exemplo de estrutura básica.";
//Declaração de uma variavel de string
int soma = numero + numero2;
//Exibindo valores no console
Console.WriteLine("A  soma de " + numero + "+" + numero2 + " é: " + soma);
Console.WriteLine(mensagem);
if (soma > 70)
{
    Console.WriteLine("Financiamento Aprovado");
}
else
{
    Console.WriteLine(" Financiamento reprovado");
}

// Mantém a janela do console aberta até que uma tecla seja pressionada
Console.ReadKey();
