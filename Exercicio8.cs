// Atv 8
/*Ref. (10 pontos)
8 - Crie um programa que faça 5 perguntas para uma pessoa sobre um crime.
As perguntas são:
"Telefonou para a vítima?"
"Esteve no local do crime?"
"Mora perto da vítima?"
"Devia para a vítima?"
"Já trabalhou com a vítima?"
O programa deve, no final, emitir uma classificação sobre a participação da pessoa no
crime. Se a pessoa responder positivamente a 2 questões, ela deve ser
classificada/exibida como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino".
Caso contrário, ela será classificada como "Inocente". */

public static class Exercicio8
{
    public static void Executar()
    {
        string respostaUm;
        string respostaDois;
        string respostaTres;
        string respostaQuatro;
        string respostaCinco;
        int totalDeRespostasPositivas = 0;

        Console.WriteLine("Telefonou para a vítima?");
        respostaUm = Console.ReadLine()!;
        if (respostaUm == "sim")
        {
            totalDeRespostasPositivas++;
        }

        Console.WriteLine("Esteve no local do crime?");
        respostaDois = Console.ReadLine()!;
        if (respostaDois == "sim")
        {
            totalDeRespostasPositivas++;
        }

        Console.WriteLine("Mora perto da vítima?");
        respostaTres = Console.ReadLine()!;
        if ( respostaTres == "sim")
        {
            totalDeRespostasPositivas++;
        }

        Console.WriteLine("Devia para a vítima?");
        respostaQuatro = Console.ReadLine()!;
        if (respostaQuatro == "sim")
        {
            totalDeRespostasPositivas++;
        }

        Console.WriteLine("Já trabalhou com a vítima?");
        respostaCinco = Console.ReadLine()!;
        if (respostaCinco == "sim")
        {
            totalDeRespostasPositivas++;
        }
        Console.Clear();

        if (totalDeRespostasPositivas == 2)
        {
            Console.WriteLine("Suspeito.");
        }
          else if (totalDeRespostasPositivas == 3 || totalDeRespostasPositivas == 4)
        {
            Console.WriteLine("Cúmplice.");
        }
        else if (totalDeRespostasPositivas == 5)
        {
            Console.WriteLine("Assassino.");
        }
        else
        {
            Console.WriteLine("Inocente!");
        }
        
        
    }
}