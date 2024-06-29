module Music

open System
open System.Threading.Tasks
open NAudio.Wave

let playMp3FileAsync (filePath: string) =
    async {
        try
            printfn "Reproduciendo archivo: %s" filePath
            use audioFileReader = new AudioFileReader(filePath)
            use waveOutDevice = new WaveOutEvent()

            waveOutDevice.Init(audioFileReader)
            waveOutDevice.Play()

            // Esperar a que termine la reproducción
            let rec waitForPlaybackToFinish () =
                if waveOutDevice.PlaybackState = PlaybackState.Playing then
                    Task.Delay(100).Wait()
                    waitForPlaybackToFinish()

            waitForPlaybackToFinish()

            printfn "Reproducción finalizada."

        with
        | ex -> printfn "Error al reproducir el archivo MP3: %s" ex.Message
    }

// Ejemplo de uso
let chayanne_ataque = "G:\proyecto LP\Roguelike\Roguelike-in-F-\Sounds\chayanne.mp3"

let golpe_generico="G:\proyecto LP\Roguelike\Roguelike-in-F-\Sounds\golpe.mp3"

let daño="G:\proyecto LP\Roguelike\Roguelike-in-F-\Sounds\daño.mp3"
// Aquí puedes continuar con otras operaciones mientras el audio se reproduce en segundo plano
let recoger= "G:\proyecto LP\Roguelike\Roguelike-in-F-\Sounds\item.mp3"

let fondo= "G:\proyecto LP\Roguelike\Roguelike-in-F-\Sounds\Fondo.mp3"