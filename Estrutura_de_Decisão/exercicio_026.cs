/* Uma fruteira está vendendo frutas com a seguinte tabela de preços:

Até 5 Kg de morango: R$ 2,50 por Kg 
  
Acima de 5 Kg de morango: R$ 2,20 por Kg

Até 5 Kg de maçã: R$ 1,80 por Kg 

Acima de 5 Kg de maçã: R$ 1,50 por Kg

Se o cliente comprar mais de 8 Kg em frutas ou o valor total da compra ultrapassar R$ 25,00, receberá ainda um desconto de 10% sobre este total. Escreva um algoritmo para ler a quantidade (em Kg) de morangos e a quantidade (em Kg) de maças adquiridas e escreva o valor a ser pago pelo cliente.*/

using System;

class exercicio_026{

    static void Main(){

        double kilo_ma = 0;
        double kilo_mo = 0;
        double valor = 0;
        double valor_ma = 0;
        double valor_mo = 0;
        double kilo_total = 0;
        double desconto = 0;

        Console.WriteLine("Informe a quantidade morango:");
        kilo_mo = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a quantidade maça:");
        kilo_ma = double.Parse(Console.ReadLine());

        if(kilo_mo > 0 && kilo_mo <= 5){

            valor_mo = kilo_mo*2.50;
        }
        else{

            valor_mo = kilo_mo*2.20;

        }
        if(kilo_ma > 0 && kilo_ma <= 5){

            valor_ma = kilo_ma*1.80;
        }
        else{

            valor_ma = kilo_ma*1.50;

        }

        kilo_total = kilo_ma + kilo_mo;
        valor = valor_ma + valor_mo;

        if(kilo_total > 8 || valor > 25){

            desconto = valor*0.10;
            valor = valor - desconto;
        }
        else{

            valor = valor;
            
        }  
        
        Console.WriteLine("Valor a ser pago R$: " + valor);      

    }
}