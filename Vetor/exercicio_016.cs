/*16. Utilize uma lista para resolver o problema a seguir. Uma empresa paga seus vendedores com base em comissões. O vendedor recebe $200 por semana mais 9 por cento de suas vendas brutas daquela semana. Por exemplo, um vendedor que teve vendas brutas de $3000 em uma semana recebe $200 mais 9 por cento de $3000, ou seja, um total de $470. Escreva um programa (usando um array de contadores) que determine quantos vendedores receberam salários nos seguintes intervalos de valores:

 a. $200 - $299 

 b. $300 - $399 

 c. $400 - $499

 d. $500 - $599

 e. $600 - $699
 
 f. $700 - $799
 
 g. $800 - $899

 h. $900 - $999

 i. $1000 em diante

Desafio: Crie ma fórmula para chegar na posição da lista a partir do salário, sem fazer vários ifs aninhados.*/

using System;

class exercicio_016{

    static void Main(){

        int[] contador  = new int[9];
        double comisao = 0.09;
        double venda = 0;

        Console.WriteLine("informe o valor das vendas ou digite -1 parasair:");

        for (int i = 0; i < 100; i++){
            
            Console.WriteLine("Vendedor " + (i + 1) + ": ");
            venda = double.Parse(Console.ReadLine());

            if (venda == -1){
                
                break;
            }

            venda = venda * comisao; 
            venda = (venda + 200) / 100;
            
            if (venda >= 10){
                
                contador[8]++;
            }
            else{

                contador[(int)(venda - 2)]++;
            } 
        }

        Console.WriteLine("a. $200 - $299: " + contador[0] + " vendedores");
        Console.WriteLine("b. $300 - $399: " + contador[1] + " vendedores");
        Console.WriteLine("c. $400 - $499: " + contador[2] + " vendedores");
        Console.WriteLine("d. $500 - $599: " + contador[3] + " vendedores");
        Console.WriteLine("e. $600 - $699: " + contador[4] + " vendedores");
        Console.WriteLine("f. $700 - $799: " + contador[5] + " vendedores");
        Console.WriteLine("g. $800 - $899: " + contador[6] + " vendedores");
        Console.WriteLine("h. $900 - $999: " + contador[7] + " vendedores");
        Console.WriteLine("i. $1000 em diante: " + contador[8] + " vendedores");
    }
}