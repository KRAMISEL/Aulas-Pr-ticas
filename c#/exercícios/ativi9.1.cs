using System;
class JogoVelha{
    static void Main(){
        reniciar:
        string[] jogoVelha = new string[9];
        string escolha;
        bool jogador = true;
        bool vitória = false;
        Console.WriteLine("   |   |   ");
        Console.WriteLine("-----------");
        Console.WriteLine("   |   |   ");
        Console.WriteLine("-----------");
        Console.WriteLine("   |   |   ");
        voltar:
        decidido:
        if(jogador == true){
            Console.WriteLine("Vez do Jogador 1");
            Console.WriteLine("Onde deseja colocar o X :");
        }
        else{
            Console.WriteLine("Vez do jogador 2");
            Console.WriteLine("Onde deseja colocar o O :");
        }
        escolha = Console.ReadLine();
        switch(escolha){
            case "A1":
            if(jogoVelha[0] == "X" || jogoVelha[0] == "O"){
                Console.WriteLine("Esse espaço está preenchido.");
                break;
            }
            else if(jogador == true){
                jogoVelha[0] = "X";
            }
            else{
                jogoVelha[0] = "O";
            }
            Console.Clear();
            Console.WriteLine(" " + jogoVelha[0] + " | " + jogoVelha[1] + " | " + jogoVelha[2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[3] + " | " + jogoVelha[4] + " | " + jogoVelha[5]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[6] + " | " + jogoVelha[7] + " | " + jogoVelha[8]);
            jogador = jogador? false : true;
            break;
            case "A2":
            if(jogoVelha[1] == "X" || jogoVelha[1] == "O"){
                Console.WriteLine("Esse espaço está preenchido.");
                break;
            }
            else if(jogador == true){
                jogoVelha[1] = "X";
            }
            else{
                jogoVelha[1] = "O";
            }
            Console.Clear();
            Console.WriteLine(" " + jogoVelha[0] + " | " + jogoVelha[1] + " | " + jogoVelha[2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[3] + " | " + jogoVelha[4] + " | " + jogoVelha[5]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[6] + " | " + jogoVelha[7] + " | " + jogoVelha[8]);
            jogador = jogador? false : true;
            break;
            case "A3":
            if(jogoVelha[2] == "X" || jogoVelha[2] == "O"){
                Console.WriteLine("Esse espaço está preenchido.");
                break;
            }
            else if(jogador == true){
                jogoVelha[2] = "X";
            }
            else{
                jogoVelha[2] = "O";
            }
            Console.Clear();
            Console.WriteLine(" " + jogoVelha[0] + " | " + jogoVelha[1] + " | " + jogoVelha[2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[3] + " | " + jogoVelha[4] + " | " + jogoVelha[5]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[6] + " | " + jogoVelha[7] + " | " + jogoVelha[8]);
            jogador = jogador? false : true;
            break;
            case "B1":
            if(jogoVelha[3] == "X" || jogoVelha[3] == "O"){
                Console.WriteLine("Esse espaço está preenchido.");
                break;
            }
            else if(jogador == true){
                jogoVelha[3] = "X";
            }
            else{
                jogoVelha[3] = "O";
            }
            Console.Clear();
            Console.WriteLine(" " + jogoVelha[0] + " | " + jogoVelha[1] + " | " + jogoVelha[2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[3] + " | " + jogoVelha[4] + " | " + jogoVelha[5]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[6] + " | " + jogoVelha[7] + " | " + jogoVelha[8]);
            jogador = jogador? false : true;
            break;
            case "B2":
            if(jogador == true){
                jogoVelha[4] = "X";
            }
            else{
                jogoVelha[4] = "O";
            }
            Console.Clear();
            Console.WriteLine(" " + jogoVelha[0] + " | " + jogoVelha[1] + " | " + jogoVelha[2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[3] + " | " + jogoVelha[4] + " | " + jogoVelha[5]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[6] + " | " + jogoVelha[7] + " | " + jogoVelha[8]);
            jogador = jogador? false : true;
            break;
            case "B3":
            if(jogoVelha[5] == "X" || jogoVelha[5] == "O"){
                Console.WriteLine("Esse espaço está preenchido.");
                break;
            }
            else if(jogador == true){
                jogoVelha[5] = "X";
            }
            else{
                jogoVelha[5] = "O";
            }
            Console.Clear();
            Console.WriteLine(" " + jogoVelha[0] + " | " + jogoVelha[1] + " | " + jogoVelha[2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[3] + " | " + jogoVelha[4] + " | " + jogoVelha[5]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[6] + " | " + jogoVelha[7] + " | " + jogoVelha[8]);
            jogador = jogador? false : true;
            break;
            case "C1":
            if(jogoVelha[6] == "X" || jogoVelha[6] == "O"){
                Console.WriteLine("Esse espaço está preenchido.");
                break;
            }
            else if(jogador == true){
                jogoVelha[6] = "X";
            }
            else{
                jogoVelha[6] = "O";
            }
            Console.Clear();
            Console.WriteLine(" " + jogoVelha[0] + " | " + jogoVelha[1] + " | " + jogoVelha[2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[3] + " | " + jogoVelha[4] + " | " + jogoVelha[5]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[6] + " | " + jogoVelha[7] + " | " + jogoVelha[8]);
            jogador = jogador? false : true;
            break;
            case "C2":
            if(jogoVelha[7] == "X" || jogoVelha[7] == "O"){
                Console.WriteLine("Esse espaço está preenchido.");
                break;
            }
            else if(jogador == true){
                jogoVelha[7] = "X";
            }
            else{
                jogoVelha[7] = "O";
            }
            Console.Clear();
            Console.WriteLine(" " + jogoVelha[0] + " | " + jogoVelha[1] + " | " + jogoVelha[2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[3] + " | " + jogoVelha[4] + " | " + jogoVelha[5]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[6] + " | " + jogoVelha[7] + " | " + jogoVelha[8]);
            jogador = jogador? false : true;
            break;
            case "C3":
            if(jogoVelha[8] == "X" || jogoVelha[8] == "O"){
                Console.WriteLine("Esse espaço está preenchido.");
                break;
            }
            else if(jogador == true){
                jogoVelha[8] = "X";
            }
            else{
                jogoVelha[8] = "O";
            }
            Console.Clear();
            Console.WriteLine(" " + jogoVelha[0] + " | " + jogoVelha[1] + " | " + jogoVelha[2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[3] + " | " + jogoVelha[4] + " | " + jogoVelha[5]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[6] + " | " + jogoVelha[7] + " | " + jogoVelha[8]);
            jogador = jogador? false : true;
            break;
            default:
            Console.Clear();
            Console.WriteLine("Escolha um dos quadrados para preencher.");
            Console.WriteLine(" " + jogoVelha[0] + " | " + jogoVelha[1] + " | " + jogoVelha[2]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[3] + " | " + jogoVelha[4] + " | " + jogoVelha[5]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + jogoVelha[6] + " | " + jogoVelha[7] + " | " + jogoVelha[8]);
            goto voltar;
        }
        for(int i = 0; i < jogoVelha.Length; i++){
            if(jogoVelha[0] == "X" && jogoVelha[1] == "X" && jogoVelha[2] == "X"){
                Console.WriteLine("Jogador 1 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[3] == "X" && jogoVelha[4] == "X" && jogoVelha[5] == "X"){
                Console.WriteLine("Jogador 1 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[6] == "X" && jogoVelha[7] == "X" && jogoVelha[8] == "X"){
                Console.WriteLine("Jogador 1 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[0] == "X" && jogoVelha[4] == "X" && jogoVelha[8] == "X"){
                Console.WriteLine("Jogador 1 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[2] == "X" && jogoVelha[4] == "X" && jogoVelha[6] == "X"){
                Console.WriteLine("Jogador 1 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[0] == "X" && jogoVelha[3] == "X" && jogoVelha[6] == "X"){
                Console.WriteLine("Jogador 1 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[1] == "X" && jogoVelha[4] == "X" && jogoVelha[7] == "X"){
                Console.WriteLine("Jogador 1 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[2] == "X" && jogoVelha[5] == "X" && jogoVelha[8] == "X"){
                Console.WriteLine("Jogador 1 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[0] == "O" && jogoVelha[1] == "O" && jogoVelha[2] == "O"){
                Console.WriteLine("Jogador 2 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[3] == "O" && jogoVelha[4] == "O" && jogoVelha[5] == "O"){
                Console.WriteLine("Jogador 2 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[6] == "O" && jogoVelha[7] == "O" && jogoVelha[8] == "O"){
                Console.WriteLine("Jogador 2 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[0] == "O" && jogoVelha[4] == "O" && jogoVelha[8] == "O"){
                Console.WriteLine("Jogador 2 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[2] == "O" && jogoVelha[4] == "O" && jogoVelha[6] == "O"){
                Console.WriteLine("Jogador 2 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[0] == "O" && jogoVelha[3] == "O" && jogoVelha[6] == "O"){
                Console.WriteLine("Jogador 2 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[1] == "O" && jogoVelha[4] == "O" && jogoVelha[7] == "O"){
                Console.WriteLine("Jogador 2 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[2] == "O" && jogoVelha[5] == "O" && jogoVelha[8] == "O"){
                Console.WriteLine("Jogador 2 venceu.");
                vitória = true;
                break;
            }
            else if(jogoVelha[i] != "X" && jogoVelha[i] != "O"){
                goto decidido;
            }
        }
        if(vitória == false){
            Console.WriteLine("O jogo terminou em velha.");
        }
        Console.WriteLine("Deseja reniciar a partida?\n[sim/não]");
        escolha = Console.ReadLine();
        if(escolha == "sim"){
            Console.Clear();
            goto reniciar;
        }
    }
}