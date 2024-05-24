/*11. A prefeitura de uma cidade fez uma pesquisa entre os seus habitantes, coletando dados sobre o salário e número de filhos. Faça um procedimento que leia esses dados para um número não determinado de pessoas e retorne a média de salário da população, a média do número de filhos, o maior salário e o percentual de pessoas com salário até R$350,00.*/
using System;
class exercicio_011
{
    static void Main()
    {
        float media_salario = 0.0F;
        int media_filhos = 0;
        float maior_salario = 0.0F;
        float percentual = 0.0F;
        
        Pesquisa(out media_salario, out media_filhos, out maior_salario, out percentual);
        
        string media_salario_f = media_salario.ToString("F2");
        string maior_salario_f = maior_salario.ToString("F2");
        string percentual_f = percentual.ToString("F2");
        Console.WriteLine("Media salarial: {0}", media_salario_f);
        Console.WriteLine("Media de filhos: {0}", media_filhos);
        Console.WriteLine("Maior salario: {0}", maior_salario_f);
        Console.WriteLine("Percentual de salario ate R$ 350,00: {0}%\n", percentual_f);
    }

    static void Pesquisa(out float media_salario,out int media_filhos,out float maior_salario,out float percentual)
    {
        int num_filhos = 0;
        float salario = 0.0F;
        int count = 0;
        int count2 = 0;
        media_salario = 0.0F;
        media_filhos = 0;
        maior_salario = 0.0F;

        Console.WriteLine("Preencha os dados ou digite -1 nos dois campos para sair\n");
        
        do
        {
            Console.Write("Informe seu salario: ");
            salario = float.Parse(Console.ReadLine());
            Console.Write("Informe quantos filhos voce tem: ");
            num_filhos = int.Parse(Console.ReadLine());

            if (salario == -1 && num_filhos == -1)
            {
                break;
            }
            
            count2++;
            media_salario += salario;
            media_filhos += num_filhos;

            if (salario > maior_salario)
            {
                maior_salario = salario;
            }
            if (salario > 0 && salario <= 350.0F)
            {
                count++;
            }
        }while(salario != -1 && num_filhos != -1);

        media_salario /= (float)count2;
        media_filhos /= count2;
        percentual = (count*100.0F) / (float)count2;
    }
}

