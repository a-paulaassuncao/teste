using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            string continuar = "Sim";

            while (continuar == "Sim" || continuar == "sim" || continuar == "S" || continuar == "s")
            {
                Console.Clear();

                Console.Write("Olá, seja bem-vindo ao nosso MENU. Escolha uma das opções abaixo: \n" +
                    "\n1 - IMC \n" +
                    "2 - Maior ou menor com 3 números \n" +
                    "3 - Par ou Impar \n" +
                    "4 - Equação do 2º grau \n" +
                    "5 - Converter Fº para Cº \n" +
                    "6 - Converter Cº para Fº \n");

                Console.Write("\nDigite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                while (opcao < 1 || opcao > 6)
                {
                    Console.Write("Opção inválida. Digite novamente: ");
                    opcao = Convert.ToInt32(Console.ReadLine());
                }

                if (opcao == 1)
                {
                    Imc();
                }
                else if (opcao == 2)
                {
                    MaiorMenor();
                }
                else if (opcao == 3)
                {
                    ParImpar();
                }
                else if (opcao == 4)
                {
                    EquacaoSegundoGrau();
                }
                else if (opcao == 5)
                {
                    ConverterFahrenheitParaCelsius();
                }
                else if (opcao == 6)
                {
                    ConverterCelsiusParaFahrenheit();
                }
                else
                {
                    Console.WriteLine("\nOpção inválida. Por favor, escolha uma opção válida.\n");
                }

                Console.Write("\nDeseja continuar? (Sim ou Não): ");
                continuar = Console.ReadLine();
            }

            Console.Write("\nEncerrando programa... até logo!");
        }

        static void Imc()
        {
            /* Classificação de Peso:
                Abaixo de 18.5 - Abaixo do Peso
                Entre 18.5 e 24.9 - Peso Normal
                Entre 25 e 29.9 - Sobrepeso
                Entre 30 e 34.9 - Obsidade Grau 1
            */

            double peso, altura, imc;
            string result = "";

            Console.WriteLine("\nVamos calcular o IMC...\n");

            Console.Write("Informe seu peso (kg): ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe sua altura (m): ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc <= 18.5)
            {
                result = "Abaixo do Peso";
            }
            else if (imc < 24.9)
            {
                result = "Peso Normal";
            }
            else if (imc < 29.9)
            {
                result = "Sobrepeso";
            }
            else if (imc < 34.9)
            {
                result = "Obesidade Grau 1";
            }
            else if (imc > 35)
            {
                result = "Obesidade Grau 2";
            }

            Console.Write($"\nSeu IMC corporal é {imc:F2} - {result}\n");
        }

        static void MaiorMenor()
        {
            int contador = 0;
            double numero, maior, menor;

            Console.WriteLine("\nVamos verificar o maior ou menor número...\n");

            Console.Write($"Digite o {contador + 1}º número: ");
            numero = Convert.ToDouble(Console.ReadLine());
            maior = numero;
            menor = numero;
            contador++;

            while (contador < 3)
            {
                Console.Write($"Digite o {contador + 1}º número: ");
                numero = Convert.ToDouble(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }
                else if (numero < menor)
                {
                    menor = numero;
                }

                contador++;
            }

            Console.Write("\nO menor número é: " + menor);
            Console.Write("\nO maior número é: " + maior + "\n");
        }

        static void ParImpar()
        {
            int n1, result;
            string resultado;

            Console.WriteLine("\nVamos verificar se o número é par ou ímpar.");

            Console.Write("\nDigite um número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            result = n1 % 2;

            if (result == 0)
            {
                resultado = "par";
            }
            else
            {
                resultado = "ímpar";
            }

            Console.Write($"\nO número {n1} é {resultado}\n");
        }

        static void EquacaoSegundoGrau()
        {
            double a, b, c, delta, x1, x2;

            Console.WriteLine("\nVamos resolver a equação do 2º grau...\n");

            Console.Write("Digite o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = (b * b) - (4 * a * c);

            if (a == 0)
            {
                Console.WriteLine("O valor de 'a' não pode ser zero em uma equação do 2º grau.");
            }
            else if (delta >= 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"\nAs raízes da equação são: x1 = {x1:F2} e x2 = {x2:F2}");
            }
            else
            {
                Console.WriteLine("\nA equação não possui raízes reais.");
            }
        }

        static void ConverterFahrenheitParaCelsius()
        {
            double celsius, fahrenheit;

            Console.WriteLine("\nVamos converter Fahrenheit para Celsius...");

            Console.Write("\nDigite a temperatura em Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            celsius = (fahrenheit - 32) / 1.8;
            Console.WriteLine($"\nA temperatura em Celsius é: {celsius}");
        }
        static void ConverterCelsiusParaFahrenheit()
        {
            double celsius, fahrenheit;

            Console.WriteLine("\nVamos converter Celsius para Fahrenheit...");

            Console.Write("\nDigite a temperatura em Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine($"\nA temperatura em Fahrenheit é: {fahrenheit:F2}");
        }
    }
}