namespace CoinFlipper.Hardcore.Adapters
open Types
open CoinFlipper.Models
open System.Collections.Generic

module HardcoreAdapter =
    let CountLongestStreak (flips : IEnumerable<CoinFlipResult>) =
        let fSharpList = List.map (fun cfr -> if cfr = CoinFlipResult.Head then Head else Tail)  (List.ofSeq flips)        
        OneLinerAnalyzer.countLongestStreak fSharpList
        //RecursionAnalyzer.countLongestStreak fSharpList