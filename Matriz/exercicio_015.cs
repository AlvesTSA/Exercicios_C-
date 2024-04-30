/*15. Crie uma agenda que armazena, código da pessoa, número do telefone, idade. Sua agenda deve possibilitar:

(1) – inserir um contato
(2) – Remover um contato
(3) – Editar um contato
(4) – buscar um contato pelo Código.*/

using System;

public class exercicio_015{

    static void Main(){

        const int max_pessoas = 100;
        const int n_campo = 3;
        string[,] pessoas = new string[max_pessoas,n_campo];
        int op = 0;
        int op_1 = 0;
        int count_pessoas = 0;
        string codigo = "";
        int fim = 0;

        for (int i = 0; i < max_pessoas; i++)
        {
            for (int j = 0; j < n_campo; j++)
            {
                pessoas[i,j] = "";
            }
        }

        for (int w = 0; w < max_pessoas; w++)
        {
            do
            {
                Console.Write("Escolha uma opcao a seguir.\n\n(1)  inserir um contato\n(2)  Remover um contato\n(3)  Editar umcontato\n(4)  buscar um contato pelo Codigo\n(5)  Mostrar lista\n");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: //(1) – inserir um contato
                        
                        for (int i = 0; i < max_pessoas; i++)
                        {
                            
                            Console.Write("Informe o codigo da pessoa: ");
                            pessoas[i,0] = Console.ReadLine();
                            Console.Write("Informe o numero de telefone da pessoa: ");
                            pessoas[i,1] = Console.ReadLine();
                            Console.Write("Informe q idade da pessoa: ");
                            pessoas[i,2] = Console.ReadLine();
                            Console.Write("Deseja inserir mais uma pessoa ? Digite 0 para 'nao' e 1 para 'sim': ");
                            fim = int.Parse(Console.ReadLine());

                            count_pessoas++;

                            if (fim == 0)
                            {
                                break;
                            }
                        }
                        break;

                    case 2: //(2) – Remover um contato
                        codigo = "";
                        Console.Write("Informe o codigo da pessoa que deseja remover: ");
                        codigo = Console.ReadLine();

                        for (int i = 0; i < max_pessoas; i++)
                        {
                            if (pessoas[i, 0] == codigo)
                            {
                                int posicao_remover = i;

                                for (int j = posicao_remover; j < max_pessoas - 1; j++)
                                {
                                    pessoas[i, 0] = pessoas[i+1, 0];
                                    pessoas[i, 1] = pessoas[i+1, 1];
                                    pessoas[i, 2] = pessoas[i+1, 2]; 
                                }
                                Console.WriteLine("Contato removido com sucesso.");
                                count_pessoas--; // Decrementa o contador de pessoas
                                break; // Sai do loop após remover o contato
                            }
                        }
                        break;

                    case 3: //(3) – Editar um contato
                        codigo = "";
                        Console.Write("Informe o codigo da pessoa que deseja editar: ");
                        codigo = Console.ReadLine();

                        for (int i = 0; i < max_pessoas; i++)
                        {
                            if (pessoas[i, 0] == codigo)
                            {
                                Console.Write("Informe qual campo deseja editar\n\n(1) Codigo\n(2) Telefone\n(3) Idade ");
                                op_1 = int.Parse(Console.ReadLine());

                                switch (op_1)
                                {
                                    case 1:
                                        Console.Write("Informe o novo codigo da pessoa: ");
                                        pessoas[i, 0] = Console.ReadLine();
                                        break;
                                    case 2:
                                        Console.Write("Informe o novo numero de telefone da pessoa: ");
                                        pessoas[i, 1] = Console.ReadLine();
                                        break;
                                    case 3:
                                        Console.Write("Informe a nova idade da pessoa: ");
                                        pessoas[i, 2] = Console.ReadLine();
                                        break;
                                    default:
                                        Console.WriteLine("Valor invalido.");
                                        break;
                                }
                                Console.WriteLine("Contato editado com sucesso.");
                                break; 
                            }
                        }
                        break;

                    case 4: //(4) – buscar um contato pelo Código
                        
                        codigo = "";
                        Console.Write("Informe o codigo da pessoa que deseja buscar: ");
                        codigo = Console.ReadLine();

                        for (int i = 0; i < max_pessoas; i++){
                        
                            if (pessoas[i,0] == codigo)
                            {
                                Console.WriteLine(pessoas[i,0] + "\n" + pessoas[i,1] + "\n" + pessoas[i,2]);
                            }
                        }

                        break;

                    case 5: //(5) – Mostrar lista

                        for (int i = 0; i < count_pessoas; i++){
                        
                            Console.WriteLine("codigo da pessoa: "+pessoas[i,0]);
                            Console.WriteLine("telefone: "+pessoas[i,1]);
                            Console.WriteLine("idade: "+pessoas[i,2]);
                        }
                        break;

                    default:
                        Console.WriteLine("Erro: escolha entre 1 a 4.");
                        break;
                }

            } while (op > 5 || op < 1);

            Console.Write("Deseja realizar mais alguma operacao ? Digite 0 para 'nao' e 1 para 'sim': ");
            fim = int.Parse(Console.ReadLine());

            if (fim == 0){
                
                break;
            }
        }
    }
}