using System;
class loja{
    static void Main(){
        float[] Produto = new float[50];
        Console.WriteLine("Lojas Quase Dois - Tabela de preços");
        for(int i = 0; i < 50; i++){
            Console.WriteLine("Produto {0}: {1:c}",i + 1,Produto[i] = 1.99f * (i + 1));
        }
    }
}