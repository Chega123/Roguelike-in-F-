module Types

type Direction =
    | UP
    | DOWN
    | LEFT
    | RIGHT
    | ATTACK

type Weapon={
    Nombre:string
    Daño:int
    Rango:int
}

type Item={
    Posicion:int * int 
    tipo:Weapon
}


type Player = {
    Posicion : int * int
    direccion:Direction
    Habitacion_Actual:int
    Arma:Weapon
    Vida:int
}

type Door={
    Posicion:int * int
    Sala_destino:int
}

type Enemy={
    Nombre:string
    Posicion:int * int
    Vida:int
    Daño:int
    Rango:int
}

type Room={
    Id:int
    Enemigos:Enemy list
    Mapa:char[,]
    Puertas:Door list
    Items:Item list
}

type Gamestate={
    jugador:Player
    Habitacion:Room list
}