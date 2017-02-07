module UnoWS

open Cards
open Game

let a = [1;2] 

let (=>) (events: GameEvent list) (command: Command) : GameEvent list =
  events
  |> List.fold evolve InitialState
  |> decide command

let testCase (description: string) (pred: 'a -> bool) = 
    let result = pred ()
    printfn "%s: %b" description result

[<EntryPoint>]
let main argv =
    testCase "Game should start" <| fun _ -> 
        ([]
        => StartGame { Players = 3; FirstCard = Digit(Three, Red)}
        = [ GameStarted { Players = 3; FirstCard = Digit(Three, Red) } ])
    0 // return an integer exit code