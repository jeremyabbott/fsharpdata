// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open FSharp.Data

type Simple = JsonProvider<""" { "name":"John", "age":94 } """>
//type Issue = JsonProvider<"https://api.github.com/repos/fsharp/FSharp.Data/issues">

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code

