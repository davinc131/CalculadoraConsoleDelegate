using System;

namespace CalculadoraConsoleDelegate
{

    delegate float calcular(float i, float j);
    class Program
    {
        private static float n1;
        private static float n2;
        private static char t;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("CALCULADORA SIMPLES COM DELEGATE");
                Console.WriteLine("Após informar os valores selecione o tipo de operação desejada:");
                Console.WriteLine("");
                Console.WriteLine("Soma: s");
                Console.WriteLine("");
                Console.WriteLine("Subtração: i");
                Console.WriteLine("");
                Console.WriteLine("Divisão: d");
                Console.WriteLine("");
                Console.WriteLine("Multiplicação: m");

                Console.WriteLine("");

                Console.Write("Numero 1: ");
                n1 = float.Parse(Console.ReadLine());

                Console.Write("Numero 2: ");
                n2 = float.Parse(Console.ReadLine());

                Console.Write("Tipo operação: ");
                t = char.Parse(Console.ReadLine());

                switch (t)
                {
                    case 's':
                        calcular c1 = new calcular(Soma);
                        Console.WriteLine("Resultado -->  "+c1(n1, n2));
                        break;
                    case 'i':
                        calcular c2 = new calcular(Subtracao);
                        Console.WriteLine("Resultado -->  " + c2(n1, n2));
                        break;
                    case 'm':
                        calcular c3 = new calcular(Multiplicacao);
                        Console.WriteLine("Resultado -->  " + c3(n1, n2));
                        break;
                    case 'd':
                        calcular c4 = new calcular(Divisao);
                        Console.WriteLine("Resultado -->  " + c4(n1, n2));
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static float Soma(float i, float j)
        {
            return i + j;
        }

        private static float Subtracao(float i, float j)
        {
            return i - j;
        }

        private static float Divisao(float i, float j)
        {
            return i / j;
        }

        private static float Multiplicacao(float i, float j)
        {
            return i * j;
        }
    }
}
