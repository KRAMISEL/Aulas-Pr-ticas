using System;
class Programa{
    static void Main(){
        int[] núm = new int[3];
        voltar:
        Console.WriteLine("Por favor, digite três medidas em centímetros, de 10 a 100, para formar um triangulo:");
        for(int i = 0; i < núm.Length; i++){
        núm[i] = int.Parse(Console.ReadLine());
        if(núm[i] > 100 || núm[i] < 10){
            Console.WriteLine("\nMedidas erradas, só são validas medidas de 10 a 100 centímetros.\n");
            Console.ReadLine();
            goto voltar;
        }
        }
        if(núm[0] == núm[1] && núm[1] == núm[2]){
            Console.WriteLine("Esse é um triangulo EQUILÁTERO.");
        }
        else if(núm[0]== núm[1] || núm[1] == núm[2] || núm[2] == núm[0]){
            Console.WriteLine("Esse é um triangulo ISÓCELES.");
        }
        else if(núm[0] != núm[1] && núm[1] != núm[2]){
            Console.WriteLine("Esse é um triangulo ESCALENO.");
        }
    }
}