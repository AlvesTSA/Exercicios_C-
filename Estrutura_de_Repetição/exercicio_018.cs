/*18. . Faça um programa que, dado um conjunto de N números, determine o menor valor, o maior valor e a soma dos valores.*/

using System;

class exercicio_018{

    static void Main(){

        int n = 0;
        int maior = 0;
        int menor = 0;
        int soma = 0;
        int num = 0;

        Console.Write("Informe quantos números deseja incluir: ");
        n = int.Parse(Console.ReadLine());
        num = int.Parse(Console.ReadLine());

        menor = num;
        maior = num;
        soma += num;

        for (int i = 1; i < n; i++){
            
            num = int.Parse(Console.ReadLine());

            soma += num;

            if (num < menor){
                
                menor = num;
            }
            else if(num > maior){

                maior = num;
            }

        }

        Console.Write("Maior = " + maior + "\nMenor = " + menor + "\nSoma = " + soma);
    }
}