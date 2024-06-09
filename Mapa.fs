// Mapa.fs
module Mapa
open Types
open System
open Enemy

//Enemigos=generateEnemiesWithPositions[(6,2);(6,12);(7,11)]

let spawnmapcollection:list<Room> =[ //unico, sala de destino siempre
    {
        Id=1
        Enemigos=generateEnemiesWithPositions[(6,2);(6,12);(7,11)]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'a';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'a';'a';'a';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'a';'a';'a';'a';'a';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'f';'a';'a';'a';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'a';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,14); Sala_destino=2}]
        Items=[]
    }
]


let mapcollection:list<Room> =[
    {
        Id=1
        Enemigos=[] //generateEnemiesWithPositions[(7,12)]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'s';'a';'a';'s';'a';'a';'s';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'a';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'a';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'s';'a';'a';'s';'a';'a';'s';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
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
            [|'w';'a';'a';'a';'f';'f';'f';'f';'f';'f';'f';'a';'a';'a';'w'|]
            [|'w';'a';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'a';'w'|]
            [|'w';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'a';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'a';'a';'a';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'a';'a';'a';'a';'a';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'a';'a';'a';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'a';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'w'|]
            [|'w';'a';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'a';'w'|]
            [|'w';'a';'a';'a';'f';'f';'f';'f';'f';'f';'f';'a';'a';'a';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=1};{Posicion=(7,14);Sala_destino=3}]
        Items=[]
    }
    {
        Id=3
        Enemigos=[] //(5,11)
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'f';'f';'f';'f';'f';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'f';'f';'f';'f';'f';'f';'f';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'a';'a';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'a';'a';'f';'f';'f';'f';'f';'a';'a';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'a';'a';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'f';'f';'f';'f';'f';'f';'f';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'f';'f';'f';'f';'f';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=2};{Posicion=(7,14);Sala_destino=4}]
        Items=[]
    }
    {
        Id=4
        Enemigos=[] //(,)
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'s';'s';'s';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'s';'a';'a';'a';'s';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'s';'a';'a';'a';'s';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'s';'a';'a';'a';'s';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'s';'s';'s';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=3};{Posicion=(7,14);Sala_destino=5}]
        Items=[]
    }
    {
        Id=5
        Enemigos=[] //(,)
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=4};{Posicion=(7,14);Sala_destino=6}]
        Items=[]
    }
    {
        Id=6
        Enemigos=[] //(,)
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]            
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'s';'f';'f';'f';'f';'f';'s';'f';'f';'f';'w'|]
            [|'w';'f';'f';'s';'s';'s';'f';'f';'f';'s';'s';'s';'f';'f';'w'|]
            [|'w';'f';'f';'f';'s';'f';'f';'f';'f';'f';'s';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'s';'f';'f';'f';'f';'f';'s';'f';'f';'f';'w'|]
            [|'w';'f';'f';'s';'s';'s';'f';'f';'f';'s';'s';'s';'f';'f';'w'|]
            [|'w';'f';'f';'f';'s';'f';'f';'f';'f';'f';'s';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=5};{Posicion=(7,14);Sala_destino=7}]
        Items=[]
    }
    {
        Id=7
        Enemigos=[] //(,)
        Mapa=array2D [
            [|'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a'|]
            [|'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a'|]
            [|'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=6};{Posicion=(7,14);Sala_destino=8}]
        Items=[]
    }
    {
        Id=8
        Enemigos=[] //(,)
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'w';'w';'w';'w';'w';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'w';'a';'a';'a';'w';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'w';'a';'a';'a';'w';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'w';'a';'a';'a';'w';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'w';'w';'w';'w';'w';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=7};{Posicion=(7,14);Sala_destino=9}]
        Items=[]
    }
    {
        Id=9
        Enemigos=[] //(,)
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=8};{Posicion=(7,14);Sala_destino=10}]
        Items=[]
    }
    {
        Id=10
        Enemigos=[] //(,)
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'a';'a';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'a';'f';'f';'a';'a';'a';'f';'f';'w'|]
            [|'w';'f';'f';'a';'a';'a';'a';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'s';'s';'s';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'a';'a';'a';'a';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'a';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'a';'a';'a';'f';'f';'f';'f';'f';'a';'a';'a';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'f';'f';'f';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=9};{Posicion=(7,14);Sala_destino=11}]
        Items=[]
    }
    
]





let printRoomDetails (room: Room) =
    printfn "Room ID: %d" room.Id
    printfn "Enemies in room:"
    room.Enemigos |> List.iter (fun enemy -> 
        printfn "Nombre: %s, Posicion: %A, Vida: %d, Daño: %d, Rango: %d" 
            enemy.Nombre enemy.Posicion enemy.Vida enemy.Daño enemy.Rango)


let drawMap (game: Gamestate) =
    let actual_room = game.Habitaciones.[game.jugador.Habitacion_Actual - 1]
    let height = Array2D.length1 actual_room.Mapa
    let width = Array2D.length2 actual_room.Mapa
    let mapCopy = Array2D.copy actual_room.Mapa

    // Jugador
    let px, py = game.jugador.Posicion
    mapCopy.[px, py] <- '2'

    // Puertas
    actual_room.Puertas |> List.iter (fun puerta ->
        let dx, dy = puerta.Posicion
        mapCopy.[dx, dy] <- '3'
    )

    // Enemigos
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

    // Actualiza la habitación actual con el nuevo mapa
    let updated_room = { actual_room with Mapa = mapCopy }

    // Reemplaza la habitación en la lista de habitaciones
    let updated_rooms = 
        game.Habitaciones 
        |> List.mapi (fun i room -> if i = game.jugador.Habitacion_Actual - 1 then updated_room else room)

    // Devuelve una nueva versión del estado del juego con la lista de habitaciones actualizada
    { game with Habitaciones = updated_rooms }


