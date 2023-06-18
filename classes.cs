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
        Console.WriteLine(MC.modificadorDeClasse + "\n");
        Console.WriteLine(VP.variáveisEPropriedades + "\n");
        Console.WriteLine(MÉ.métodos + "\n");
        /*
        Modificador da Classe: Define a visibilidade da classe.
            public: Pública, sem restrição de visualização.
            abstract: Classe-Base para outras classes, não pode ser instanciados objetos desta classe.
            sealed: Classe não pode ser herdada.
            static: Classe não permite a instanciação de objetos e seus membros devem ser static.

        Especificador de Classe: Onde um membro da classe pode ser acessado.
            public: sem restrição de acesso.
            private: só podem ser acessados pela própria classe.
            protected: Podem ser acessados na própria classe e nas classes derivadas.
            abstract: Os métodos não tem implementação somente os cabeçalhos.
            sealed: O método não pode ser redefinido.
            virtual: O método pode ser redefinido em uma classe derivada.
            static: O Método pode ser chamado sem a instanciação de um objeto.
        */
    }
}