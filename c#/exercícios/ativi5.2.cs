using System;
class Matriz{
    static void Main(){
        int A = 3, B = 3;
        float núm = 0, númG = 0, númP = 0;
        float[,] matriz = new float[A, B];
        Console.WriteLine("Digite números até completar a matriz.");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                matriz[i, ia] = float.Parse(Console.ReadLine());
            }
        }
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                if(matriz[i, ia] > núm){
                    númG = matriz[i, ia];
                }
                núm = matriz[i, ia];
            }
        }
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                if(matriz[i, ia] < núm){
                    númP = matriz[i, ia];
                }
                núm = matriz[i, ia];
            }
        }
        Console.WriteLine("O Maior número da matriz é {0}.\nO menor número da matriz é {1}.",númG,númP);
    }
}