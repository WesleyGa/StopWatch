using System;
using System.Threading;

namespace Stopwatch;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Deseja fazer a contagem em ordem crescente ou decrescente?");
        Console.WriteLine("1 = Crescente");
        Console.WriteLine("2 = Decrescente");
        Console.WriteLine("0 = Sair");


        int ordem = int.Parse(Console.ReadLine());
        if (ordem == 0)
            System.Environment.Exit(0);

        Console.Clear();
        Console.WriteLine("S = Segundos => 10s = 10 Segundos");
        Console.WriteLine("M = Minutos => 1m = 1 Minuto");
        Console.WriteLine("0 = Voltar");
        Console.WriteLine("Quanto tempo deseja contar?");

        // '.ToLower()' converte todos os caracteres da string para minúsculas.
        string data = Console.ReadLine().ToLower();
        // 'char.Parse()' converte uma string para um único caractere.  
        // 'Substring()' extrai uma parte da string com base na posição informada.  
        // 'data.Length' retorna o tamanho total da string (quantidade de caracteres).  
        // Como os índices começam em 0, o último caractere está na posição Length - 1.
        char type = char.Parse(data.Substring(data.Length - 1, 1)); // Pega o último caractere
        int time = int.Parse(data.Substring(0, data.Length - 1)); // Pega todos os caracteres antes do último caractere.
        int multiplier = 1;

        //Caso o usuario digíte uma letra inválida ou não digite nada.
        if (type != 's' && type != 'm')
        {
            Console.Clear();
            Console.WriteLine("Por favor, informe 'M' para minutos ou 'S' para segundos !");
            Thread.Sleep(4000);
            Menu();
        }


        // Caso seja 'M = minutos' multiplica o valor digitado por 60. 
        if (type == 'm')
            multiplier = 60;

        if (time == 0)
            Menu();


        Start(multiplier * time, ordem);
    }

    static void Start(int time, int ordem)
    {
        int currentTime = 0;

        if (ordem == 1)
        {
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);

                // Thread: O código que está sendo executado nesse momento
                // Sleep(1000): Pausa por 1000 milissegundos (ou seja, 1 segundo) antes de continuar a execução.
                Thread.Sleep(1000);
            }
        }
        else
        {   // sei o for apenas para diferenciar um pouco.
            for (int i = time; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        Menu();
    }

}




