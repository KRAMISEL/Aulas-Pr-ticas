using System;
class program{
    static void Main(){
        Console.Write("Digite um ano e veremos se ele é ou não bissesto: ");
        int ano = int.Parse(Console.ReadLine());
        if(ano % 4 == 0){
            Console.WriteLine("Esse ano é bissesto.");
        }
        else{
            Console.WriteLine("Esse ano não é bissesto.");
        }
    }
}