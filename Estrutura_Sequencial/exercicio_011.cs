/*Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre:
a)o produto do dobro do primeiro com metade do segundo .
b)a soma do triplo do primeiro com o terceiro.
c)o terceiro elevado ao cubo.*/

using System;

class Exercicio_11{

    static void Main(){

        float num1 = 0;
        float num2 = 0;
        float num3 = 0;
        float produto = 0;
        float soma = 0;
        float cubo = 0;

        Console.WriteLine("Informe o primeiro número: ");
        num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo número: ");
        num2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o terceiro número: ");
        num3 = float.Parse(Console.ReadLine());

        produto = 2*num1*(num2/2);
        soma = 3*num1 + num3;
        cubo = num3*num3*num3;

        Console.WriteLine("O produto do dobro do primeiro com metade do segundo: " + produto);
        Console.WriteLine("A soma do triplo do primeiro com o terceiro: " + soma);
        Console.WriteLine("O terceiro elevado ao cubo: " + cubo);

    }
} 