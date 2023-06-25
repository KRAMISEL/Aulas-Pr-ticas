using System;
class loja{
    static void Main(){
        float Produto = 0f;
        Console.WriteLine("Lojas Quase Dois - Tabela de preços.");
        for(int i = 0; i < 50; i++){
            Console.WriteLine("Produto {0} {1:c}",i + 1,Produto += 1.99f);
        }
    }
}