module RecursionAnalyzer
open Types

let countLongestStreak flips =
    let invert coinFlip = if coinFlip = Head then Tail else Head
    let rec countRec xs longestLen curLen curType = 
        match xs with
        | [] -> max longestLen curLen
        | (x::xs) when x = curType -> countRec xs longestLen (curLen+1) x        
        | (x::xs) -> countRec xs (max longestLen curLen) 0 (invert x)        
    countRec flips 0 0 Head