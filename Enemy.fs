module Enemy
open Types

let EnemiesCollection:list<Enemy>=[
    { Nombre = "Rata Escurridiza"; Posicion = (2, 1); Vida = 30; Daño = 5; Rango = 1 }
    { Nombre = "Goblin Sigiloso"; Posicion = (4, 1); Vida = 50; Daño = 10; Rango = 1 }
    { Nombre = "Lobo Salvaje"; Posicion = (6, 1); Vida = 70; Daño = 12; Rango = 2 }
    { Nombre = "Orco Enfurecido"; Posicion = (8, 1); Vida = 100; Daño = 15; Rango = 2 }
    { Nombre = "Troll Pesado"; Posicion = (10, 1); Vida = 150; Daño = 20; Rango = 2 }
    { Nombre = "Esqueleto Débil"; Posicion = (13, 1); Vida = 20; Daño = 5; Rango = 1 }
    { Nombre = "Zombi Lento"; Posicion = (15, 1); Vida = 50; Daño = 10; Rango = 1 }
    { Nombre = "Brujo Oscuro"; Posicion = (17, 1); Vida = 80; Daño = 18; Rango = 2 }
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