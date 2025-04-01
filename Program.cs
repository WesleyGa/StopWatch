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
        Console.WriteLine("S = Segundos => 10s = 10 Segundos");
        Console.WriteLine("M = Minutos => 1m = 1 Minuto");
        Console.WriteLine("0 = Sair");
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

        // Caso seja 'M = minutos' multiplica o valor digitado por 60. 
        if (type == 'm')
            multiplier = 60;

        if (time == 0)
            System.Environment.Exit(0);

        Start(multiplier * time);
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);

            // Thread: O código que está sendo executado nesse momento
            // Sleep(1000): Pausa por 1000 milissegundos (ou seja, 1 segundo) antes de continuar a execução.
            Thread.Sleep(1000);


        }
        Menu();
    }
}
