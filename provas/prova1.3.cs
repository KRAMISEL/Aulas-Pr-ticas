using System;
class loja{
    static void Main(){
        Console.WriteLine("Lojas Quase Dois - Tabela de preços.\n");
        for(float A = 0; A < 50; A++){
            Console.WriteLine("Produto {0} {1:c}",A + 1,(A + 1) * 1.99f);
        }
    }
}