/*13. Faça um programa que receba a temperatura média de cada mês do ano e armazene-as em uma lista. Após isto, calcule a média anual das temperaturas e mostre todas as temperaturas acima da média anual, e em que mês elas ocorreram (mostrar o mês por extenso: 1 – Janeiro, 2 – Fevereiro, . . . ).*/

using System;

class exercicio_013{
    
    static void Main(){

        float[] temp = new float[12];
        float media = 0;

        for (int i = 0; i < 12; i++){
            
            Console.Write("Informe a temperatura do mes " + (i + 1) + ": ");
            temp[i] = float.Parse(Console.ReadLine());

            media += temp[i];
        }

        media /= 12;

        Console.WriteLine("Temperatura media: " + media);

        for (int i = 0; i < 12; i++){
            
            if (temp[i] > media){
                
                switch (i + 1){
                    
                    case 1:
                        Console.WriteLine("1 Janeiro - temperatura acima da media: " + temp[i]);
                        break;
                    case 2:
                        Console.WriteLine("2 Fevereiro - temperatura acima da media: " + temp[i]);
                        break;
                    case 3:
                        Console.WriteLine("3 Marco - temperatura acima da media: " + temp[i]);
                        break;
                    case 4:
                        Console.WriteLine("4 Abril - temperatura acima da media: " + temp[i]);
                        break;
                    case 5:
                        Console.WriteLine("5 Maio - temperatura acima da media: " + temp[i]);
                        break;
                    case 6:
                        Console.WriteLine("6 Junho - temperatura acima da media: " + temp[i]);
                        break;
                    case 7:
                        Console.WriteLine("7 Julho - temperatura acima da media: " + temp[i]);
                        break;
                    case 8:
                        Console.WriteLine("8 Agosto - temperatura acima da media: " + temp[i]);
                        break;
                    case 9:
                        Console.WriteLine("9 Setembro - temperatura acima da media: " + temp[i]);
                        break;
                    case 10:
                        Console.WriteLine("10 Outubro - temperatura acima da media: " + temp[i]);
                        break;
                    case 11:
                        Console.WriteLine("11 Novembro - temperatura acima da media: " + temp[i]);
                        break;
                    case 12:
                        Console.WriteLine("12 Dezembro - temperatura acima da media: " + temp[i]);
                        break;
                    
                    default:
                        Console.WriteLine("Valor invalido");
                        break;
                }
            }
        } 
    }
}