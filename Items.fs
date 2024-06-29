module Items
open Types

let WeaponsCollection:list<Weapon>=[
    {Nombre="espada";Daño=20;Rango=2}
    {Nombre="lanza";Daño=15;Rango=3}
    {Nombre="arco";Daño=15;Rango=6}
    {Nombre="mandoble";Daño=30;Rango=1}
    {Nombre="daga";Daño=10;Rango=1}
    {Nombre="Chayanne"; Daño=10000;Rango=10}
    {Nombre="Chayanne"; Daño=10000;Rango=10}
    {Nombre="Chayanne"; Daño=10000;Rango=10}
    {Nombre="Chayanne"; Daño=10000;Rango=10}
    {Nombre="Chayanne"; Daño=10000;Rango=10}
]


let randomItem (posicion_base: int * int) : Item =
    let rnd = System.Random()
    let index = rnd.Next(WeaponsCollection.Length)
    let arma = WeaponsCollection.[index]
    printf "%s" arma.Nombre
    { Posicion = posicion_base; tipo = arma }
