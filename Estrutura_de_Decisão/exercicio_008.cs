/* Faça um programa que pergunte o preço de três produtos e informe qual produto você deve comprar, sabendo que a decisão é sempre pelo mais barato.*/

using System;

class excercicio_008{
    
    static void Main(){
        
        float produto_a = 0;
        float produto_b = 0;
        float produto_c = 0;
        float barato = 0;
        
        Console.WriteLine("Informe o preço de três produtos: ");
        produto_a = float.Parse(Console.ReadLine());
        produto_b = float.Parse(Console.ReadLine());
        produto_c = float.Parse(Console.ReadLine());
        
        if(produto_a < produto_b && produto_a < produto_c){
            
            barato = produto_a;
            
        }
        
        else if(produto_b < produto_a && produto_b < produto_c){
            
            barato = produto_b;
            
        }
        
        else{
            
            barato = produto_c;
            
        }
        
        Console.WriteLine("O produto mais barato é R$: " + barato);
    }
}