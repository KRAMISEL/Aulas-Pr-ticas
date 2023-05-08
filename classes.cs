using System;
public class Classes{
    public string modificadorDeClasse = "[ModificadorClasse] class NOME_DA_CLASSE{}";
    public string variáveisEPropriedades = "Variáveis / Propriedades\n[especificadorAcesso] tipo NOME_PROPRIEDADE;";
    public string métodos = "Métodos\n[EspecifidadorAcesso] retorno NOME_MÉTODO([argumento1,...]){\nCorpo do método\n}";
}
public class Mostarclasses{
    static void Main(){
        Classes MC = new Classes();
        Classes VP = new Classes();
        Classes MÉ = new Classes();
        Console.WriteLine(MC.modificadorDeClasse);
        Console.WriteLine();
        Console.WriteLine(VP.variáveisEPropriedades);
        Console.WriteLine();
        Console.WriteLine(MÉ.métodos);
        Console.WriteLine();
    }
}