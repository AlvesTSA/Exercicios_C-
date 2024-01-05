/*33. O Departamento Estadual de Meteorologia lhe contratou para desenvolver um programa que leia as um conjunto indeterminado de temperaturas, e informe ao final a menor e a maior temperaturas informadas, bem como a média das temperaturas.*/

using System;

class exercicio_033{

    static void Main(){

        int t = 0;
        int soma = 0;
        float media = 0;
        int maior = 0;
        int menor = 0;
        int op = 0;
        int i = 1;

        Console.Write("Informe a temperatura 1: ");
        t = int.Parse(Console.ReadLine());
        maior = t;
        menor = t;
        soma = t;
        do{
            i++;
            Console.Write("Informe a temperatura " + i + ": ");
            t = int.Parse(Console.ReadLine());
            soma += t;
            if (t > maior){
                maior = t;
            }
            else if(t < menor){
                menor = t;
            }

            Console.Write("Deseja adicionar mais uma temperatura ? [0]-Nao [1]-Sim: ");
            op = int.Parse(Console.ReadLine());
            
        } while (op == 1);
        
        media = (float)soma/i;

        Console.Write("Maior temperatura: " + maior);
        Console.WriteLine("\nMenor temperatura: " + menor);
        Console.WriteLine("\nTemperatura media: " + $"{media:0.00}");
    }
}