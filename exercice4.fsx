// tache 1:
let lastWeek : int[] =  [|0;2;5;3;7;8;4|]

// tache 2:
let visitesHier(visites: int[]): int =
    // select last element of the array
    visites[visites.Length - 2];

visitesHier(lastWeek);

// tache 3:
// create a function that accepts an array of ints and returns the sum of all the elements
let total(visites: int[]): int =
    Array.sum(visites);

total(lastWeek);

// tache 4:
// create a function that accepts an array of ints and returns true if at least one element is equal to 0
let joursSansVisite(visites: int[]): bool = visites |> Array.exists (fun elm -> elm = 0)

let biCount = [|3;5;0;7;4;1|];

joursSansVisite(biCount);

// tache 5:
let incrementTodaysCount(visites: int[]): int[] =
    // increase the last element of the array by 1
    visites[visites.Length - 1] <- visites[visites.Length - 1] + 1;
    visites

let birdCount = [|3;5;0;7;4;1|];
incrementTodaysCount(birdCount);