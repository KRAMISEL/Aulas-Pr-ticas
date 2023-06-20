using System;
class recursividade{
    public int retorno1(int A){
        int B;
        if(A <= 1){
            B = 1;
        }
        else{
            B = A * retorno1(A - 1);
        }
        return B;
    }
}
class for_recursividade{
    static void Main(){
        int B = 6;
        for(int A = B; A > 1; A--){
            B *= A - 1;
        }
        Console.WriteLine(B);
        Console.WriteLine("<=============>");
        int res;
        recursividade ret = new recursividade();
        res = ret.retorno1(6);
        Console.WriteLine(res);
    }
}