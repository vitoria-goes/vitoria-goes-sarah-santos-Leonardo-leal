using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra1, palavra2, palavra3, palavra4, palavra5, palavrachave = "jiafei", palavra11, palavra12, palavra13, palavra14, palavra15, proximo;
            int roda, tentativas = 0, roda2, tentativas1 = 0;

            Console.WriteLine("adivinha de leo vitoria goes e sarah santos");        // Aqui estao as variaveis utilizadas//
            Console.WriteLine("regras:");
            Console.WriteLine("*os jogadores devem acertar a palavra-chave");
           Console.ReadLine();


            Console.Clear();                                     
            Console.WriteLine("Jogador 1");                          // Informamos o jogador a escrever as palavras//
            Console.WriteLine("digite a primeira palavra");       
            palavra1 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("digite a segunda palavra");
            palavra2 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("digite a terceira palavra");
            palavra3 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("digite a quarta palavra");
            palavra4 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("digite a quinta palavra");
            palavra5 = Console.ReadLine();


            Random adivinhador = new Random();                  //Escolhe aleatoriamente qual sera a palavra chave//
            roda = adivinhador.Next(4);


            Console.WriteLine(roda);

            if (roda == 0)                                     // Usamos para identificar oque aconteceria com cada palavra usada//
            {
                palavrachave = palavra1;
                Console.ReadKey();
            }
            else if (roda == 1)
            {
                palavrachave = palavra2;
                Console.ReadKey();
            }
            else if (roda == 2)
            {
                palavrachave = palavra3;
                Console.ReadKey();
            }
            else if (roda == 3)
            {
                palavrachave = palavra4;
                Console.ReadKey();
            }
            else if (roda == 4)
            {
                palavrachave = palavra5;
                Console.ReadKey();
            }


            Console.WriteLine("próximo Jogador");                         //Passamos agora para o Jogador2 que tentara adivinhar qual é a palavra//
            proximo = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Jogador 2");
            Console.WriteLine("digite a primeira palavra");
            palavra11 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("digite a segunda palavra");
            palavra12 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("digite a terceira palavra");
            palavra13 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("digite a quarta palavra");
            palavra14 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("digite a quinta palavra");
            palavra15 = Console.ReadLine();


            Random adivinhador1 = new Random();
            roda2 = adivinhador.Next(4);


            Console.WriteLine(roda);

            if (roda2 == 0)                                  // Dependendo de qual palavra o jogador2 podera acertar ou nao//
            {
                palavra11 = palavrachave;
                Console.ReadKey();
            }
            else if (roda2 == 1)
            {
                palavra12 = palavrachave;
                Console.ReadKey();
            }
            else if (roda2 == 2)
            {
                palavra13 = palavrachave;
                Console.ReadKey();
            }
            else if (roda2 == 3)
            {
                palavra14 = palavrachave;
                Console.ReadKey();
            }
            else if (roda2 == 4)
            {
                palavra15 = palavrachave;
                Console.ReadKey();
            }

            
            Console.WriteLine("você adivinhou a palavra chave em "          // Mostra em quantas tentativas o jogador acertou e se ele ganhou ou nao//
             + tentativas1 + " tentativas");

            if (tentativas < tentativas1)
            {
                Console.WriteLine("Jogador 2 ganhou");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Jogador 1 ganhou");
                Console.ReadKey();
            }

            Console.ReadKey();


        }

    }
    }

