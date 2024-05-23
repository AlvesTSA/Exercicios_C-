/*3. Faça um programa, com uma função que necessite de três argumentos, e que forneça a soma desses três argumentos.*/

class exercicio_003
{
    static void Main(){

        int size = 3;
        float[] num = new float[size];
        
        for (int i = 0; i < size; i++)
        {
            Console.Write("Informe o número " +(i + 1) + ": " );
            num[i] = float.Parse(Console.ReadLine());
        }

        float result = Sum(num[0],num[1],num[2]);
        Console.WriteLine("Soma dos números: "+result);
    }

    static float Sum(float a, float b, float c){

        float resultado = a + b + c;

        return resultado;
    }
}
