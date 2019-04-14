module OneLinerAnalyzer
open Types

let countLongestStreak = 
    List.fold (fun s cfr -> (cfr, (if fst s = cfr then List.head (snd s) + 1 else 1) :: snd s)) (Head, [0]) >> snd >> List.max