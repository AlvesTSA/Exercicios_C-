/*20. Faça um programa que carregue uma lista com os modelos de cinco carros (exemplo de modelos: FUSCA, GOL, VECTRA etc). Carregue uma outra lista com o consumo desses carros, isto é, quantos quilômetros cada um desses carros faz com um litro de combustível. Calcule e mostre:
  
 a. O modelo do carro mais econômico; 

 b. Quantos litros de combustível cada um dos carros cadastrados consome para percorrer uma distância de 1000 quilômetros e quanto isto custará, considerando um que a gasolina custe R$ 2,25 o litro. Abaixo segue uma tela de exemplo. O disposição das informações deve ser o mais próxima possível ao exemplo. Os dados são fictícios e podem mudar a cada execução do programa.

Comparativo de Consumo de Combustível
Veículo 1
Nome: fusca
Km por litro: 7
Veículo 2
Nome: gol
Km por litro: 10
Veículo 3
Nome: uno
Km por litro: 12.5
Veículo 4
Nome: Vectra
Km por litro: 9
Veículo 5
Nome: Peugeout
Km por litro: 14.5

Relatório Final
1 - fusca           -    7.0 -  142.9 litros - R$ 321.43
2 - gol             -   10.0 -  100.0 litros - R$ 225.00
3 - uno             -   12.5 -   80.0 litros - R$ 180.00
4 - vectra          -    9.0 -  111.1 litros - R$ 250.00
5 - peugeout        -   14.5 -   69.0 litros - R$ 155.17
O menor consumo é do peugeout.*/

using System;

class exercicio_020{
    
    static void Main(){

        string[] nome = new string[5];
        float[] consumo = new float[5];
        float litros = 0;
        float valor = 0;
        float preco = 2.25F;
        float menor_consumo = 0;

        Console.WriteLine("Comparativo de Consumo de Combustível\n");

        for (int i = 0; i < 5; i++){
            
            Console.WriteLine("Veiculo " + (i + 1));
            Console.Write("Nome: ");
            nome[i] = Console.ReadLine();
            Console.Write("Consumo: ");
            consumo[i] = float.Parse(Console.ReadLine());
        }

        menor_consumo = consumo[0];
        int y = 0;

        for (int i = 0; i < 5; i++){
            
            if (consumo[i]  menor_consumo){
                
                y = i;
            }
        }

        Console.WriteLine("Relatorio final\n");

        for (int i = 0; i < 5; i++){

            litros = (1000 / consumo[i]);
            valor = preco * litros;
            Console.WriteLine((i + 1) + "  -  " + nome[i] + "  - " + consumo[i] + " -  " + litros + " litros - R$ " + valor);
        }

        Console.WriteLine("O menor consumo e do " + nome[y]);
    }
}