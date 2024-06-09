// FileUtils.fs
module FileUtils
open System.IO
let saveMatrixToFile (matrix: char[,]) (filePath: string) =
    use writer = new StreamWriter(filePath)
    for i = 0 to Array2D.length1 matrix - 1 do
        for j = 0 to Array2D.length2 matrix - 1 do
            writer.Write(matrix.[i, j])
        writer.WriteLine()