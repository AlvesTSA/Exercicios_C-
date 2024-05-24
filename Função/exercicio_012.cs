/*12. Faça uma função que leia um número não determinado de valores positivos e retorna a média aritmética dos mesmos.*/

using System;

class exercicio_012
{
    static void Main()
    {
        float media = MediaAritmetica();
        string media_f = media.ToString("F2");
        Console.WriteLine("Media aritmetica: {0}",media_f);
    }

    static float MediaAritmetica()
    {
        float media = 0.0F;
        float numero = 0.0F;
        int count = 0;

        Console.WriteLine("Informe numeros inteiros ou informe -1 para sair:");

        do
        {
            numero = float.Parse(Console.ReadLine());

            if (numero == -1)
            {
                break;
            }
            
            media += numero;
            count++;
            
        } while (numero != -1);

        return media / count;
    }

}