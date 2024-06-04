// Mapa.fs
module Mapa
open Player

type Casilla =

    | Wall
    | Floor
    | Door
    | Spikes

type Map = Casilla list list

let map1 =
    [
        [Wall; Wall; Wall; Wall; Wall]
        [Wall; Door; Floor; Door; Wall]
        [Wall; Floor; Floor; Floor; Wall]
        [Wall; Floor; Floor; Floor; Wall]
        [Wall; Wall; Wall; Wall; Wall]
    ]

let imprimirMapa (mapa: Map) (jugador: Player.Player) =
    for posy, fila in List.indexed mapa do
        for posx, espacio in List.indexed fila do
            match espacio with
            | Wall -> printf "█"
            | Door -> printf "░"
            | Floor when posx = jugador.pos.X && posy = jugador.pos.Y -> printf "☺"
            | Floor -> printf " "
            | Spikes -> printf "x"
        printfn ""