// Player.fs
module Player
open Types
open System
let movePlayer (player: Player) =
    match player.Direccion with
    | UP -> { player with Posicion = (fst player.Posicion- 1, snd player.Posicion ) }
    | DOWN -> { player with Posicion = (fst player.Posicion+ 1, snd player.Posicion ) }
    | LEFT -> { player with Posicion = (fst player.Posicion , snd player.Posicion- 1) }
    | RIGHT -> { player with Posicion = (fst player.Posicion , snd player.Posicion+ 1) }
    | _ -> player



