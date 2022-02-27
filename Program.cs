using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar ?");


            string data = Console.ReadLine().ToLower(); // ToLower() Transforma tudo em minúsculo 
            char tipo = char.Parse(data.Substring(data.Length - 1, 1)); // data.Length - 1 serve pra contar quantos caracteres tem no array, no casso digitado e subtrai um pra se ter a última posição do array  
            int tempo = int.Parse(data.Substring(0, data.Length - 1));
            int multiplicador = 1;

            if (tipo == 'm')

                multiplicador = 60;

            if (tempo == 0)

                System.Environment.Exit(0);


            PreStart(tempo * multiplicador);

        }

        static void PreStart(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Preparando...");
            Thread.Sleep(1000);
            Console.WriteLine("Configurando...");
            Thread.Sleep(1000);
            Console.WriteLine("Já...");
            Thread.Sleep(2500);

            Start(tempo);
        }

        static void Start(int tempo)
        {

            int tempoAtual = 0;
            while (tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000); // Thread.Sleep(1000); faz com que o sistema espere 1 segundo para ir para o próximo laço de repetição

            }
            Console.Clear();
            Console.WriteLine("Cronômetro finalizado ! Retornando para o Menu ...");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
