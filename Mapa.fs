// Mapa.fs
module Mapa
open Types
open System
open Enemy
open Items

//Enemigos=generateEnemiesWithPositions[(6,2);(6,12);(7,11)]

let spawnmapcollection:list<Room> =[ //unico, sala de destino siempre
    {
        Id=1
        Enemigos=[]
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
    {
        Id=2
        Enemigos=[]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,14); Sala_destino=2}]
        Items=[]
    }
    {
        Id=3
        Enemigos=[]
        Mapa=array2D [
            [|'a';'a';'a';'a';'w';'w';'w';'w';'w';'w';'w';'s';'s';'w';'w'|]
            [|'a';'a';'a';'a';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'a';'a';'a';'a';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'a';'a';'a';'a';'s';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'a';'a';'a';'a';'s';'f';'f';'f';'f';'f';'w';'w';'f';'w';'w'|]
            [|'a';'a';'a';'a';'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'w';'w';'w';'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'w';'w';'w';'w'|]
            [|'w';'w';'w';'f';'w';'f';'f';'f';'f';'f';'f';'f';'a';'a';'a'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'w';'f';'f';'a';'a';'a';'a'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'w';'s';'a';'a';'a';'a';'a'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'w';'a';'a';'a';'a';'a';'a'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'w';'a';'a';'a';'a';'a';'a'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'a';'a';'a';'a';'a';'a'|]
        ]
        Puertas=[{Posicion=(7,14); Sala_destino=2}]
        Items=[]
    }
    {
        Id=4
        Enemigos=[]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'w';'w';'w';'f';'f';'f';'w';'w';'f';'w';'w';'f';'w'|]
            [|'w';'f';'f';'f';'w';'w';'w';'f';'w';'f';'f';'w';'f';'f';'w'|]
            [|'w';'w';'w';'f';'f';'f';'w';'w';'w';'f';'w';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'f';'w';'w';'w';'w';'f';'w';'w'|]
            [|'w';'f';'f';'f';'w';'f';'w';'f';'f';'f';'f';'w';'f';'f';'d'|]
            [|'w';'w';'w';'f';'w';'f';'f';'f';'w';'f';'w';'w';'w';'w';'w'|]
            [|'w';'f';'w';'f';'w';'f';'w';'f';'w';'f';'f';'w';'f';'f';'w'|]
            [|'w';'f';'f';'f';'w';'w';'w';'f';'w';'w';'w';'w';'f';'w';'w'|]
            [|'w';'f';'w';'f';'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'w';'w';'w';'f';'w';'f';'w';'f';'w';'w';'w';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'f';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,14); Sala_destino=2}]
        Items=[]
    }


]


