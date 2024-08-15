using System.Diagnostics.CodeAnalysis;

int num1;
int num2;
Console.WriteLine("Digite o valor do primeiro número: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Perfeito! Agora digite o valor do segundo número:");
num2 = Convert.ToInt32(Console.ReadLine());


int soma = num1 + num2;
int subtracao = num1 - num2;
int multiplicacao = num1 * num2;
double divisao = (double) num1 / num2;
//Formatação de String utilizando Concatenação!
Console.WriteLine("A soma dos dois números é:" + soma);
//Formatação de String utilizando Interpolação!
Console.WriteLine($"A subtração dos números é: {subtracao}");
//Formatação de String utilizando Placeholders!
Console.WriteLine("A multiplicação dos números é: {0}", multiplicacao);
Console.WriteLine($"A divisão dos números é: {divisao}");