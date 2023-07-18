using System;
class Matriz{
    static void Main(){
        int A = 3, B = 3, C = 0, D = 0;
        float[,] matriz = new float[A, B];
        float núm = 0, núm1 = 0;
        Console.WriteLine("Digite números na matriz.");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                matriz[i,ia] = float.Parse(Console.ReadLine());
                if(matriz[i, ia] > matriz[i - C, ia - D]){
                    núm = matriz[i, ia];
                }
                if(D == 0){
                    D += 1;
                }
                if(C == 1){
                    C -= 1;
                }
            }
            D -= 1;
            if(C == 0){
                C += 1;
            }
        }
        C -= 1;
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                if(matriz[i, ia] < matriz[i - C, ia - D]){
                    núm1 = matriz[i, ia];
                }
                if(D == 0){
                    D += 1;
                }
                if(C == 1){
                    C -= 1;
                }
            }
            D -= 1;
            if(C == 0){
                C += 1;
            }
        }
        Console.WriteLine("Maior número da matriz: {0}.\nMenor número da matriz: {1}.",núm,núm1);
    }
}