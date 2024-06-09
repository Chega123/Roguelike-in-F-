module Game

open Player
open Mapa
open Types

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




let updateGameState (game: Gamestate) =
    let movedPlayer = movePlayer game.jugador game
    let ChangeRo= ChangeRoom movedPlayer game
    printf "Vida: %A" game.jugador.Vida
    printf "Arma: %A"game.jugador.Arma.Nombre
    { game with jugador = ChangeRo }




let rec gameLoop (game: Gamestate) =
    // Renderiza el estado del juego
    Console.Clear()
    
    let newmapa=drawMap game
    let actualroom=newmapa.Habitaciones.[newmapa.jugador.Habitacion_Actual-1]

    FileUtils.saveMatrixToFile actualroom.Mapa "map.txt"

    // Captura la entrada del jugador si está disponible
    let input =
        if Console.KeyAvailable then
            Some (Console.ReadKey true)
        else
            None

    // Maneja la entrada del jugador
    let newgame = handlePlayerInput input game

    // Actualiza el estado del juego
    let updatedstate = updateGameState newgame

    // Espera un breve momento para controlar la velocidad del bucle del juego
    System.Threading.Thread.Sleep(10)
    // Continua el bucle del juego
    gameLoop updatedstate

