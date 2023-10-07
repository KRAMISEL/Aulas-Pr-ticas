using System;
class JogoVelha{
    static string[] jogoVelha;
    static bool jogador = true;
    static void Main(){
        reniciar:
        jogoVelha = new string[9];
        string escolha = "", decisão = "";
        bool vitória = false;
        Console.WriteLine("   |   |   ");
        Console.WriteLine("-----------");
        Console.WriteLine("   |   |   ");
        Console.WriteLine("-----------");
        Console.WriteLine("   |   |   ");
        decidido:
        if(jogador == true){
            Console.WriteLine("Vez do Jogador X");
            Console.WriteLine("Onde deseja colocar o X :");
        }
        else{
            Console.WriteLine("Vez do jogador O");
            Console.WriteLine("Onde deseja colocar o O :");
        }
        escolha = Console.ReadLine();
        switch(escolha){
            case "A1":
            jogoVelha[0] = implementação(jogoVelha[0]);
            Interface();
            break;
            case "A2":
            jogoVelha[1] = implementação(jogoVelha[1]);
            Interface();
            break;
            case "A3":
            jogoVelha[2] = implementação(jogoVelha[2]);
            Interface();
            break;
            case "B1":
            jogoVelha[3] = implementação(jogoVelha[3]);
            Interface();
            break;
            case "B2":
            jogoVelha[4] = implementação(jogoVelha[4]);
            Interface();
            break;
            case "B3":
            jogoVelha[5] = implementação(jogoVelha[5]);
            Interface();
            break;
            case "C1":
            jogoVelha[6] = implementação(jogoVelha[6]);
            Interface();
            break;
            case "C2":
            jogoVelha[7] = implementação(jogoVelha[7]);
            Interface();
            break;
            case "C3":
            jogoVelha[8] = implementação(jogoVelha[8]);
            Interface();
            break;
            default:
            Interface();
            break;
        }
        for(int i = 0; i < jogoVelha.Length; i++){
            if(i == 0 || i % 2 == 0){
                decisão = "X";
            }
            else{
                decisão = "O";
            }
            if(jogoVelha[0] == decisão && jogoVelha[1] == decisão && jogoVelha[2] == decisão){
                Console.WriteLine("Jogador " + decisão + " venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[3] == decisão && jogoVelha[4] == decisão && jogoVelha[5] == decisão){
                Console.WriteLine("Jogador " + decisão + " venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[6] == decisão && jogoVelha[7] == decisão && jogoVelha[8] == decisão){
                Console.WriteLine("Jogador " + decisão + " venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[0] == decisão && jogoVelha[4] == decisão && jogoVelha[8] == decisão){
                Console.WriteLine("Jogador " + decisão + " venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[2] == decisão && jogoVelha[4] == decisão && jogoVelha[6] == decisão){
                Console.WriteLine("Jogador " + decisão + " venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[0] == decisão && jogoVelha[3] == decisão && jogoVelha[6] == decisão){
                Console.WriteLine("Jogador " + decisão + " venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[1] == decisão && jogoVelha[4] == decisão && jogoVelha[7] == decisão){
                Console.WriteLine("Jogador " + decisão + " venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[2] == decisão && jogoVelha[5] == decisão && jogoVelha[8] == decisão){
                Console.WriteLine("Jogador " + decisão + " venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[i] != "X" && jogoVelha[i] != "O"){
                goto decidido;
            }
        }
        if(!vitória){
            Console.WriteLine("O jogo terminou em velha.");
        }
        Console.WriteLine("Deseja reniciar a partida?\n[s/n]");
        escolha = Console.ReadLine();
        if(escolha == "s" || escolha == "S"){
            Console.Clear();
            goto reniciar;
        }
    }
    static string implementação(string valor){
        if(valor == "X" || valor == "O"){
            Console.WriteLine("Esse espaço está preenchido.");
            return null;
        }
        else if(jogador == true){
            valor = "X";
        }
        else{
            valor = "O";
        }
        jogador = jogador? false : true;
        return valor;
    }
    static void Interface(){
        Console.Clear();
        Console.WriteLine("Escolha um dos quadrados para preencher.");
        Console.WriteLine(" " + jogoVelha[0] + " | " + jogoVelha[1] + " | " + jogoVelha[2]);
        Console.WriteLine("-----------");
        Console.WriteLine(" " + jogoVelha[3] + " | " + jogoVelha[4] + " | " + jogoVelha[5]);
        Console.WriteLine("-----------");
        Console.WriteLine(" " + jogoVelha[6] + " | " + jogoVelha[7] + " | " + jogoVelha[8]);
    }
}