/*19. Faça um programa para imprimir:

1
1   2
1   2   3
.....
1   2   3   ...  n
para um n informado pelo usuário. Use uma função que receba um valor n inteiro imprima até a n-ésima linha.*/

using System;

class exercicio_019
{
    static void Main()
    {
        int n = 0;

        do
        {
            Console.Write("Informe um valor inteiro: ");
            n = int.Parse(Console.ReadLine());

            if (n <= 0) 
            {
                Console.WriteLine("Erro: o número deve ser inteiro e positivo.");
            }

        } while (n <= 0);

        Imprimir(n);
    }
    static void Imprimir(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0} ",j);
            }
            Console.WriteLine();
        }      
    }
}
