// Program.fs
open Mapa
open Player
open Types
open Game
open System.Threading
open System
open Music


let main () =
    let initialgame:Gamestate ={
        jugador = {Posicion=(7,1);Direccion = NADA ;Habitacion_Actual = 1;Arma={Nombre="espada";Daño=20;Rango=2};Vida=100 }
        Habitaciones = generateRooms spawnmapcollection mapcollection itemmapcollection bossmapcollection victoryRoom}
    Async.Start(playMp3FileAsync fondo)
    gameLoop initialgame 0
    System.Console.ReadLine() |>ignore 

main ()
