using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine(">> CALCULADORA VIRTUAL <<");

            Console.WriteLine(" ");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Sair do sistema");

            Console.WriteLine(" ");

            Console.WriteLine("------------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine()!);

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Potencia(); break;
                case 6:
                    Console.WriteLine(">>Obrigado por sua visita, Volte sempre!<<");
                    System.Environment.Exit(0);
                    break;
                default: Menu(); break;

            }
        }
        static void Soma()
        {

            Console.Clear();

            Console.WriteLine("1ª valor: ");
            decimal v1 = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("2ª valor: ");
            decimal v2 = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine(" ");

            decimal resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"O resultado da soma de {v1} + {v2} = {resultado}");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            // Console.WriteLine($"O resultado da soma é {v1 + v2}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("1ª Valor: ");
            double n1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("2ª Valor: ");
            double n2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            double resultado = n1 - n2;
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"O resultado da subtração de {n1} - {n2} = {resultado}");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("1ª valor: ");
            float n1 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("2ª valor: ");
            float n2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            float resultado = n1 / n2;
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"O resultado da divisão de {n1} / {n2} = {resultado}");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("1ª valor: ");
            float n1 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("2ª valor: ");
            float n2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            float resultado = n1 * n2;
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"O resultado da multiplicação de {n1} * {n2} = {resultado}");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
            Menu();
        }
        static void Potencia()
        {
            Console.Clear();

            Console.WriteLine("Valor a diminuir com a porcentagem:");

            Console.WriteLine("Valor inicial: ");
            float v1 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Valor do desconto em porcentagem: ");
            float v2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            float x = v2 / 100;
            float resultado = v1 * x;
            float menos = v1 - resultado;
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"O resultado da porcentagem de {v1} - {v2}% é {resultado}");
            Console.WriteLine($"O valor final ficou {menos}");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadKey();
            Menu();
        }

    }
}