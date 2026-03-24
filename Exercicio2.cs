// Atv 2
//* Ref (5 pontos)
//2 – Faça um programa que verifique se uma letra digitada é vogal ou consoante.

public static class Exercicio2
{
    public static void Executar()
    {
        string letra;

            Console.WriteLine("Digite uma letra: ");
            letra = Console.ReadLine()!;

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            { 
                Console.WriteLine($"A letra {letra} é VOGAL");
            }
             
            else
            {
                Console.WriteLine($"A letra {letra} é CONSOANTE"); 
            }

    }

}

