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
        Console.WriteLine("\n Números Pares:");
        for(int i = 0; i < númPares.Length; i++){
            if(númPares[i] != 0){
                Console.WriteLine("{0}",númPares[i]);
            }
        }
        Console.WriteLine("=================\n\n Números Ìmpares:");
        for(int i = 0; i < númÌmpares.Length; i++){
            if(númÌmpares[i] != 0){
                Console.WriteLine("{0}",númÌmpares[i]);
            }
        }
        Console.WriteLine("=================");
    }
}