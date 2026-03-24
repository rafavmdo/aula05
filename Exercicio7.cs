// Atv 7
/*Ref. (15 pontos)
7 - Para doar sangue é necessário ter entre 18 e 67 anos e possuir mais de 60 kg.
Faça um aplicativo que pergunte a idade de uma pessoa e seu peso e diga se ela pode
doar sangue ou não; caso não possa, diga o(s) motivo(s). */



public static class Exercicio7
{
    public static void Executar()
    {
        int idade;
        double peso;

        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine()!);

        Console.Write("Digite sua peso: ");
        peso = double.Parse(Console.ReadLine()!);

        if (idade >= 18 && peso >= 60)
        {
            if (idade > 67 || peso < 60)
            {
                
            }
            else
            {
                Console.WriteLine("Você atende os requisitos para prosseguir à doação.");
            }
        }
        else
        {
            Console.WriteLine("Você não atende os requisitos para prosseguir à doação.");
        }
    }
}