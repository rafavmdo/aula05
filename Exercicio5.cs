// Atv 5
/*Ref (15 pontos)
5 - As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia,
e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número
de maçãs compradas, calcule e escreva o valor total da compra. */

public static class Exercicio5
{
    public static void Executar()
    {
        double maca;
        
        Console.WriteLine("Digite a quantidade de maçãs compradas: ");
        maca = double.Parse(Console.ReadLine()!);

        if (maca >= 12)
        {
            maca = maca * 0.25;
            Console.WriteLine($"o valor da compra foi {maca}");

        }
        else
        {
            maca = maca * 0.30;
            Console.WriteLine($"o valor da compra foi {maca}");
        }
                
            
        }
    }
