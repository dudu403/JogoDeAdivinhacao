using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinhe_se_Poder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int pontosDeVida = 100;
            int pontuacao = 0;
            int numeroChute = 0;
            char EscolhaDificuldade;
            int facil = 15;
            int media = 10;
            int dificil = 5;
            int escolha;

            int aleatorio = rand.Next(1, 20);
            Console.WriteLine(aleatorio);

            Console.WriteLine("****************************************" +
                              "\n* Bem-vindo(a) ao Jogo da Adivinhação  *" +
                              "\n****************************************");
           
            Console.WriteLine("(1) Fácil -- (2) Médio -- (3) Difícil");
            Console.Write("Escolha: ");


            EscolhaDificuldade = char.Parse(Console.ReadLine());
            Console.Clear();

            switch (EscolhaDificuldade)
            {
                // fácil
                case '1':

                    Console.WriteLine(" -- Dificuldade fácil --");
                    Console.WriteLine("Você possui 15 tentativas!");


                    for (int i = 0; i < facil; i++)
                    {
                        Console.WriteLine($"Tentativa {i + 1} de {facil} \n");
                        Console.WriteLine("----------------------------------");
                        Console.Write($"Qual seu {i + 1}º chute? ");
                        escolha = int.Parse(Console.ReadLine());

                        Console.Clear();

                        if (escolha < aleatorio)
                        {
                            pontuacao = Math.Abs((numeroChute - aleatorio) / 2);
                            pontosDeVida = pontosDeVida - pontuacao;

                            Console.WriteLine("Seu chute foi menor que o número aléatorio ");
                            Console.WriteLine($"Você fez {pontosDeVida} pontos");
                        }

                        if (escolha > aleatorio)
                        {
                            pontuacao = Math.Abs((numeroChute - aleatorio) / 2);
                            pontosDeVida = pontosDeVida - pontuacao;

                            Console.WriteLine("Seu chute foi maior que o número aleatório ");
                            Console.WriteLine($"Você fez {pontosDeVida}");
                        }
                        if (escolha == aleatorio)
                        {
                            Console.WriteLine("Você acertou");
                            Console.WriteLine($"Seus pontos de vida é {pontosDeVida}");
                            break;
                        }

                        if (i + 1 >= facil)
                        {
                            Console.WriteLine("Acabaram suas tentativas");
                            Console.ReadLine();
                        }
                    }

                    break;

                    // média
                case '2':
                    Console.WriteLine(" -- Dificuldade média --");
                    Console.WriteLine("Você possui 10 tentativas!");

                    for(int i = 0; i < media; i++)
                    {
                        Console.WriteLine($"Tentativa {i + 1} de {media} \n");
                        Console.WriteLine("----------------------------------");
                        Console.Write($"Qual seu {i + 1}º chute? ");
                        escolha = int.Parse(Console.ReadLine());

                        Console.Clear();

                        if(escolha == aleatorio)
                        {
                            Console.WriteLine("Você acertou");
                            Console.WriteLine($"Seus pontos de vida é {pontosDeVida}");
                            break;
                        }

                        if(escolha < aleatorio)
                        {
                            pontuacao = Math.Abs((numeroChute - aleatorio) / 2);
                            pontosDeVida = pontosDeVida - pontuacao;

                            Console.WriteLine("Seu chute foi menor que o número aléatorio ");
                            Console.WriteLine($"Você fez {pontosDeVida} pontos");
                        }

                        if(escolha > aleatorio)
                        {
                            pontuacao = Math.Abs((numeroChute - aleatorio) / 2);
                            pontosDeVida = pontosDeVida - pontuacao;

                            Console.WriteLine("Seu chute foi maior que o número aleatório ");
                            Console.WriteLine($"Você fez {pontosDeVida}");
                        }

                        if (i + 1 >= media)
                        {
                            Console.WriteLine("Acabaram suas tentativas");
                            Console.ReadLine();
                        }

                    }

                    break;

                    // difícil
                case '3':
                    Console.WriteLine(" -- Dificuldade difícil --");
                    Console.WriteLine("Você possui 10 tentativas!");

                    for (int i = 0; i < media; i++)
                    {
                        Console.WriteLine($"Tentativa {i + 1} de {dificil} \n");
                        Console.WriteLine("----------------------------------");
                        Console.Write($"Qual seu {i + 1}º chute? ");
                        escolha = int.Parse(Console.ReadLine());

                        Console.Clear();

                        if (escolha == aleatorio)
                        {
                            Console.WriteLine("Você acertou");
                            Console.WriteLine($"Seus pontos de vida é {pontosDeVida}");
                            break;
                        }

                        if (escolha < aleatorio)
                        {
                            pontuacao = Math.Abs((numeroChute - aleatorio) / 2);
                            pontosDeVida = pontosDeVida - pontuacao;

                            Console.WriteLine("Seu chute foi menor que o número aléatorio ");
                            Console.WriteLine($"Você fez {pontosDeVida} pontos");
                        }

                        if (escolha > aleatorio)
                        {
                            pontuacao = Math.Abs((numeroChute - aleatorio) / 2);
                            pontosDeVida = pontosDeVida - pontuacao;

                            Console.WriteLine("Seu chute foi maior que o número aleatório ");
                            Console.WriteLine($"Você fez {pontosDeVida}");
                        }

                        if (i + 1 >= dificil)
                        {
                            Console.WriteLine("Acabaram suas tentativas");
                            Console.ReadLine();
                        }

                    }
                    break;

            }
        }
    }
}