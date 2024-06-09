// Player.fs
module Player
open Types
open System
let movePlayer (player: Player) (game:Gamestate) =
    let actualroom=game.Habitaciones.[game.jugador.Habitacion_Actual-1]
    let newPos =
        match player.Direccion with
        | UP -> (fst player.Posicion - 1, snd player.Posicion)
        | DOWN -> (fst player.Posicion + 1, snd player.Posicion)
        | LEFT -> (fst player.Posicion, snd player.Posicion - 1)
        | RIGHT -> (fst player.Posicion, snd player.Posicion + 1)
        | _ -> player.Posicion

    let (x, y) = newPos
    match actualroom.Mapa.[x, y] with
    | 'w' -> player  // Pared, no se mueve
    | 's' -> { player with Vida = player.Vida - 20 }// Espina, pierde vida pero no se mueve
    | 'a' -> { player with Vida = player.Vida - 100 }//Abismo
    | _ -> { player with Posicion = newPos }  // Movimiento válido


let isAdjacent (pos1: int * int) (pos2: int * int) =
    let (x1, y1) = pos1
    let (x2, y2) = pos2
    (abs (x1 - x2) = 1 && y1 = y2) || (abs (y1 - y2) = 1 && x1 = x2)

let ChangeRoom (player: Player) (game: Gamestate) =
    let actualroom = game.Habitaciones.[game.jugador.Habitacion_Actual - 1]
    printf "%A" game.jugador.Habitacion_Actual
    if actualroom.Enemigos.IsEmpty then
        actualroom.Puertas
        |> List.tryFind (fun door -> isAdjacent player.Posicion door.Posicion)
        |> function
            | Some door -> 
                { player with Posicion = (7, 2); Habitacion_Actual = door.Sala_destino }
            | None -> player
    else
        player



let attackEnemies (player: Player) (enemies: Enemy list) =
    let inRange (enemy: Enemy) =
        let dx = abs (fst player.Posicion - fst enemy.Posicion)
        let dy = abs (snd player.Posicion - snd enemy.Posicion)
        dx <= player.Arma.Rango && dy <= player.Arma.Rango

    enemies
    |> List.map (fun enemy ->
        if inRange enemy then
            { enemy with Vida = enemy.Vida - player.Arma.Daño }
        else
            enemy)
    |> List.filter (fun enemy -> enemy.Vida > 0)