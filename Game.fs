module Game

open Player
open Mapa
open Types
open Enemy
open Items
open System
open System.Threading.Tasks
open FileUtils
open System.IO

let handlePlayerInput (input: ConsoleKeyInfo option) (state: Gamestate) =
    match input with
    | Some input ->
        match input.Key with
        | ConsoleKey.UpArrow -> { state with jugador = { state.jugador with Direccion = UP } } 
        | ConsoleKey.DownArrow -> { state with jugador = { state.jugador with Direccion = DOWN } }
        | ConsoleKey.LeftArrow -> { state with jugador = { state.jugador with Direccion = LEFT } }
        | ConsoleKey.RightArrow -> { state with jugador = { state.jugador with Direccion = RIGHT } }
        | ConsoleKey.Spacebar -> { state with jugador = { state.jugador with Direccion = ATTACK } }
        | _ -> { state with jugador = { state.jugador with Direccion = NADA } }
    | None -> { state with jugador = { state.jugador with Direccion = NADA } }



let updateGameState (game: Gamestate) (contador:int) =
    let movedPlayer = movePlayer game.jugador game
    
    match movedPlayer.Direccion with
    | ATTACK -> //cuando atacas no hace la comprobacion de si estas cambiando de habitacion ni el movimiento de los enemigos
        let updatedEnemies = attackEnemies movedPlayer game.Habitaciones.[game.jugador.Habitacion_Actual - 1].Enemigos
        let updatedRoom = { game.Habitaciones.[game.jugador.Habitacion_Actual - 1] with Enemigos = updatedEnemies } //actualiza los enemigos de la habitacion
        let updatedRooms =
            game.Habitaciones
            |> List.mapi (fun i room -> if i = game.jugador.Habitacion_Actual - 1 then updatedRoom else room)
        { game with jugador = movedPlayer; Habitaciones = updatedRooms } // busca y actualiza la habitacion en la que esta el jugador y retorna ese game
    | _ ->
        

        let updatedPlayer =
            if contador % 5 = 0 then // Limitar los ataques de los enemigos
                game.Habitaciones.[game.jugador.Habitacion_Actual - 1].Enemigos
                |> List.fold (fun player enemy ->
                    if enemy.Posicion = game.jugador.Posicion then 
                        attackPlayer player enemy 
                    else
                        player 
                ) movedPlayer // esto es otro parametro del list fold, es el que pasara en lo de player de la fun
            else
                movedPlayer

        let ChangeRo = ChangeRoom updatedPlayer game 
        let changeArma= changeWeapon ChangeRo game 
        
        printf "Vida: %A" changeArma.jugador.Vida 
        printf "Arma: %A" changeArma.jugador.Arma.Nombre
        if contador % 35 = 0 then 
            let game_enemies = updateGameStateWithEnemies changeArma 
            { game_enemies with jugador =changeArma.jugador }
        else 
            { game with jugador = changeArma.jugador }


let rec gameLoop (game: Gamestate) (contador:int) =
    // Renderiza el estado del juego
    Console.Clear()
    
    let newmapa=drawMap game
    let actualroom=newmapa.Habitaciones.[newmapa.jugador.Habitacion_Actual-1]

    FileUtils.saveRoomStateToFile "map.txt" game.jugador.Vida game.jugador.Arma.Nombre game.jugador.Habitacion_Actual actualroom.Mapa

    // Captura la entrada del jugador si está disponible
    let input =
        if Console.KeyAvailable then
            Some (Console.ReadKey true)
        else
            None

    // Maneja la entrada del jugador
    let newgame = handlePlayerInput input game

    // Actualiza el estado del juego
    let updatedstate = updateGameState newgame contador
    let newcontador=contador+1
    // Espera un breve momento para controlar la velocidad del bucle del juego
    System.Threading.Thread.Sleep(10)
    // Continua el bucle del juego
    gameLoop updatedstate newcontador

