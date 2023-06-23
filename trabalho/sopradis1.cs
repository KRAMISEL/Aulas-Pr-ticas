using System;
class Números{
    static void Main(){
        int[] números = new int[1];
        float[] coleção;
        int A = 0,B = 0,C = 0;
        Random random = new Random();
        foreach(int i in números){
        números[i] = random.Next(22);
        }
        if(números[0] < 3){
            números[0] = 3;
        }
        coleção = new float[números[0]];
        Console.WriteLine("Digite números aleatórios para completar a coleção:");
        for(int i = 0; i < coleção.Length; i++){
            coleção[i] = float.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nO primeiro número da coleção é {0}.\nO ultimo número da coleção é {1}.",coleção[0],coleção[0 + coleção.Length - 1]);
        for(int i = 0; i < coleção.Length - 1; i++){
            A = i;
        }
        Console.WriteLine("\nEntre esses dois números existem {0} números.\nQue são:",A);
        for(int i = 0; i < coleção.Length - 2; i++){
            Console.WriteLine("{0}",coleção[i + 1]);
        }
        for(int i = 0; i < coleção.Length; i++){
            if(coleção[i] % 2 == 0){
                B++;
            }
            else{
                C++;
            }
        }
        Console.WriteLine("\nSendo que a coleção possui {0} números pares e {1} números ímpares.",B,C);
        Array.Sort(coleção);
        Console.WriteLine("\nO menor número sendo {0}.\nO maior número sendo {1}.\n",coleção[0],coleção[0 + coleção.Length - 1]);
        Console.WriteLine("A coleção ordenada do menor para o maior:");
        foreach(int i in coleção){
            Console.WriteLine(i);
        }
        Console.WriteLine("\nA coleção ordenada do maior para o menor:");
        Array.Reverse(coleção);
        foreach(int i in coleção){
            Console.WriteLine(i);
        }
    }
}