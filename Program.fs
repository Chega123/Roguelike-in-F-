// Program.fs
open Mapa
open Player
open Types
open Game

let main () =
    let initialState:Gamestate ={
        jugador = {Posicion=(1,1);direccion = DOWN;Habitacion_Actual = 1;Arma={Nombre="espada";Daño=20;Rango=2};Vida=100 }
        Habitacion = Mapa.mapcollection}
    
    
    drawMap initialState

main ()