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

            //if (ano > 2005)
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


            //double a, b, c, delta, x1, x2;

            //Console.WriteLine("Digite o valor de a: ");
            //a = double.Parse( Console.ReadLine() );
            //Console.WriteLine("Digite o valor de b: ");
            //b = double.Parse( Console.ReadLine() );
            //Console.WriteLine("Digite o valor de c: ");
            //c = double.Parse( Console.ReadLine() );

            //delta = (b * b) - 4 * a * c;
            //x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            //x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            //Console.WriteLine("Os valores da equação são " + x1 + " e " + x2);
            //Console.ReadKey();


            //Ativ. 5

            int num;

            Console.WriteLine("Digite um valor: ");
            num = int.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("O número é divisível por 3 e 5");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("O número é divisível por 3");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("O número é divisível por 5");
            }

            Console.ReadKey();
        }
    }
}
