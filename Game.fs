module Game

open Player
open Mapa
open Types

let printRoomDetails (room: Room) =
    printfn "Room ID: %d" room.Id
    printfn "Enemies in room:"
    room.Enemigos |> List.iter (fun enemy -> 
        printfn "Nombre: %s, Posicion: %A, Vida: %d, Daño: %d, Rango: %d" 
            enemy.Nombre enemy.Posicion enemy.Vida enemy.Daño enemy.Rango)


let drawMap (game: Gamestate) =
    let actual_room = game.Habitacion.[game.jugador.Habitacion_Actual - 1]
    let height = Array2D.length1 actual_room.Mapa
    let width = Array2D.length2 actual_room.Mapa
    let mapCopy = Array2D.copy actual_room.Mapa

    //jugador
    let px,py=game.jugador.Posicion
    mapCopy.[px,py]<-'2'

    //puertas
    actual_room.Puertas|> List.iter(fun puerta ->
        let dx, dy = puerta.Posicion
        mapCopy.[dx,dy]<-'3')

    //enemigos
    actual_room.Enemigos |> List.iter (fun enemy ->
        let ex, ey = enemy.Posicion
        match enemy.Nombre with
        | "Rata Escurridiza" -> mapCopy.[ex, ey] <- 'R'
        | "Goblin Sigiloso" -> mapCopy.[ex, ey] <- 'G'
        | "Lobo Salvaje" -> mapCopy.[ex, ey] <- 'L'
        | "Orco Enfurecido" -> mapCopy.[ex, ey] <- 'O'
        | "Troll Pesado" -> mapCopy.[ex, ey] <- 'T'
        | "Esqueleto Débil" -> mapCopy.[ex, ey] <- 'E'
        | "Zombi Lento" -> mapCopy.[ex, ey] <- 'Z'
        | "Brujo Oscuro" -> mapCopy.[ex, ey] <- 'B'
        | "Espectro Sombrío" -> mapCopy.[ex, ey] <- '♫'
        | _ -> ()

    )

    for y in 0 .. height - 1 do
        for x in 0 .. width - 1 do
            match mapCopy.[y, x] with
            | 'w' -> printf "█"  // Pared
            | 'f' -> printf " "  // Suelo
            | 's' -> printf "x"  // Algo especial, tal vez un obstáculo
            | 'R' -> printf "R"  // Rata Escurridiza
            | '2' -> printf "@"  // Jugador
            | '3' -> printf "◄"  // Puerta
            | 'G' -> printf "G"  // Goblin Sigiloso
            | 'L' -> printf "L"  // Lobo Salvaje
            | 'O' -> printf "O"  // Orco Enfurecido
            | 'T' -> printf "T"  // Troll Pesado
            | 'E' -> printf "E"  // Esqueleto Débil
            | 'Z' -> printf "Z"  // Zombi Lento
            | 'B' -> printf "B"  // Brujo Oscuro
            | '♫' -> printf "♫"  // Espectro Sombrío
            | _ -> printf "?"    // Desconocido
        printfn ""