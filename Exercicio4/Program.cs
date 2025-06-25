using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    string input;
                    Console.Write("Digite o primeiro número: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    int b = int.Parse(Console.ReadLine());

                    int calcularDivisao = a / b;
                    Console.WriteLine($"Resultado da divisão: {calcularDivisao}");
                    Console.WriteLine("Digite 'sair' para encerrar o programa ou pressione a teclar Enter para continuar.");
                    input = Console.ReadLine();
                    if (input.ToLower() == "sair")
                    {
                        Console.WriteLine("Programa encerrado pelo usuário.");
                        return;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Erro: Valor inválido. Digite um número inteiro.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Erro: Não é possível dividir por zero...");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Operação finalizada.");
                }
            }
        }
    }
}
