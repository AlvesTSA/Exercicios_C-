/*22. A ACME Inc., uma empresa de 500 funcionários, está tendo problemas de espaço em disco no seu servidor de arquivos. Para tentar resolver este problema, o Administrador de Rede precisa saber qual o espaço ocupado pelos usuários, e identificar os usuários com maior espaço ocupado. Através de um programa, baixado da Internet, ele conseguiu gerar o seguinte arquivo, chamado "usuarios.txt":

alexandre       456123789
anderson        1245698456
antonio         123456456
carlos          91257581
cesar           987458
rosemary        789456125

Neste arquivo, o nome do usuário possui 15 caracteres. A partir deste arquivo, você deve criar um programa que gere um relatório, chamado "relatório.txt", no seguinte formato:
Relatório de Uso do Espaço em Disco

Nr.	Usuário	    Espaço utilizado	Percentual do uso
    
1	alexandre	434,99 MB	        16,85%
2	anderson	1187,99 MB	        46,02%
3	antonio	    117,73 MB	        4,56%
4	carlos	    87,03 MB	        3,37%
5	cesar	    0,94 MB	            0,04%
6	rosemary	752,88 MB	        29,16%
    
Espaço total ocupado:	2581,57 MB
Espaço médio ocupado:	430,26 MB
  

O arquivo de entrada deve ser lido uma única vez, e os dados armazenados em memória, caso sejam necessários, de forma a agilizar a execução do programa. A conversão da espaço ocupado em disco, de bytes para megabytes deverá ser feita através de uma função separada, que será chamada pelo programa principal. O cálculo do percentual de uso também deverá ser feito através de uma função, que será chamada pelo programa principal.*/

using System;

class exercicio_022{
    
    static void Main(){

        string[] nome = {"Alexandre", "Anderson", "Antonio", "Carlos", "Cesar", "Rosimary"};
        double[] espaco_util = {456123789, 1245698456, 123456456, 91257581, 987458, 789456125};
        double[] percentual = new double[6];
        double media = 0;
        double total = 0;

        for (int i = 0; i < 6; i++){
            
            espaco_util[i] = espaco_util[i] / 1000000;
            total += espaco_util[i];
        }

        media = total / 6;

        for (int i = 0; i < 6; i++){
            
            percentual[i] = (espaco_util[i] * 100) / total;
        }

        Console.WriteLine("Relatorio de Uso do Espaco em Disco\n");
        Console.WriteLine("Nr.	Usuario	    Espaco utilizado	Percentual do uso");

        for (int i = 0; i < 6; i++){
            
            string espaco_utilfor = string.Format("{0:0.00}", espaco_util[i]);
            string percentualfor = string.Format("{0:0.00}", percentual[i]);
            Console.WriteLine((i + 1) + "   " + nome[i] + "    " + espaco_utilfor + " MB" +  "          " + percentualfor + "%");
        }
        string totalfor = string.Format("{0:0.00}", total);
        string mediafor = string.Format("{0:0.00}", media);
        Console.WriteLine("Espaco total ocupado: " + totalfor + " MB");
        Console.WriteLine("Espaco medio ocupado: " + mediafor+ " MB");
    }
}

