/*28. Faça um programa que calcule o valor total investido por um colecionador em sua coleção de CDs e o valor médio gasto em cada um deles. O usuário deverá informar a quantidade de CDs e o valor para em cada um.*/

using System;

public class exercicio_028{

    static void Main(){

        int quant_cd = 0;
        float valor_cd = 0;
        float soma = 0;
        float media = 0;

        Console.WriteLine("Informe a quantidade de CDs: ");
        quant_cd = int.Parse(Console.ReadLine());

        for (int i = 1; i <= quant_cd; i++){
            
            Console.WriteLine("Informe o valor do CD " + i + ":");
           
            valor_cd = float.Parse(Console.ReadLine());

            soma += valor_cd; 
        }

        media = soma/quant_cd;

        Console.WriteLine("Preco medio de cada CD: " + media);
        Console.WriteLine("Total de custos dos CDs: " + soma);
    }
}