using System;
class Programa{
    static void Main(){
        int núm1,núm2,núm3;
        voltar:
        Console.WriteLine("Por favor, digite três medidas em centímetros, de 10 a 100, para formar um triangulo:");
        núm1 = int.Parse(Console.ReadLine());
        núm2 = int.Parse(Console.ReadLine());
        núm3 = int.Parse(Console.ReadLine());
        if(núm1 > 100 || núm1 < 10 || núm2 > 100 || núm2 < 10 || núm3 > 100 || núm3 < 10){
            Console.WriteLine("\nMedidas erradas, só são validas medidas de 10 a 100 centímetros.\n");
            Console.ReadLine();
            goto voltar;
        }
        else if(núm1 == núm2 && núm2 == núm3){
            Console.WriteLine("Esse é um triangulo EQUILÁTERO.");
        }
        else if(núm1 == núm2 || núm2 == núm3 || núm3 == núm1){
            Console.WriteLine("Esse é um triangulo ISÓCELES.");
        }
        else if(núm1 != núm2 && núm2 != núm3){
            Console.WriteLine("Esse é um triangulo ESCALENO.");
        }
    }
}