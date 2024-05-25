/*20. Faça um programa que converta da notação de 24 horas para a notação de 12 horas. Por exemplo, o programa deve converter 14:25 em 2:25 P.M. A entrada é dada em dois inteiros. Deve haver pelo menos duas funções: uma para fazer a conversão e uma para a saída. Registre a informação A.M./P.M. como um valor ‘A’ para A.M. e ‘P’ para P.M. Assim, a função para efetuar as conversões terá um parâmetro formal para registrar se é A.M. ou P.M. Inclua um loop que permita que o usuário repita esse cálculo para novos valores de entrada todas as vezes que desejar.*/
using System;

class exercicio_020
{
    static void Main()
    {
        int hora12,min12,hora24,min24 = 0;
        char prefixo,sair;

        do
        {
            Console.WriteLine("Informe a hora no formato (HH MM):\n");
            hora24 = int.Parse(Console.ReadLine());
            min24 = int.Parse(Console.ReadLine());

            ConverterHora(hora24,min24,out hora12,out min12,out prefixo);
            Imprimir(hora12,min12,prefixo);

            Console.Write("\nDeseja inserir mais algum valor, digite S para sim e N para nao:");
            sair = char.Parse(Console.ReadLine());

        } while (sair == 's' || sair == 'S');
    }
    static void ConverterHora(int hora24,int min24,out int hora12,out int min12,out char prefixo){

        min12 = min24;

        if (hora24 == 0)
        {
            hora12 = 12;
            prefixo = 'A';
        }
        else if (hora24 < 12)
        {
            hora12 = hora24;
            prefixo = 'A';
        }
        else if (hora24 == 12)
        {
            hora12 = 12;
            prefixo = 'P';
        }
        else
        {
            hora12 = hora24 - 12;
            prefixo = 'P';
        }  
    }

    static void Imprimir(int hora12, int min12,char prefixo){

        Console.WriteLine("Horario convertido: {0:00}:{1:00} {2}.M",hora12,min12,prefixo);
    }
}
