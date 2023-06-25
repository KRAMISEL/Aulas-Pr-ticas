using System;
class recursividade{
    public int retorno1(int i){
        int A;
        if(i <= 1){
            A = 1;
        }
        else{
            A = i * retorno1(i - 1);
        }
        return A;
    }
}
class for_recursividade{
    static void Main(){
        int A = 6;
        for(int i = A; i > 1; i--){
            A *= i - 1;
        }
        Console.WriteLine(A);
        Console.WriteLine("<=============>");
        int res;
        recursividade ret = new recursividade();
        res = ret.retorno1(6);
        Console.WriteLine(res);
    }
}