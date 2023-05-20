/* Faça um programa que peça os 3 lados de um triângulo. O programa deverá informar se os valores podem ser um triângulo. Indique, caso os lados formem um triângulo, se o mesmo é: equilátero, isósceles ou escaleno.

Dicas:
 
Três lados formam um triangulo quando a soma de quaisquer dos dois lados é maior que o terceiro; 
 
Triângulo Equilátero: três lados iguais; 

Triângulo Isósceles: quaisquer dois lados iguais;
 
Triângulo Escaleno: três lados diferentes.*/

using System;

class exercicio_015{

    static void Main(){

        float lado_a = 0;
        float lado_b = 0;
        float lado_c = 0;

        Console.WriteLine("Informe os lados do triângulo:");
        lado_a = float.Parse(Console.ReadLine()); 
        lado_b = float.Parse(Console.ReadLine());
        lado_c = float.Parse(Console.ReadLine());

        if ((lado_a + lado_b) > lado_c && (lado_b + lado_c) > lado_a && (lado_a + lado_c) > lado_b && lado_a > 0 && lado_b > 0 && lado_c > 0){

            if (lado_a == lado_b && lado_a == lado_c && lado_b == lado_c){

                Console.WriteLine("Triângulo equilátero");
            
            }
            else if (lado_a == lado_b || lado_a == lado_c || lado_b == lado_c){
                
                Console.WriteLine("Triângulo isósceles");

            }
            else if (lado_a != lado_b && lado_a != lado_c && lado_b != lado_c){
                
                Console.WriteLine("Triângulo escaleno");

            }
            
        }
        else{

            Console.WriteLine("Os valores informados não formam um triângulo, reinicie o programa e tente novamente.");

        }
    }
}