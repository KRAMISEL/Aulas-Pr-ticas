using System;
class program{
    static void Main(){
        Console.Write("Quantos dias o fucionário trabalha por mês? ");
        int dias = int.Parse(Console.ReadLine());
        Console.WriteLine("Esse fucionário ganha {0:c} por mês.",dias * 200);
    }
}