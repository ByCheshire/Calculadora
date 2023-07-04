using System;
using System.Runtime.CompilerServices;

class helloCS
{
    public static void Main()
    {

        int num1;
        int num2;
        int answer;
        string name;
        string confirmation;

        Console.WriteLine("Escreva o seu nome!"); name = Console.ReadLine();
        Console.WriteLine($"Olá {name} bem-vindo a minha calculadora!");

        void aritmetica() {

            Console.WriteLine("[1] para adição - [2] para subtração");
            int operation = Convert.ToInt16(Console.In.ReadLine());

            if (operation == 1)
            {
                Console.WriteLine("Por favor, digite um número!");
                num1 = Convert.ToInt16(Console.In.ReadLine());

                Console.WriteLine("Por favor, digite outro número!");
                num2 = Convert.ToInt16(Console.In.ReadLine());

                answer = num1 + num2;
                Console.WriteLine($"A soma de {num1} com {num2} é igual a {answer}");

            } else if (operation == 2)
            {
                Console.WriteLine("Por favor, digite um número!");
                num1 = Convert.ToInt16(Console.In.ReadLine());

                Console.WriteLine("Por favor, digite outro número!");
                num2 = Convert.ToInt16(Console.In.ReadLine());

                answer = num1 - num2;
                Console.WriteLine($"A subtração de {num1} com {num2} é igual a {answer}");
            }

            Console.WriteLine("Deseja fazer outra conta?");
            confirmation = Console.In.ReadLine();

            if (confirmation == "Sim") {

                aritmetica();

            }

        }

        aritmetica();

        {

        }

    }
}

// Podemos usar $ antes das aspas duplas para fazer uma interpolaçao (nem sei o que é isso kkkkkkkkk)