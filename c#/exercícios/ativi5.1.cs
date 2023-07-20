using System;
class Matriz{
    static void Main(){
        int A = 3, B = 3;
        float númMai = -1000000, mai = -1000000, númMen = 1000000, men = 1000000;
        float[,] matriz = new float[A, B];
        Console.WriteLine("Digite números até completar a matriz.");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                matriz[i, ia] = float.Parse(Console.ReadLine());
                if(matriz[i, ia] > númMai && matriz[i, ia] > mai){
                    mai = matriz[i, ia];
                }
                númMai = matriz[i, ia];
                if(matriz[i, ia] < númMen && matriz[i, ia] < men){
                    men = matriz[i, ia];
                }
                númMen = matriz[i, ia];
            }
        }
        Console.WriteLine("O Maior número da matriz é {0}.\nO menor número da matriz é {1}.",mai,men);
    }
}