let mapcollection:list<Room> =[
    {
        Id=1
        Enemigos=generateEnemiesWithPositions[(6,12);(7,11);(5,11)]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w';'w'|]
            [|'w';'a';'a';'f';'s';'f';'f';'s';'f';'f';'s';'f';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'a';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'a';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'f';'s';'f';'f';'s';'f';'f';'s';'f';'a';'a';'w'|]
            [|'w';'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,14);Sala_destino=2}]
        Items=[]
    }
    {
        Id=2
        Enemigos=generateEnemiesWithPositions[(9,12);(7,11);(3,11)]
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
        Enemigos=generateEnemiesWithPositions[(5,11);(10,4)]
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
        Enemigos=generateEnemiesWithPositions[(9,5);(3,11)]
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
        Enemigos=generateEnemiesWithPositions[(3,12);(12,12);(3,5)]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'d'|]
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
        Enemigos=generateEnemiesWithPositions[(1,1);(13,1);(12,12)]
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
        Enemigos=generateEnemiesWithPositions[(4,9);(4,12)]
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
        Enemigos=generateEnemiesWithPositions[(2,7);(12,6)]
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
        Enemigos=generateEnemiesWithPositions[(4,6);(4,8);(6,7);(12,12);(2,12)]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'w';'f';'f';'f';'f';'f';'w';'f';'f';'f';'w'|]
            [|'w';'f';'f';'s';'w';'f';'f';'f';'f';'f';'w';'s';'f';'f';'w'|]
            [|'d';'f';'f';'s';'w';'f';'f';'f';'f';'f';'w';'s';'f';'f';'d'|]
            [|'w';'f';'f';'s';'w';'f';'f';'f';'f';'f';'w';'s';'f';'f';'w'|]
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
        Enemigos=generateEnemiesWithPositions[(12,12);(2,12)]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'f';'f';'w';'w';'f';'f';'f';'f';'f';'w';'w';'f';'f';'w'|]
            [|'w';'f';'f';'w';'w';'f';'f';'w';'f';'f';'w';'w';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'w';'w';'w';'w';'w';'w';'w';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'w';'w';'f';'f';'w';'f';'f';'w';'w';'f';'f';'w'|]
            [|'w';'f';'f';'w';'w';'f';'f';'f';'f';'f';'w';'w';'f';'f';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=9};{Posicion=(7,14);Sala_destino=11}]
        Items=[]
    }
    {
        Id=11
        Enemigos=generateEnemiesWithPositions[(13,11);(3,8)]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'w';'w';'w';'w';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'w';'f';'f';'f';'w';'f';'f';'f';'s';'s';'f';'f';'w'|]
            [|'w';'f';'w';'f';'f';'f';'w';'f';'f';'f';'f';'s';'f';'f';'w'|]
            [|'w';'f';'w';'w';'w';'f';'w';'f';'f';'f';'f';'f';'s';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'w';'w';'w';'f';'f';'w'|]
            [|'a';'a';'a';'f';'f';'f';'f';'f';'f';'w';'f';'f';'w';'f';'w'|]
            [|'a';'a';'a';'a';'a';'f';'f';'f';'f';'w';'f';'f';'w';'f';'w'|]
            [|'a';'a';'a';'a';'a';'a';'s';'f';'f';'w';'w';'f';'f';'f';'w'|]
            [|'w';'a';'a';'a';'a';'a';'s';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'a';'a';'a';'a';'a';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=10};{Posicion=(7,14);Sala_destino=12}]
        Items=[]
    }
    {
        Id=12
        Enemigos=generateEnemiesWithPositions[(1,1);(13,13);(1,10);(10,5)]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w'|]
            [|'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w'|]
            [|'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'d'|]
            [|'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w'|]
            [|'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w'|]
            [|'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w';'w';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=11};{Posicion=(7,14);Sala_destino=13}]
        Items=[]
    }
    {
        Id=13
        Enemigos=generateEnemiesWithPositions[(3,12);(12,10)]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'s';'a';'a';'a';'a';'a';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'w';'s';'a';'a';'a';'a';'s';'s';'s';'s';'w'|]
            [|'w';'f';'f';'f';'w';'s';'a';'a';'a';'s';'f';'f';'f';'s';'w'|]
            [|'w';'w';'w';'f';'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'a';'a';'a';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'a';'a';'a';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'a';'a';'a';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'a';'a';'a';'f';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'f';'a';'a';'a';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'a';'a';'a';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'a';'a';'a';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'f';'f';'f';'f';'f';'a';'a';'a';'f';'f';'f';'s';'s';'w'|]
            [|'w';'w';'w';'w';'w';'w';'a';'a';'a';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=12};{Posicion=(7,14);Sala_destino=14}]
        Items=[]
    }
    {
        Id=14
        Enemigos=generateEnemiesWithPositions[(7,7);(8,10);(6,12);(12,11)]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'f';'w';'w';'w';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'f';'f';'f';'w';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'f';'f';'f';'w';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'f';'f';'f';'w';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=13};{Posicion=(7,14);Sala_destino=15}]
        Items=[]
    }
]


let itemmapcollection:list<Room> =[
    {
        Id=1
        Enemigos=[] //(,)
        Mapa=array2D [
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'f';'f';'f';'f';'f';'a';'a';'a';'a';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'a';'a';'a';'a';'f';'f';'f';'f';'f';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=5}]
        Items=[randomItem (7,7)]
    }
    {
        Id=2
        Enemigos=[] //(,)
        Mapa=array2D [
            [|'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a'|]
            [|'a';'a';'a';'a';'a';'w';'f';'a';'a';'a';'a';'a';'a';'a';'a'|]
            [|'a';'a';'a';'a';'a';'w';'f';'f';'a';'a';'a';'a';'a';'a';'a'|]
            [|'a';'a';'a';'a';'a';'w';'f';'f';'f';'w';'a';'a';'a';'a';'a'|]
            [|'a';'a';'a';'a';'a';'w';'f';'f';'f';'w';'a';'a';'a';'a';'a'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'a';'a';'a';'a';'a';'w';'f';'f';'f';'w';'a';'a';'a';'a';'a'|]
            [|'a';'a';'a';'a';'a';'w';'f';'f';'f';'w';'a';'a';'a';'a';'a'|]
            [|'a';'a';'a';'a';'a';'w';'f';'f';'f';'w';'a';'a';'a';'a';'a'|]
            [|'a';'a';'a';'a';'a';'w';'s';'f';'f';'w';'a';'a';'a';'a';'a'|]
            [|'a';'a';'a';'a';'a';'w';'f';'f';'f';'w';'a';'a';'a';'a';'a'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=5}]
        Items=[randomItem (7,7)]
    }
    {
        Id=3
        Enemigos=[] //(,)
        Mapa=array2D [
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
            [|'w';'a';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'a';'w'|]
            [|'w';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'w'|]
            [|'w';'a';'a';'f';'f';'f';'f';'f';'f';'f';'f';'f';'a';'a';'w'|]
            [|'w';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'a';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=5}]
        Items=[randomItem (7,7)]
    }
]


