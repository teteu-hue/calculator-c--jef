using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora4op
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a calculadora do Teteu e da Dede");

            Calculadora calculadora = new Calculadora();

            int opcao = 0;

            do
            {
                Console.WriteLine("Qual calculo você precisa fazer?");
                Console.WriteLine("Digite as Opções: ");
                Console.WriteLine("==============================");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {

                    case 1:
                        calculadora.Soma();
                        break;

                    case 2:
                        calculadora.Subtracao();
                        break;

                    case 3:
                        calculadora.Multiplicacao();
                        break;

                    case 4:
                        calculadora.Divisao();
                        break;
                }

            } while (opcao != 0);
            
        }
    }
}
