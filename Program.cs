using System.Diagnostics.CodeAnalysis;

double num1;
double num2;
Console.WriteLine("Digite o valor do primeiro número:");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Perfeito! Agora digite o valor do segundo número:");
num2 = Convert.ToDouble(Console.ReadLine());


double soma = num1 + num2;
double subtracao = num1 - num2;
double multiplicacao = num1 * num2;
double divisao = num1 / num2;
//Formatação de String utilizando Concatenação!
Console.WriteLine("A soma dos dois números é:" + soma);
//Formatação de String utilizando Interpolação!
Console.WriteLine($"A subtração dos números é: {subtracao}");
//Formatação de String utilizando Placeholders!
Console.WriteLine("A multiplicação dos números é: {0}", multiplicacao);
Console.WriteLine($"A divisão dos números é: {divisao}");