using System;
class programa{
    static void Main(){
        int[] todosOsNúmeros = new int[20];
        int[] númPares = new int[20];
        int[] númÌmpares = new int[20];
        Console.WriteLine("Por favor, digite 20 números inteiros.");
        for(int i = 0; i < todosOsNúmeros.Length; i++){
            todosOsNúmeros[i] = int.Parse(Console.ReadLine());
            if(todosOsNúmeros[i] % 2 == 0){
                númPares[i] = todosOsNúmeros[i];
            }
            else{
                númÌmpares[i] = todosOsNúmeros[i];
            }
        }
        Console.Write("\n Números Pares:");
        foreach(int i in númPares){
            if(i != 0){
                Console.Write(" {0}",i);
            }
        }
        Console.Write("\n\n Números Ìmpares:");
        foreach(int i in númÌmpares){
            if(i != 0){
                Console.Write(" {0}",i);
            }
        }
        Console.WriteLine();
    }
}