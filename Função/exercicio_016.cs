/*16. Faça uma função que recebe, por parâmetro, um valor inteiro e positivo e retorna o número de divisores desse valor.*/

using System;

class exercicio_016
{
    static void Main()
    {
        int count = 0;
        int valor = 0;

        Console.Write("Informe um numero inteiro: ");
        valor = int.Parse(Console.ReadLine());

        count = Divisores(valor);

        Console.WriteLine("O valor informado e divisivel por {0} numeros.",count);
    }

    static int Divisores(int valor)
    {
        float resto = 0;
        int count = 0;

        for (int i = 1; i <= valor; i++)
        {
            resto = valor % i;

            if (resto == 0)
            {
                count++;
            }
        }
        
        return count;
    }
}

