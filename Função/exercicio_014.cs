/*14. Faça um procedimento que lê 50 valores inteiros e retorna o maior e o menor deles.*/

using System;

class exercicio_014
{
    static void Main()
    {
        int maior,menor = 0;

        Console.WriteLine("informe 50 valores inteiros: ");

        Maior_menor(out maior,out menor);

        Console.Write("Maior:{0}\nMenor: {1}",maior,menor);

    }

    static void Maior_menor(out int maior,out int menor)
    {
        int valores = 0;
        maior = int.MinValue;// Inicializa o maior com o menor valor possível de um inteiro
        menor = int.MaxValue;// Inicializa o menor com o maior valor possível de um inteiro
        Random rand = new Random();

        for (int i = 0; i < 50; i++){
            
            valores = rand.Next(10000); //usado para gerar numeros aleatórios e simular entrada do usuário.

            //valores = int.Parse(Console.ReadLine); Aqui, os valores de entrada foram substituidos por uma função que gera números aleatórios

            if (valores > maior)
            {
                maior = valores;
                
            }
            if (valores < menor)
            {
                menor = valores;
            } 
        }
    }
}

