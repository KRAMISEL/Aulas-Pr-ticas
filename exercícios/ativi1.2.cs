using System;
class programa{
    static void Main(){
        int[] todosOsNúmeros = new int[20];
        int[] númerosPares = new int[20];
        int[] númerosÌmpares = new int[20];
        Console.WriteLine("Por favor, digite 20 números inteiros.");
        for(int i = 0; i < todosOsNúmeros.Length; i++){
            todosOsNúmeros[i] = int.Parse(Console.ReadLine());
            if(todosOsNúmeros[i] % 2 == 0){
                númerosPares[i] = todosOsNúmeros[i];
            }
            else{
                númerosÌmpares[i] = todosOsNúmeros[i];
            }
        }
        Console.WriteLine("\n Números Pares:");
        for(int i = 0; i < númerosPares.Length; i++){
            if(númerosPares[i] != 0){
                Console.WriteLine("{0}",númerosPares[i]);
            }
        }
        Console.WriteLine("=================");
        Console.WriteLine("\n Números Ìmpares:");
        for(int i = 0; i < númerosÌmpares.Length; i++){
            if(númerosÌmpares[i] != 0){
                Console.WriteLine("{0}",númerosÌmpares[i]);
            }
        }
        Console.WriteLine("=================");
    }
}