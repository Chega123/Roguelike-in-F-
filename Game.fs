module Game

open Player
open Mapa
open Types

open System
open System.Threading.Tasks


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
    let movedPlayer = movePlayer game.jugador
    { game with jugador = movedPlayer }


let rec gameLoop (game: Gamestate) =
    // Renderiza el estado del juego
    Console.Clear()
    drawMap game

    // Captura la entrada del jugador si está disponible
    let input =
        if Console.KeyAvailable then
            Some (Console.ReadKey true)
        else
            None

    // Maneja la entrada del jugador
    let newgame = handlePlayerInput input game

    // Actualiza el estado del juego
    let updatedgtate = updateGameState newgame

    // Espera un breve momento para controlar la velocidad del bucle del juego
    System.Threading.Thread.Sleep(10)
    // Continua el bucle del juego
    gameLoop updatedgtate