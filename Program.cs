// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("MEU PRIMEIRO PROGRAMA");
Console.WriteLine("=======================");
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("\t Olá {0}. Seja bem vindo!", nome);
int x, y;
double resultado;
Console.Write("Digite um número: ");
x = int.Parse(Console.ReadLine());
Console.Write("Digite outro número: ");
y = int.Parse(Console.ReadLine());
//resultado = x + y;
//Console.Write("Resultado: {0}", resultado);
//Console.WriteLine("{0} + {1} é igual à: {2}",x,y,resultado);
//Console.Write("{2} - {1} = {0}", x,y,resultado);
resultado = (double)x / y;
Console.Write("Resultado: {0:f2}", resultado);
Console.Write("Resultado: {0:C}", resultado);
