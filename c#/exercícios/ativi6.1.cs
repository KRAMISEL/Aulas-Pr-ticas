using System;
class ordem_crescente{
    static void Main(){
        int[] vet = new int[10];
        int A = vet.Length - 1;
        Console.WriteLine("Digite de 1 a {0} em ordem aleatória.", vet.Length);
        for(int i = 0; i < vet.Length; i++){
            vet[i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < vet.Length * vet.Length; i++){
            for(int ia = 0; ia < vet.Length; ia++){
                if(vet[ia] == vet.Length - A){
                    Console.Write("\nNúmero: {0}", vet[ia]);
                    --A;
                }
            }
        }
    }
}