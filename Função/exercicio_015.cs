/*15. Faça um procedimento que recebe, por parâmetro, um valor N e calcula e escreve a tabuada de 1 até N. Mostre a tabuada na forma:

1 x N = N
2 x N = 2N
...
N x N = N^2*/

using System;

class exercicio_015
{
    static void Main()
    {
        int N = 0;

        Console.Write("Informe o numero que deseja ver a tabuada: ");
        N = int.Parse(Console.ReadLine());

        Tabuada(N);

    }
    static void Tabuada(int N)
    {
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine("{0} x {1} = {2}",i,N,N*i); 
        }
    }
}

