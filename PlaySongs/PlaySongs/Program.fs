﻿

[<EntryPoint>]
let main argv = 
    let stamp =  System.DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".wav"
    //FirstSong.play()
    //IAmWeird.play()
    //TiggerSong.play()
    //InteriorSounds.save "InteriorSounds.wav"
    //FHouse.save "FHouse.wav"
    //Prime.save ("Prime/" + stamp)
    ElleElision.play()

    printfn "%A" argv
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
