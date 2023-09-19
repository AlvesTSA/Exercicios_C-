/*12. Desenvolva um gerador de tabuada, capaz de gerar a tabuada de qualquer número inteiro entre 1 a 10. O usuário deve informar de qual numero ele deseja ver a tabuada. A saída deve ser conforme o exemplo abaixo:

Tabuada de 5: 

5 X 1 = 5 

5 X 2 = 10

...

5 X 10 = 50

*/

using System;

class exercicio_012{

    static void Main(){

        int num1 = 0;
        int num2 = 0;
        int produto = 0;
        int i = 0;

        Console.Write("Informe o numero ao qual deseja ver a tabuada: ");
        num1 = int.Parse(Console.ReadLine());

        switch (num1){
            
            case 1:
                
                Console.WriteLine("Tabuada do " + num1 + ":");

                for (i = 0; i < 10; i++){
                    
                    num2++;
                    produto = num1*num2;
                    Console.WriteLine(num1 + " X " + num2 + " = " + produto);
                }
                break;
            
            case 2:
                
                Console.WriteLine("Tabuada do " + num1 + ":");

                for (i = 0; i < 10; i++){
                    
                    num2++;
                    produto = num1*num2;
                    Console.WriteLine(num1 + " X " + num2 + " = " + produto);
                }
                break;
            
            case 3:
                
                Console.WriteLine("Tabuada do " + num1 + ":");

                for (i = 0; i < 10; i++){
                    
                    num2++;
                    produto = num1*num2;
                    Console.WriteLine(num1 + " X " + num2 + " = " + produto);
                }
                break;
            
            case 4:
                
                Console.WriteLine("Tabuada do " + num1 + ":");

                for (i = 0; i < 10; i++){
                    
                    num2++;
                    produto = num1*num2;
                    Console.WriteLine(num1 + " X " + num2 + " = " + produto);
                }
                break;
            
            case 5:
                
                Console.WriteLine("Tabuada do " + num1 + ":");

                for (i = 0; i < 10; i++){
                    
                    num2++;
                    produto = num1*num2;
                    Console.WriteLine(num1 + " X " + num2 + " = " + produto);
                }
                break;

            case 6:
                
                Console.WriteLine("Tabuada do " + num1 + ":");

                for (i = 0; i < 10; i++){
                    
                    num2++;
                    produto = num1*num2;
                    Console.WriteLine(num1 + " X " + num2 + " = " + produto);
                }
                break;
            
            case 7:
                
                Console.WriteLine("Tabuada do " + num1 + ":");

                for (i = 0; i < 10; i++){
                    
                    num2++;
                    produto = num1*num2;
                    Console.WriteLine(num1 + " X " + num2 + " = " + produto);
                }
                break;
            
            case 8:
                
                Console.WriteLine("Tabuada do " + num1 + ":");

                for (i = 0; i < 10; i++){
                    
                    num2++;
                    produto = num1*num2;
                    Console.WriteLine(num1 + " X " + num2 + " = " + produto);
                }
                break;
            
            case 9:
                
                Console.WriteLine("Tabuada do " + num1 + ":");

                for (i = 0; i < 10; i++){
                    
                    num2++;
                    produto = num1*num2;
                    Console.WriteLine(num1 + " X " + num2 + " = " + produto);
                }
                break;
            
            case 10:
                
                Console.WriteLine("Tabuada do " + num1 + ":");

                for (i = 0; i < 10; i++){
                    
                    num2++;
                    produto = num1*num2;
                    Console.WriteLine(num1 + " X " + num2 + " = " + produto);
                }
                break;
        
            default:

                Console.WriteLine("Error: a tabuada deve ser de 1 a 10.");
                break;
        }

    }
}