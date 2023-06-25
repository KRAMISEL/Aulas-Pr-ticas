using System;
class loja{
    static void Main(){
        Console.WriteLine("Lojas Quase Dois - Tabela de preços.\n");
        for(float i = 0; i < 50; i++){
            Console.WriteLine("Produto {0} {1:c}",i + 1,(i + 1) * 1.99f);
        }
    }
}