let bossmapcollection:list<Room> =[
    {
        Id=1
        Enemigos=[randomBoss (7,7)]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=4};{Posicion=(7,14);Sala_destino=12}]
        Items=[]
    }
    {
        Id=2
        Enemigos=[randomBoss (7,7)]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'s';'f';'f';'f';'f';'s';'w'|]
            [|'w';'f';'f';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'s';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'w';'w';'f';'w';'w';'f';'f';'s';'f';'w'|]
            [|'w';'f';'f';'f';'f';'w';'f';'f';'f';'w';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'d'|]
            [|'w';'s';'f';'f';'f';'w';'f';'f';'f';'w';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'w';'w';'f';'w';'w';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'f';'f';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=4};{Posicion=(7,14);Sala_destino=12}]
        Items=[]
    }
    {
        Id=3
        Enemigos=[randomBoss (7,12)]
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
]

let victoryRoom:list<Room> =[
    {
        Id=1
        Enemigos=[]
        Mapa=array2D [
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'d';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'d'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'w';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'w'|]
            [|'w';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'w'|]
            [|'w';'s';'s';'f';'f';'f';'f';'f';'f';'f';'f';'f';'s';'s';'w'|]
            [|'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w';'w'|]
        ]
        Puertas=[{Posicion=(7,0);Sala_destino=4}]
        Items=[]
    }]


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
    match game.jugador.UltimaDireccion with
    | UP -> mapCopy.[px, py] <- 'W'
    | DOWN -> mapCopy.[px, py] <- 'S'
    | LEFT -> mapCopy.[px, py] <- 'A'
    | RIGHT -> mapCopy.[px, py] <- 'D'
    | NADA -> mapCopy.[px, py] <- 'D'

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
        | "Espectro Sombrío" -> mapCopy.[ex, ey] <- 'P'
        | "Jefe: Dragón Rojo" -> mapCopy.[ex, ey] <- '&'
        | "Jefe: Gigante de Piedra" -> mapCopy.[ex, ey] <- '%'
        | "Jefe: Señor del Caos" -> mapCopy.[ex, ey] <- '$'
        | _ -> ()
    )

    actual_room.Items |> List.iter (fun item ->
        let ex, ey = item.Posicion
        match item.tipo.Nombre with
        | "espada" -> mapCopy.[ex, ey] <- '5'
        | "lanza" -> mapCopy.[ex, ey] <- '6'
        | "arco" -> mapCopy.[ex, ey] <- '7'
        | "mandoble" -> mapCopy.[ex, ey] <- '8'
        | "daga" -> mapCopy.[ex, ey] <- '9'
        | "Chayanne" -> mapCopy.[ex, ey] <- '*'
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

let random = new System.Random()

let updateRoomWithDoors (id: int) (total: int) (room: Room) =
    let newDoors =
        match id with
        | 1 -> [{Posicion=(7,14); Sala_destino=2}] // Only door to the next room
        | _ when id = total -> [{Posicion=(7,0); Sala_destino=id-1}] // Only door to the previous room
        | _ -> [{Posicion=(7,14); Sala_destino=id+1}; {Posicion=(7,0); Sala_destino=id-1}] // Doors to the next and previous rooms
    { room with Id = id; Puertas = newDoors }


let generateRooms (spawn: Room list) (maps: Room list) (items: Room list) (bosses: Room list) (Victory: Room list) =
    let spawnRoom = spawn |> List.item (random.Next(spawn.Length))
    let mapRooms = maps |> List.sortBy (fun _ -> random.Next()) |> List.take 5
    let itemRoom = items |> List.item (random.Next(items.Length))
    let bossRoom =bosses |> List.item (random.Next(bosses.Length))
    let victoriaCuarto =Victory |> List.item (random.Next(Victory.Length))
    let total = mapRooms.Length + 4  // Agregar 2 para incluir spawnRoom y itemRoom
    let allRooms = spawnRoom :: itemRoom :: mapRooms @ [bossRoom] @[victoriaCuarto]

    // Actualizar las habitaciones con puertas
    allRooms
    |> List.mapi (fun id room -> updateRoomWithDoors (id + 1) total room)
