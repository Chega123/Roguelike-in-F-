// Program.fs
open Mapa
open Player
open Types
open Game
open System.Threading
open System



let main () =
    let initialgame:Gamestate ={
        jugador = {Posicion=(7,1);Direccion = NADA ;Habitacion_Actual = 1;Arma={Nombre="espada";Daño=20;Rango=2};Vida=100 }
        Habitaciones = Mapa.mapcollection}
    
    Async.Start (gameLoop initialgame)
    System.Console.ReadLine() |>ignore 

main ()
