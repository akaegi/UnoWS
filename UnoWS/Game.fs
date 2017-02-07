module Game

open Cards

type Command = 
    | StartGame of StartGame

and StartGame = {
    Players: int;
    FirstCard: Card   
}  

type GameEvent = 
    | GameStarted of StartGame

type State = unit

let InitialState : State = ()

let evolve (state: State) (event: GameEvent): State = state

let decide (command: Command) (state: State): GameEvent list = []
