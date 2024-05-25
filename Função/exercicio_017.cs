/*17. Escreva uma função que recebe, por parâmetro, um valor inteiro e positivo e retorna o somatório desse valor.*/
using System;

class exercicio_017
{
    static void Main()
    {
        int soma = 0;
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
        
        soma = Somatorio(n);

        Console.WriteLine("Somatório de {0}: {1}",n,soma);
    }
    static int Somatorio(int n)
    {
        int soma = 0;

        for (int i = 1; i <= n; i++)
        {
            soma += i;
        }
        
        return soma;
    }
}

