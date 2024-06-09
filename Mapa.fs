// Mapa.fs
module Mapa
open Types

open Enemy

let mapcollection:list<Room> =[
    {
        Id=1
        Enemigos=generateEnemiesWithPositions[(6,2);(6,12);(7,11)]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'s';'f';'s';'f';'f';'f';'f';'f';'s';'f';'s';'f';'w'|]
            [|'w';'f';'f';'s';'f';'f';'f';'f';'f';'f';'f';'s';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'w';'w';'w';'w';'w';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'s';'f';'f';'f';'f';'f';'f';'f';'s';'f';'f';'w'|]
            [|'w';'f';'s';'f';'s';'f';'f';'f';'f';'f';'s';'f';'s';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,14);Sala_destino=2}]
        Items=[]
    }
    {
        Id=2
        Enemigos=[]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'w';'f';'f';'f';'w';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(0,7);Sala_destino=1};{Posicion=(14,7);Sala_destino=3}]
        Items=[]
    }
]
