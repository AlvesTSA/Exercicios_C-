/*O Hipermercado Tabajara está com uma promoção de carnes que é imperdível. Confira:
 
Até 5 Kg de File Duplo: R$ 4,90 por Kg 
 
Acima de 5 Kg de File Duplo: R$ 5,80 por Kg
 
Até 5 Kg de Alcatra: R$  5,90 por Kg 

Acima de 5 Kg de Alcatra: R$ 6,80 por Kg

Até 5 Kg de Picanha: R$  6,90 por Kg 
 
Acima de 5 Kg de Picanha: R$ 7,80 por Kg

Para atender a todos os clientes, cada cliente poderá levar apenas um dos tipos de carne da promoção, porém não há limites para a quantidade de carne por cliente. Se compra for feita no cartão Tabajara o cliente receberá ainda um desconto de 5% sobre o total da compra. Escreva um programa que peça o tipo e a quantidade de carne comprada pelo usuário e gere um cupom fiscal, contendo as informações da compra: tipo e quantidade de carne, preço total, tipo de pagamento, valor do desconto e valor a pagar.*/

using System;

class exercicio_027{ 

    static void Main(){

        int op = 0;
        int op2 = 0;
        double kilo = 0;
        double valor = 0;
        double desconto = 0;
        double valor_pago = 0;
        string tipo_carne = "";
        string tipo_pag = "";

        Console.WriteLine("Informe a quantidade de carne");
        kilo = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o tipo de carne:\n[1]-File Duplo\n[2]-Alcatra\n[3]-Picanha");
        op = int.Parse(Console.ReadLine());

        switch (op){

            case 1: tipo_carne = "File Duplo";

                if(kilo > 0 && kilo <= 5){

                    valor = kilo*4.90;
                }
                else{

                    valor = kilo*5.80;
                }

            break;

            case 2: tipo_carne = "Alcatra";

                if(kilo > 0 && kilo <= 5){

                    valor = kilo*5.90;

                }
                else{

                    valor = kilo*6.80;
                }

            break;

            case 3: tipo_carne = "Picanha";

                if(kilo > 0 && kilo <= 5){

                    valor = kilo*6.90;
                }
                else{
                    
                    valor = kilo*7.80;
                    
                }

            break;
            
            default:

                Console.WriteLine("Informe uma opção válida");

                Environment.Exit(0);

            break;
        }

        Console.WriteLine("Informe a forma de pagamento:\n[1]-Cartão tabajara\n[2]-Outro cartão");
        op2 = int.Parse(Console.ReadLine());

        switch (op2){

            case 1: tipo_pag = "Cartão tabajara";

                desconto = valor*0.05;
                valor_pago = valor - desconto;

            break;

            case 2: tipo_pag = "Outro cartão";

                valor_pago = valor;

            break;
            
            default:

                Console.WriteLine("Informe um valor válido");
                Environment.Exit(0);

            break;
        }

        Console.WriteLine("Tipo de carne: " + tipo_carne + "\nPeso: " + kilo + "\nValor total: " + valor + "\nTipo de pagamento: " + tipo_pag + "\nDesconto: " + desconto + "\nValor a pagar: " + valor_pago);

        Environment.Exit(0);

    }
}