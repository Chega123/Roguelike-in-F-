// Program.fs
open Mapa
open Player




let main () =
    let player = { pos = pos_inicial; puntos = 100; Inventario = [] }
    imprimirMapa map1 player
    let newPosition = Player.movePlayer player (1,0)
    printfn "New position: (%d, %d)" newPosition.pos.X newPosition.pos.Y

    // Imprimir el mapa
    printfn "\nMapa actual:"
    imprimirMapa map1 newPosition
main()