using System;
class loja{
    static void Main(){
        float[] Produto = new float[50];
        Console.WriteLine("Lojas Quase Dois - Tabela de preços");
        for(int A = 0; A < 50; A++){
            Console.WriteLine("Produto {0}: {1:c}",A + 1,Produto[A] = 1.99f * (A + 1));
        }
    }
}