/* Faça um programa que calcule as raízes de uma equação do segundo grau, na forma ax^2 + bx + c. O programa deverá pedir os valores de a, b e c e fazer as consistências, informando ao usuário nas seguintes situações:
  
Se o usuário informar o valor de A igual a zero. a equação não e do segundo grau e o programa não deve fazer pedir os demais valores, sendo encerrado;
  
Se o delta calculado for negativo, a equação não possui raízes reais. Informe ao usuário e encerre o programa;

Se o delta calculado for igual a zero a equação possui apenas uma raiz real, informe ao usuário;

Se o delta for positivo, a equação possui duas raízes reais, informe-as ao usuário; */

using System;

class exercicio_015{

    static void Main(){

        double a = 0;
        double b = 0;
        double c = 0;
        double delta = 0;
        double x1 = 0;
        double x2 = 0;

        Console.WriteLine("Informe o valor de a: ");
        a = double.Parse(Console.ReadLine());

        if (a != 0){
            
            Console.WriteLine("Informe o valor de b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de c: ");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b,2) - 4*a*c;

            if (delta > 0){
                
                x1 = (- b + Math.Sqrt(delta))/2*a;
                x2 = (- b - Math.Sqrt(delta))/2*a;

                Console.WriteLine("Valor de x': " + x1);
                Console.WriteLine("Valor de x'': " + x2);
                
            }
            else if (delta == 0){
                
                x1 = (- b)/2*a;
                x2 = (- b)/2*a;

                Console.WriteLine("Valor de x': " + x1);
                Console.WriteLine("Valor de x'': " + x2);

            }
            
            else{

                Console.WriteLine("Os valores de x não são reais.");

            }
            
        }
        else{

            Console.WriteLine("A equação não é do segundo grau, informe um valor de 'a' diferente de zero");

        }

    }
}