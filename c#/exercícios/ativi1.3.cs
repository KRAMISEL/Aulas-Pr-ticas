using System;
class programa{
    static void Main(){
        int[] núm = new int[20];
        Console.WriteLine("Por favor, digite 20 números inteiros.");
        for(int i = 0; i < núm.Length; i++){
            núm[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("\n Números Pares:");
        foreach(int i in núm){
            if(i % 2 == 0){
                Console.Write(" {0}",i);
            }
        }
        Console.Write("\n\n Números Ìmpares:");
        foreach(int i in núm){
            if(i % 2 != 0){
                Console.Write(" {0}",i);
            }
        }
        Console.WriteLine();
    }
}