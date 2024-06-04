// Player.fs
module Player

type Position = { X : int; Y : int }

type Player = {
    pos : Position
    puntos : int
    Inventario : string list
}

let pos_inicial = { X = 2; Y = 2 }

let movePlayer (player: Player) (dx, dy) : Player =
    let newPosition = { X = player.pos.X + dx; Y = player.pos.Y + dy }
    { player with pos = newPosition }
