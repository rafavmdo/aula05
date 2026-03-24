// Atv 3
//*Ref. (10 pontos)
//3 - Escreva um programa que receba três números inteiros e mostre eles em ordem crescente.

public static class Exercicio3
{
    public static void Executar()
    {
        int n1;
        int n2;
        int n3;
        int maior = 0;
        int medio = 0;
        int menor = 0;

        Console.WriteLine("Digite um número inteiro: ");
        n1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite outro número inteiro: ");
        n2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite outro número inteiro: ");
        n3 = int.Parse(Console.ReadLine()!);


        if (n1 > n2 && n1 > n3)
        
        {
            maior = n1;
            
            if (n2 > n3)
            {
                medio = n2;
                menor = n3;
            }
            else
            {
                medio = n3;
                menor = n2;
            }
        }

        if (n2 > n1 && n2 > n3)
        
        {
            maior = n2;
            
            if (n1 > n3)
            {
                medio = n1;
                menor = n3;
            }
            else
            {
                medio = n3;
                menor = n1;
            }
        }

        if (n3 > n2 && n3 > n1)
        
        {
            maior = n3;
            
            if (n2 > n1)
            {
                medio = n2;
                menor = n1;
            }
            else
            {
                medio = n1;
                menor = n2;
            }
        }
        
        Console.WriteLine($"{menor}, {medio}, {maior}");
    }
}