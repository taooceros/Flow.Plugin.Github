namespace Flow.Plugin.Github

open System.Collections.Generic

[<CLIMutable>]
type HistoryItem =
    { Title: string
      QueryType: string }


type Setting() =
    let mutable history : List<HistoryItem> = new List<HistoryItem>()

    member this.History
        with get () = history
        and set (value) = history <- value
