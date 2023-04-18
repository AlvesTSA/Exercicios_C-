/*Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.*/

using System;

class Exercicio_16{

    static void Main(){

        double area = 0;
        double litros_necessario = 0;
        double lata = 0;
        double preco_total = 0;

        Console.WriteLine("Informe a área a ser pintada: ");
        area = double.Parse(Console.ReadLine());

        litros_necessario = area/3;
        lata = litros_necessario/18;
        preco_total = lata*80;

        Console.WriteLine("Quantidade de latas: " + lata);
        Console.WriteLine("Preço total R$: " + preco_total);
        
    }
}