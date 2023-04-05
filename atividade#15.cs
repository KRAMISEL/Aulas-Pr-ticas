using System;
class program{
    static void Main(){
        Console.Write("Quantos dias o fucionário trabalha por mês? ");
        int dias = int.Parse(Console.ReadLine());
        Console.WriteLine("Esse fucionário ganha por mês: R$" + dias * 200 + ",00");
    }
}