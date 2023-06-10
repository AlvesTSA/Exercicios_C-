/* Um posto está vendendo combustíveis com a seguinte tabela de descontos:

Álcool:
 
Até 20 litros: desconto de 3% por litro;
 
Acima de 20 litros: Desconto de 5% por litro.

Gasolina:

Até 20 litros: desconto de 4% por litro

Acima de 20 litros, desconto de 6% por litro

Escreva um algoritmo que leia o número de litros vendidos, o tipo de combustível (codificado da seguinte forma: A-álcool. G-gasolina), calcule e imprima o valor a ser pago pelo cliente.*/

using System;

class exercicio_023{

    static void Main(){

        char op;
        double litro = 0;
        double preco_litro = 0;
        double desconto = 0;
        double valor = 0;

        Console.WriteLine("Informe a quantidade de combustível");
        litro = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o combustivel\nA-álcool\nG-gasolina");
        op = char.Parse(Console.ReadLine());

        switch(op){

            case 'A':

                if(litro <= 20 && litro > 0){

                    preco_litro = 4;
                    desconto = preco_litro*0.03;
                    preco_litro = preco_litro - desconto;
                    valor = preco_litro*litro;
                }
                else{

                    preco_litro = 4;
                    desconto = preco_litro*0.05;
                    preco_litro = preco_litro - desconto;
                    valor = preco_litro*litro;
                }
                
                    break;
            case 'G':
        
                if(litro <= 20 && litro > 0){

                    preco_litro = 5;
                    desconto = preco_litro*0.04;
                    preco_litro = preco_litro - desconto;
                    valor = preco_litro*litro;
                }
                else{

                    preco_litro = 5;
                    desconto = preco_litro*0.06;
                    preco_litro = preco_litro - desconto;
                    valor = preco_litro*litro;
                }
                    break;

            default :

                Console.WriteLine("Informe um valor válido.");
                Environment.Exit(0);
                break;
               
        }

        Console.WriteLine("Valor: " + valor);
        
    }
}