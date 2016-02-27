open Slacker.API

[<EntryPoint>]
let main argv =
    //let result = 
    printfn "%A" (ProcessRequest ["helloworld" ; "foo bar baz"])
    printfn "%A" (ProcessRequest ["help"])
    0 // return an integer exit code

