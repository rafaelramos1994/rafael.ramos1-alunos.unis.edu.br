using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carimbo
{
    class Program
    {
        static void Main(string[] args)
        {
            string t, c;
            int i,carga,p;

            Console.WriteLine("Digite o texto que deseja escrever.");
            t = Console.ReadLine();
            Console.WriteLine("Digite cor que deseja escrever.");
            c = Console.ReadLine();
            do
            {
                Console.WriteLine("Digite uma quantidade de carga entre 1 e 10.");
                carga = Convert.ToInt32(Console.ReadLine());
            } while (carga < 1 || carga > 10);
            Console.Clear();
            Carimbo x = new Carimbo(t);
            Caneta o = new Caneta(null);
            x.carregar(c, carga);
            x.usar();
            Console.ReadKey();
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("1 - Usar carimbo.");
                    Console.WriteLine("2 - Usar caneta.");
                    p = Convert.ToInt32(Console.ReadLine());
                    if (p < 1 || p > 2)
                    {
                        Console.WriteLine("Escolha uma opção valida");
                        Console.ReadKey();
                    }

                } while (p != 1 && p != 2);
                Console.Clear();
                Console.WriteLine("1 - Trocar texto.");
                Console.WriteLine("2 - Trocar cor.");
                Console.WriteLine("3 - colocar carga.");
                Console.WriteLine("4 - Escrever na tela.");
                Console.WriteLine("6 - Sair.");
                i = Convert.ToInt32(Console.ReadLine());
                if (p == 1)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("Digite o texto que deseja escrever.");
                        t = Console.ReadLine();
                        Console.WriteLine("Troca realizada com sucesso.");
                        x.trocarTexto(t);
                        Console.ReadKey();
                    }
                    if (i == 2)
                    {
                        Console.WriteLine("Digite cor que deseja escrever.");
                        c = Console.ReadLine();
                        Console.WriteLine("Troca realizada com sucesso.");
                        x.trocarCor(c);
                        Console.ReadKey();
                    }
                    if (i == 3)
                    {
                        do
                        {
                            Console.WriteLine("Digite uma quantidade de carga entre 1 e 10.");
                            carga = Convert.ToInt32(Console.ReadLine());
                        } while (carga < 1 || carga > 10);
                        Console.WriteLine("Troca realizada com sucesso.");
                        x.carregar(c, carga);
                        Console.ReadKey();
                    }
                    if (i == 4)
                    {
                        x.usar();
                        Console.ReadKey();
                    }
                    if (i < 1 || i > 6)
                    {
                        Console.WriteLine("Escolha uma opção valida");
                        Console.ReadKey();
                    }
                }
                if (p == 2)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("Digite o texto que deseja escrever.");
                        t = Console.ReadLine();
                        Console.WriteLine("Troca realizada com sucesso.");
                        o.trocarTexto(t);
                        Console.ReadKey();
                    }
                    if (i == 2)
                    {
                        Console.WriteLine("Digite cor que deseja escrever.");
                        c = Console.ReadLine();
                        Console.WriteLine("Troca realizada com sucesso.");
                        o.trocarCor(c);
                        Console.ReadKey();
                    }
                    if (i == 3)
                    {
                        do
                        {
                            Console.WriteLine("Digite uma quantidade de carga entre 1 e 10.");
                            carga = Convert.ToInt32(Console.ReadLine());
                        } while (carga < 1 || carga > 10);
                        Console.WriteLine("Troca realizada com sucesso.");
                        o.carregar(c, carga);
                        Console.ReadKey();
                    }
                    if (i == 4)
                    {
                        o.usar();
                        Console.ReadKey();
                    }
                    if (i < 1 || i > 6)
                    {
                        Console.WriteLine("Escolha uma opção valida");
                        Console.ReadKey();
                    }
                }
            } while (i !=6);

			
		}
    }
}
