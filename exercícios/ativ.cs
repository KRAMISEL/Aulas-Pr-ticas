using System;
class programa{
    static void Main(){
        int[] todosOsNúmeros = new int[20];
        int[] númerosPares = new int[20];
        int[] númerosÌmpares = new int[20];
        int númerosParesContagem = 0;
        int númerosÌmparesContagem = 0;
        Console.WriteLine("Por favor, digite 20 números inteiros.");
        for(int A = 0; A < 20; A++){
            todosOsNúmeros[A] = int.Parse(Console.ReadLine());
            if(todosOsNúmeros[A] % 2 == 0){
                númerosPares[A] = todosOsNúmeros[A];
                númerosParesContagem++;
            }
            else if(todosOsNúmeros[A] % 1 == 0 || todosOsNúmeros[A] % 3 == 0 || todosOsNúmeros[A] % 5 == 0 || todosOsNúmeros[A] % 7 == 0 || todosOsNúmeros[A] % 11 == 0 || todosOsNúmeros[A] % 13 == 0){
                númerosÌmpares[A] = todosOsNúmeros[A];
                númerosÌmparesContagem++;
            }
        }
        Console.WriteLine("\nNúmeros Pares:");
        for(int A = 0; A < 20; A++){
            if(númerosPares[A] == 0){
            }
            Console.WriteLine("\n{0}",númerosPares[A] + "\n===============");
        }
        Console.WriteLine("\nNúmeros Ìmpares:");
        for(int A = 0; A < 20; A++){
            Console.WriteLine("\n{0}",númerosÌmpares[A] + "\n===============");
        }
    }
}