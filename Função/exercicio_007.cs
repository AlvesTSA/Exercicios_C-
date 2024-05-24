/*7. Faça uma função que recebe um valor inteiro e verifica se o valor é positivo ou negativo. A função deve retornar um valor booleano.*/

using System;
class exercicio_007
{
    static void Main()
    {
        int num = 0;
    
        Console.Write("Informe um valor inteiro: ");
        num = int.Parse(Console.ReadLine());

        if (Positivo_negativo(num))
        {
            Console.WriteLine("O valor informado é positivo.");
        }
        else
        {
           Console.WriteLine("O valor informado é negativo.");
        }
    }

    static bool Positivo_negativo(int numero)
    {
        return numero > 0;
    }
}
