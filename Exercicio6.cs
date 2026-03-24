// Atv 6
/* 6 - Um programa deve ler três ângulos e verificar qual é o tipo de triângulo formado.
Primeiro, é necessário conferir se a soma dos três ângulos é igual a 180°,
pois só assim eles formam um triângulo. Depois, se um dos ângulos for igual a 90°,
o triângulo é retângulo. Se um dos ângulos for maior que 90°, ele é obtusângulo.
Caso contrário, se os três forem menores que 90°, o triângulo é acutângulo. */


using System.Formats.Asn1;

public static class Exercicio6
{
    public static void Executar()
    {
        double triangulo;
        double angulo1;
        double angulo2;
        double angulo3;

        Console.WriteLine("Digite o primeiro ângulo: ");
        angulo1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o segundo ângulo: ");
        angulo2 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o terceiro ângulo: ");
        angulo3 = double.Parse(Console.ReadLine()!);
        triangulo = angulo1 + angulo2 + angulo3;

        if (triangulo != 180)
        {
            Console.WriteLine("Isso não é um triângulo");
        }
        else if (triangulo == 90)
        {
            Console.WriteLine("É um triângulo retângulo");
        }
        else if (triangulo < 90)
        {
            Console.WriteLine("É um triângulo obtusângulo");
        }
        else if (triangulo > 90)
        {
            Console.WriteLine("É um triângulo acutângulo");
        }
        else
        {
            Console.WriteLine("Não é um triângulo.");
        }
    }
}