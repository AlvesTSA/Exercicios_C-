/*24. Faça um programa que calcule o mostre a média aritmética de N notas.*/

using System;

public class exercicio_024{

    static void Main(){

        float nota = 0;
        float soma = 0;
        float media = 0;
        int contador = 0;
        int op = 0;

        do{
            Console.WriteLine("Informe a nota: ");
            nota = float.Parse(Console.ReadLine());

            soma += nota;
            contador++;
            
            Console.WriteLine("Deseja inserir mais uma nota ? [0]-Nao [1]-sim");
            op = int.Parse(Console.ReadLine());

        } while (op == 1);

        media = soma/contador;

        Console.WriteLine("Media = " + media);
    }
}