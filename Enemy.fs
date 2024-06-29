module Enemy
open Types
open Music
let EnemiesCollection:list<Enemy>=[
    { Nombre = "Rata Escurridiza"; Posicion = (2, 1); Vida = 30; Daño = 5; Rango = 1 }
    { Nombre = "Goblin Sigiloso"; Posicion = (4, 1); Vida = 50; Daño = 10; Rango = 1 }
    { Nombre = "Lobo Salvaje"; Posicion = (6, 1); Vida = 70; Daño = 12; Rango = 2 }
    { Nombre = "Orco Enfurecido"; Posicion = (8, 1); Vida = 100; Daño = 15; Rango = 3 }
    { Nombre = "Troll Pesado"; Posicion = (10, 1); Vida = 150; Daño = 20; Rango = 3 }
    { Nombre = "Esqueleto Débil"; Posicion = (13, 1); Vida = 20; Daño = 5; Rango = 1 }
    { Nombre = "Zombi Lento"; Posicion = (15, 1); Vida = 50; Daño = 10; Rango = 1 }
    { Nombre = "Brujo Oscuro"; Posicion = (17, 1); Vida = 80; Daño = 18; Rango = 4 }
    { Nombre = "Espectro Sombrío"; Posicion = (20, 1); Vida = 60; Daño = 15; Rango = 2 }
]

let BossCollection:list<Enemy>=[
    { Nombre = "Jefe: Dragón Rojo"; Posicion = (11, 1); Vida = 300; Daño = 40; Rango = 3 }
    { Nombre = "Jefe: Gigante de Piedra"; Posicion = (16, 1); Vida = 400; Daño = 50; Rango = 3 }
    { Nombre = "Jefe: Señor del Caos"; Posicion = (19, 1); Vida = 500; Daño = 60; Rango = 4 }

]
let randomEnemy (posicion_base: int * int) : Enemy =
    let rnd = System.Random()
    let enemigo = EnemiesCollection.[rnd.Next(EnemiesCollection.Length)]
    { enemigo with Posicion = posicion_base }

let randomBoss (posicion_base: int * int) :Enemy=
    let rnd = System.Random()
    let Jefe = BossCollection.[rnd.Next(BossCollection.Length)]
    { Jefe with Posicion = posicion_base }

let generateEnemiesWithPositions (positions: list<int * int>) : list<Enemy> =
    positions |> List.map randomEnemy

let generateBossesWithPositions (positions: list<int * int>) : list<Enemy> =
    positions |> List.map randomBoss


let calculateDirection (enemyPos: int * int) (playerPos: int * int) =
    let (ex, ey) = enemyPos
    let (px, py) = playerPos
    if ex < px then DOWN
    elif ex > px then UP
    elif ey < py then RIGHT
    else LEFT

let moveEnemy (enemy: Enemy) (playerPos: int * int) (map: char[,]) =
    let direction = calculateDirection enemy.Posicion playerPos
    let (x, y) = enemy.Posicion
    let newPos =
        match direction with
        | UP -> (x - 1, y)
        | DOWN -> (x + 1, y)
        | LEFT -> (x, y - 1)
        | RIGHT -> (x, y + 1)
        | NADA -> (x, y)
    let (nx, ny) = newPos
    if nx >= 0 && ny >= 0 && nx < Array2D.length1 map && ny < Array2D.length2 map then
        match map.[nx, ny] with
        | 'f' | '2' -> { enemy with Posicion = newPos }
        | _ -> enemy
    else
        enemy

let moveEnemies (enemies: Enemy list) (playerPos: int * int) (map: char[,]) =
    enemies |> List.map (fun enemy -> moveEnemy enemy playerPos map)

let updateGameStateWithEnemies (game: Gamestate) =
    let actualroom = game.Habitaciones.[game.jugador.Habitacion_Actual - 1]
    let updatedEnemies = moveEnemies actualroom.Enemigos game.jugador.Posicion actualroom.Mapa
    let updatedRoom = { actualroom with Enemigos = updatedEnemies }
    let updatedRooms = 
        game.Habitaciones 
        |> List.mapi (fun i room -> if i = game.jugador.Habitacion_Actual - 1 then updatedRoom else room)
    { game with Habitaciones = updatedRooms }


let isPlayerInRange (playerPos: int * int) (enemyPos: int * int) (rango: int) =
    let (px, py) = playerPos
    let (ex, ey) = enemyPos
    let distance = abs(px - ex) + abs(py - ey)
    distance <= rango

let attackPlayer (player: Player) (enemy: Enemy) =
    Async.Start(playMp3FileAsync daño)
    { player with Vida = player.Vida - enemy.Daño }


let rec attackEnemiesInRange (player: Player) (enemies: Enemy list) =
    match enemies with
    | [] -> player // Si no hay más enemigos, devolvemos el jugador sin cambios
    | enemy::rest -> //como lo de haskell
        // Verificar si el jugador está dentro del rango de ataque del enemigo actual
        if isPlayerInRange player.Posicion enemy.Posicion enemy.Rango then
            // Si el jugador está en el rango, realizar el ataque del enemigo al jugador
            let updatedPlayer = attackPlayer player enemy
            attackEnemiesInRange updatedPlayer rest
        else
            attackEnemiesInRange player rest

