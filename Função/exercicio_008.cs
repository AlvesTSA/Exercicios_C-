/*8. Faça uma função que recebe um valor inteiro e verifica se o valor é par ou ímpar. A função deve retornar um valor booleano*/
using System;
class exercicio_008
{
    static void Main()
    {
        int num = 0;

        Console.Write("Informe um numero inteiro: ");
        num = int.Parse(Console.ReadLine());

        if (Impar_par(num))
        {
            Console.WriteLine("O numero informado é PAR");
        }
        else
        {
            Console.WriteLine("O numero informado é IMPAR");
        }
    }
    static bool Impar_par(int numero)
    {
        return numero % 2 == 0;
    }
}