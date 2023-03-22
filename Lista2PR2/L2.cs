using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ativ. 1


            //float v1, v2, quant;

            //Console.WriteLine("Digite o número de laranjas a comprar: ");
            //quant = float.Parse( Console.ReadLine() );

            //if(quant < 12)
            //{
            //    v1 = quant * 0.35f;
            //    Console.WriteLine("O valor totral da compra é de R$" + v1);
            //}
            //else
            //{
            //    v2 = quant * 0.28f;
            //    Console.WriteLine("O valor total da cpmpra é de R$" + v2);
            //}

            //Console.ReadKey();


            //Ativ. 2


            //int ano;

            //Console.WriteLine("Digite o ano de nascimento: ");
            //ano = int.Parse( Console.ReadLine() );

            //if (ano > 2007)
            //{
            //    Console.WriteLine("Você não poderá exercer o direito ao voto");
            //}
            //else
            //{
            //    Console.WriteLine("Você poderá exercer o direito ao voto");
            //}

            //Console.ReadKey();


            //Ativ. 3


            //int L1, L2, L3;

            //Console.WriteLine("Digite o valor de um dos lados do triângulo: ");
            //L1 = int.Parse( Console.ReadLine() );
            //Console.WriteLine("Digite o valor do outro lado do triângulo: ");
            //L2 = int.Parse( Console.ReadLine() );
            //Console.WriteLine("Digite o valor do último lado do triângulo: ");
            //L3 = int.Parse( Console.ReadLine() );

            //if (L1 == L2 && L1 == L3)
            //{
            //    Console.WriteLine("Esse é um triângulo equilátero");
            //}
            //else
            //{
            //    if (L1 == L2 || L1 == L3 || L3 == L2)
            //    {
            //        Console.WriteLine("Esse é um triângulo isósceles");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Esse é um triângulo escaleno");
            //    }
            //}

            //Console.ReadKey();


            //Ativ. 4


            double a, b, c, delta, x1, x2;

            Console.WriteLine("Digite o valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de c: ");
            c = double.Parse(Console.ReadLine());

            delta = (b * b) - 4 * a * c;

            if(delta < 0)
            {
                Console.WriteLine("Não há raizes reais");
            }
            else if(delta == 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Há somente uma raiz real. x = " + x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Há duas raiz reais. x1 = " + x1 + " e x2 = " + x2);
            }

            Console.ReadKey();


            //Ativ. 5

            //int num;

            //Console.WriteLine("Digite um valor: ");
            //num = int.Parse(Console.ReadLine());

            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("O número é divisível por 3 e 5");
            //}
            //else if (num % 3 == 0)
            //{
            //    Console.WriteLine("O número é divisível por 3");
            //}
            //else if (num % 5 == 0)
            //{
            //    Console.WriteLine("O número é divisível por 5");
            //}
            //else
            //{
            //    Console.WriteLine("número não é divisível por 3 e nem por 5");
            //}

            //Console.ReadKey();


            //Ativ. 6


            //int A1, A2, A3;

            //Console.WriteLine("Digite o valor de um dos ângulos do triângulo: ");
            //A1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do outro ângulo do triângulo: ");
            //A2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor do último ângulo do triângulo: ");
            //A3 = int.Parse(Console.ReadLine());

            //if (A1 + A2 + A3 < 180 || A1 + A2 + A3 > 180)
            //{
            //    Console.WriteLine("Esse não é um triângulo");
            //}
            //else
            //{
            //    if (A1 == 90 || A2 == 90 || A3 == 90)
            //    {
            //        Console.WriteLine("Esse é um triângulo retângulo");
            //    }
            //    else if (A1 > 90 || A2 > 90 || A3 > 90)
            //    {
            //        Console.WriteLine("Esse é um triângulo obtusâno");
            //    }
            //    else if (A1 < 90 && A2 < 90 && A3 < 90)
            //    {
            //        Console.WriteLine("Esse é um triângulo acutângulo");
            //    }
            //}

            //Console.ReadKey();


            //Ativ. 7


            //int num1, num2, num3;

            //Console.WriteLine("Digite o primeiro valor: ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo valor: ");
            //num2 = int.Parse(Console.ReadLine());

            //if (num1 == num2)
            //{
            //    Console.WriteLine("Você já digitou esse número. Escreva outro: ");
            //}

            //Console.WriteLine("Digite o terceiro número: ");
            //num3 = int.Parse(Console.ReadLine());

            //if (num2 == num3 || num1 == num3)
            //{
            //    Console.WriteLine("Você já digitou esse número. Escreva outro: ");
            //}

            //if (num1 < num2 && num2 < num3)
            //{
            //    Console.WriteLine(num1 + " " + num2 + " " + num3);
            //}
            //else if (num1 < num3 && num3 > num2)
            //{
            //    Console.WriteLine(num1 + " " + num3 + " " + num2);
            //}
            //else if (num2 > num1 && num1 > num3)
            //{
            //    Console.WriteLine(num2 + " " + num1 + " " + num3);
            //}
            //else if (num2 > num3 && num3 > num1)
            //{
            //    Console.WriteLine(num2 + " " + num3 + " " + num1);
            //}
            //else if (num3 > num1 && num1 > num2)
            //{
            //    Console.WriteLine(num3 + " " + num1 + " " + num2);
            //}
            //else if (num3 > num2 && num2 > num1)
            //{
            //    Console.WriteLine(num3 + " " + num2 + " " + num1);
            //}

            //Console.ReadKey();


            //Ativ. 8


            //int ano;

            //Console.WriteLine("Digite um ano: ");
            //ano = int.Parse( Console.ReadLine() );

            //if(ano % 4 == 0)
            //{
            //    Console.WriteLine("Esse é um ano bissexto");
            //}
            //else
            //{
            //    Console.WriteLine("Esse não é um ano bissexto");
            //}

            //Console.ReadKey();


            //Ativ. 9


            //float num1, num2, R;
            //char op;

            //Console.WriteLine("Digite o primeiro número: ");
            //num1 = float.Parse( Console.ReadLine() );
            //Console.WriteLine("Digite o segundo número: ");
            //num2 = float.Parse( Console.ReadLine() );
            //Console.WriteLine("Escolha uma operação (+, -, *, /): ");
            //op = char.Parse(Console.ReadLine());

            //if(op == '+')
            //{
            //    R = num1 + num2;
            //    Console.WriteLine("Resultado = " + R);
            //}
            //else if(op == '-')
            //{
            //    R = num1 - num2;
            //    Console.WriteLine("Resultado = " + R);
            //}
            //else if (op == '*')
            //{
            //    R = num1 * num2;
            //    Console.WriteLine("Resultado = " + R);
            //}
            //else
            //{
            //    R = num1 / num2;
            //    Console.WriteLine("Resultado = " + R);
            //}

            //Console.ReadKey();
        }
    }
}
