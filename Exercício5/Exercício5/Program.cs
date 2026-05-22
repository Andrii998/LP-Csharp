using System;
public class Exercício5
{
    public static void Main(string[] args)
    {
        int idade = 29;
        bool casado = true;

        if (idade < 18)
        {
        Console.WriteLine("Es uma criança com idade: " + idade);
        }
        else if (idade >= 18 && idade < 65)
        {
            if (casado = true)
            {
                Console.WriteLine("Adulto casado");
            }
            else
            {
                Console.WriteLine("Adulto solteiro");
            }
        }
        else
        { 
        Console.WriteLine("És sénior com idade : " + idade);
        }

    }   
}