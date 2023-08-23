using System;
using System.Collections.Generic;
class Notas{
    static List<float> notas = new List<float>();
    static int ia = 1;
    static float notasBanco = 0;
    static void Main(){
        Console.WriteLine("Digite a quantidade de números que desejar:\n(caso queira parar digite -1)");
        for(int i = 0; i < ia; i++){
            notas.Add(float.Parse(Console.ReadLine()));
            notasBanco += notas[i];
            if(notas[notas.Count - 1] == (-1)){
                notas.Remove(notas[notas.Count - 1]);
                ia--;
            }
            else{
                ia++;
            }
        }
        Console.WriteLine("Notas Armazenadas {0}.",notas.Count);
        Console.WriteLine("A soma de todas as notas é {0}.",notasBanco);
        Console.WriteLine("A média das notas é {0}.",notasBanco / notas.Count);
        foreach(float i in notas){
            Console.Write(i + " ");
        }
        for(int i = 0; i < notas.Count; i++){
            Console.Write("\n" + notas[(ia - 1) - i]);
        }
        Console.WriteLine("\nTodos as notas acima da média:");
        for(int i = 0; i < notas.Count; i++){
            if(notas[i] > notasBanco / notas.Count){
                Console.WriteLine(notas[i]);
            }
        }
        Console.WriteLine("Todos as notas acima de 7:");
        for(int i = 0; i < notas.Count; i++){
            if(notas[i] > 7){
                Console.WriteLine(notas[i]);
            }
        }
        Console.WriteLine("Todas as tarefas foram realizadas.");
    }
}