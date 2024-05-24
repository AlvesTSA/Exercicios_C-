/*13. Faça uma função que receba um valor inteiro e positivo e calcula o seu fatorial.*/
using System;
class exercicio_013
{
    static void Main()
    {
        int num = 0;
        int fatorial = 0;

        Console.Write("Informe um numero inteiro e positivo: ");

        fatorial = CalcFatorial(out num);

        Console.Write("{0}! = {1}",num,fatorial);

    }    
    static int CalcFatorial(out int numero)
    {
        numero = 0;
        int fatorial = 1;

        do
        {
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("ERRO: o numero informado deve ser maior ou igual a zero.");
            }
            
        } while (numero < 0);
        
        for (int i = 2; i <= numero; i++)
        {
            fatorial *= i;
        }
        
        return fatorial;
    }
}

