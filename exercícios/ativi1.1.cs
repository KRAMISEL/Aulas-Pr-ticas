using System;
class programa{
    static void Main(){
        int[] todosOsNúmeros = new int[20];
        int[] númPares = new int[20];
        int[] númÌmpares = new int[20];
        int númParContagem = 0;
        int númÌmparContagem = 0;
        Console.WriteLine("Por favor, digite 20 números inteiros.");
        for(int i = 0; i < todosOsNúmeros.Length; i++){
            todosOsNúmeros[i] = int.Parse(Console.ReadLine());
            if(todosOsNúmeros[i] % 2 == 0){
                númPares[númParContagem] = todosOsNúmeros[i];
                númParContagem++;
            }
            else{
                númÌmpares[númÌmparContagem] = todosOsNúmeros[i];
                númÌmparContagem++;
            }
        }
        Console.WriteLine("\n Números Pares:");
        for(int i = 0; i < númParContagem; i++){
            Console.WriteLine("{0}",númPares[i]);
        }
        Console.WriteLine("=================\n\n Números Ìmpares:");
        for(int i = 0; i < númÌmparContagem; i++){
            Console.WriteLine("{0}",númÌmpares[i]);
        }
        Console.WriteLine("=================");
    }
}