// FileUtils.fs
module FileUtils
open System.IO
let saveMatrixToFile (matrix: char[,]) (filePath: string) =
    use writer = new StreamWriter(filePath)
    for i = 0 to Array2D.length1 matrix - 1 do
        for j = 0 to Array2D.length2 matrix - 1 do
            writer.Write(matrix.[i, j])
        writer.WriteLine()


let saveRoomStateToFile (filePath: string) (vida: int) (arma: string) (id:int) (matrix: char[,]) =
    use writer = new StreamWriter(filePath)

    // Escribir la vida y el nombre del arma en el archivo
    writer.WriteLine(vida)
    writer.WriteLine(arma)
    writer.WriteLine(id)

    // Escribir la matriz en el archivo
    let rows = matrix.GetLength(0)
    let cols = matrix.GetLength(1)

    for row in 0 .. rows - 1 do
        for col in 0 .. cols - 1 do
            writer.Write(matrix.[row, col])
        writer.WriteLine()