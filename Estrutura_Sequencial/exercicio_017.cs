/*Faça um Programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 6 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00 ou em galões de 3,6 litros, que custam R$ 25,00.
Informe ao usuário as quantidades de tinta a serem compradas e os respectivos preços em 2 situações:
a)comprar apenas latas de 18 litros;
b)comprar apenas galões de 3,6 litros;
*/

using System;

class Exercicio_17{

    static void Main(){

        double lata = 0;
        double galao = 0;
        double litros_necessario = 0;
        double preco_lata = 0;
        double preco_galao = 0;
        double area = 0;

        Console.Write("Informe a área a ser pintada: ");
        area = double.Parse(Console.ReadLine());

        litros_necessario = area/6;
        lata = litros_necessario/18;
        galao = litros_necessario/3.6;
        preco_lata = lata*80;
        preco_galao = galao*25;

        Console.WriteLine("Quantidade de latas: " + lata);
        Console.WriteLine("Quantidade de galões: " + galao);
        Console.WriteLine("Preço em latas R$: " + preco_lata);
        Console.WriteLine("Preço em galões R$: " + preco_galao);
        
    }
}