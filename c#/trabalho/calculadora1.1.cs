using System;
using System.Collections.Generic;
class Calculadora{
    static List<float> númerosArmazen = new List<float>();
    static string texto;
    static void Main(){
        voltar1:
        voltar2:
        voltar3:
        if(númerosArmazen.Count == 0){
            Console.WriteLine("\n");
        }
        else if(texto != ""){
            Console.WriteLine(númerosArmazen[0] + texto + "\n");
        }
        else if(númerosArmazen.Count > 0){
            Console.WriteLine(númerosArmazen[0] + texto + "\n");
        }
        else{
            Console.WriteLine(númerosArmazen[0] + texto + númerosArmazen[1] + "\n");
        }
        Console.WriteLine("Calculadora");
        Console.WriteLine("| 7 | 8 | 9 | / |\n| 4 | 5 | 6 | * |\n| 1 | 2 | 3 | - |\n| <x | 0 | = | + |");
        if(númerosArmazen.Count == 0){
            númerosArmazen.Add(float.Parse(Console.ReadLine()));
            Console.Clear();
            goto voltar1;
        }
        else if(texto != ""){
            texto = Console.ReadLine();
            Console.Clear();
            goto voltar2;
        }
        else(númerosArmazen.Count > 0){
            númerosArmazen.Add(float.Parse(Console.ReadLine()));
            Console.Clear();
            goto voltar3;
        }
        else{
            string continuar;
            Console.WriteLine("Deseja continuar na calculadora.\n[s/n]");
            Console.ReadLine();
            if(continuar == "s"){
                Cosnole.Clear();
                númerosArmazen.Clear();
            }
        }
    }
}