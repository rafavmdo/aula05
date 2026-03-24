// Atv 9
/*Ref. (5 pontos)
9 - Escreva um programa que leia um número e verifique se ele é positivo,
negativo ou zero. */


public static class Exercicio9
{
    public static void Executar()
    {
        Console.WriteLine("Digite um valor ");
        double num = double.Parse(Console.ReadLine()!);

        if (num > 0)
        {
            Console.WriteLine("Número é positivo");
        }
        else if (num < 0)
        {
            Console.WriteLine("Número é negativo ");
        }
        else
        {
            Console.WriteLine("Número igual a Zero");
        }
    }
}