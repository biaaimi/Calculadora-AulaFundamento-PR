using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args) {
            {
                double Num1, Num2, Resultado = 0;
                char Operacao;

                Console.WriteLine("Entre com a operação--> ");
                Console.WriteLine("+ Adição------>");
                Console.WriteLine("- Subtração----->");
                Console.WriteLine("* Multiplicação------>");
                Console.WriteLine("/ Divisão---------->");
                Console.WriteLine("----------------------");

                Console.WriteLine();

                Console.Write("Operação: ");

                char.TryParse(Console.ReadLine(), out Operacao);

                Console.WriteLine();
                Console.WriteLine("Informe o  primeiro valor: ");
                double.TryParse(Console.ReadLine(), out Num1);

                Console.WriteLine();
                Console.WriteLine("Informe o segundo valor: ");
                double.TryParse(Console.ReadLine(), out Num2);

                Console.WriteLine();
                Console.WriteLine();

                switch (Operacao)
                {
                    case '-':
                        Resultado = Subtracao(Num1, Num2);
                        break;

                    case '+':
                        Resultado = Adicao(Num1, Num2);
                        break;

                    case '*':
                        Resultado = Multiplicacao(Num1, Num2);
                        break;

                    case '/':
                        Resultado = Divisao(Num1, Num2);
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(string.Format("Resultado: {0}", Resultado));

                Console.ReadKey();
            }

             static Double Adicao(double Num1, double Num2)
            {
                return (Num1 + Num2);
            }

             static Double Subtracao(double Num1, double Num2)
            {
                return (Num1 - Num2);
            }

             static Double Multiplicacao(double Num1, double Num2)
            {
                return (Num1 * Num2);
            }

             static Double Divisao(double Num1, double Num2)
            {
                return (Num1 / Num2);
            }
        }
    }
}