using System;
class loja{
    static void Main(){
        float Produto = 0f;
        Console.WriteLine("Lojas Quase Dois - Tabela de preços.");
        for(int A = 0; A < 50; A++){
            Console.WriteLine("Produto {0} {1:c}",A + 1,Produto += 1.99f);
        }
    }
}