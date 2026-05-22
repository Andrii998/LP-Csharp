using System;

public class Exercício4
{
    public static void Main(string[] args)
    {
        int idade = 12;

        if (idade < 11)
        {
            Console.WriteLine("E uma criança: " + idade);
        }
        else if (idade >= 11 && idade < 18)
        {
            Console.WriteLine("E Adolescente: " + idade);
        }
        else
        {
            Console.WriteLine("E um adulto: " + idade);
        }

    }   
}