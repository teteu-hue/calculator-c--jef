using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora4op
{
    internal class Calculadora
    {

        public int Soma()
        {
            Console.WriteLine("********** SOMA **********");
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine("Resultado do calculo: {0}", result);

            return result;
        }
        public int Subtracao()
        {

            Console.WriteLine("********** SUBTRAÇÃO **********");
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 - num2;

            Console.WriteLine("Resultado do calculo: {0}", result);

            return result;

        }
        public int Multiplicacao()
        {

            Console.WriteLine("********** MULTIPLICAÇÃO **********");
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Toda multiplicação por zero é zero");
                return 0;
            }

            int result = num1 * num2;

            Console.WriteLine("Resultado do calculo: {0}", result);

            return result;
        }
        public double Divisao()
        {

            Console.WriteLine("********** DIVISÃO **********");
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Toda divisão por zero é zero");
                return 0;
            }

            double result = num1 / num2;

            Console.WriteLine("Resultado do calculo: {0}", result);

            return result;

        }
    }
}