// Atv 1
//*Ref (5 pontos)
// 1 - Faça um programa que calcule e apresente o  valor do volume de uma lata, sabendo que PI é um valor constante de 3.14159,
//o programa deve pedir os valores de RAIO e ALTURA, utilize a fórmula VOLUME = PI * RAIO2 * ALTURA.

public static class Exercicio1
{
    public static void Executar()
    {
        double raio;
        double altura;
        double PI = 3.14159;
        double volume;

        Console.WriteLine("Digite o valor do raio: ");
        raio = double.Parse(Console.ReadLine()!);

        Console.WriteLine();

        Console.WriteLine("Digite o valor da altura: ");
        altura = double.Parse(Console.ReadLine()!);

        volume = PI * (raio * raio) * altura;
        Console.WriteLine($"O valor do volume da lata é: {volume}");
    }
}