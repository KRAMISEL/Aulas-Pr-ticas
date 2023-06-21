using System;
class programa{
    static void Main(){
        int[] todosOsNúmeros = new int[20];
        int[] númerosPares = new int[20];
        int[] númerosÌmpares = new int[20];
        Console.WriteLine("Por favor, digite 20 números inteiros.");
        for(int A = 0; A < todosOsNúmeros.Length; A++){
            todosOsNúmeros[A] = int.Parse(Console.ReadLine());
            if(todosOsNúmeros[A] % 2 == 0){
                númerosPares[A] = todosOsNúmeros[A];
            }
            else{
                númerosÌmpares[A] = todosOsNúmeros[A];
            }
        }
        Console.WriteLine("\n Números Pares:");
        for(int A = 0; A < númerosPares.Length; A++){
            if(númerosPares[A] != 0){
                Console.WriteLine("{0}",númerosPares[A]);
            }
        }
        Console.WriteLine("=================");
        Console.WriteLine("\n Números Ìmpares:");
        for(int A = 0; A < númerosÌmpares.Length; A++){
            if(númerosÌmpares[A] != 0){
                Console.WriteLine("{0}",númerosÌmpares[A]);
            }
        }
        Console.WriteLine("=================");
    }
}