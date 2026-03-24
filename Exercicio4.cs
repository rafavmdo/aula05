// Atv 4
/*Ref (15 pontos)
4 – Ler valor de nota de N1 e N2, calcular a média e escrever a nota correspondente,
tal que 0 é a menor nota e 10 a maior, e imprimir o conceito equivalente
(A, B, C, D ou E), conforme a seguinte tabela:
A - nota >= 8,5 e nota <= 10
B - nota >= 7 e nota < 8,5
C - nota >= 5 e nota < 7
D - nota >= 3 e nota < 5
E - nota < 3 */

using System.Net.Security;

public static class Exercicio4
{
    public static void Executar()
    {
        double nota1;
        double nota2;
        double notatotal;

        Console.WriteLine("Digite a primeira nota: ");
        nota1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a segumda nota: ");
        nota2 = double.Parse(Console.ReadLine()!);
        notatotal = nota1 * nota2 / 2;

        if (notatotal >= 8.5 && notatotal <= 10)
        {
            Console.WriteLine($"A nota do aluno é A");
        }
        else if (notatotal >= 7 && notatotal < 8.5)
        {
            Console.WriteLine($"A nota do aluno é B");
        }
        else if (notatotal >= 5 && notatotal < 7)
        {
            Console.WriteLine($"A nota do aluno é C");
        }
        else if (notatotal >= 3 && notatotal < 5)
        {
            Console.WriteLine($"A nota do aluno é D");
        }
        else if (notatotal < 3)
        {
            Console.WriteLine("A nota do aluno é E");
        }
        else
        {
            Console.WriteLine($"A nota do aluno é {notatotal}");
        }
    }
}