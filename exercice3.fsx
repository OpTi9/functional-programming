// A. Les records:
    // tache 1:
type RecordCoach = {
    Name: string;
    FormerPlayer: bool;
};

type RecordStats = {
    Wins: int;
    Losses: int;
};

type RecordTeam = {
    Name: string;
    Coach: RecordCoach;
    Stats: RecordStats;
}

    // tache 2:
let createCoach (name: string, isFormer: bool): RecordCoach = { Name=name; FormerPlayer=isFormer };

    // tache 3:
let createStats (wins: int, losses: int): RecordStats = { Wins=wins; Losses=losses };

    // tache 4:
let createTeam (name: string, coach: RecordCoach, stats: RecordStats): RecordTeam = { Name=name; Coach=coach; Stats=stats };

let coach = createCoach("Larry Bird", true);
let record = createStats(58,24);
let team = createTeam("Indiana Pacers", coach, record);

    // tache 5:
let replaceCoach (team: RecordTeam, newCoach: RecordCoach): RecordTeam = { team with Coach=newCoach };

let newCoach = createCoach("Isiah Thomas", true);

replaceCoach(team, newCoach);

    // tache 6:
let isSameTeam (team1: RecordTeam, team2: RecordTeam): bool =  
    if (team1 = team2) then 
        true 
    else 
        false;

let lakersCoach = createCoach("Del Harris",false);
let lakersStats = createStats(61,21);
let lakersTeam = createTeam("LA Lakers", lakersCoach, lakersStats);

isSameTeam(lakersTeam, team);

    // tache 7:
let rootForTeam (team: RecordTeam): bool =    
    match team with
    | i when (i.Coach.Name = "Gregg Popovich") -> true
    | i when (i.Name = "Chicago Bulls") -> true
    | i when (i.Coach.FormerPlayer) -> true
    | i when (i.Stats.Wins >= 60) -> true
    | i when (i.Stats.Losses > i.Stats.Wins) -> true
    | _ -> false;

let spursCoach = createCoach("Gregg Popovich", false);
let spursStats = createStats(56, 26);
let spursTeam = createTeam("San Antonio Spurs", spursCoach, spursStats);

rootForTeam(spursTeam);

// B. Les enums
    // tache 1:
type Approbation = 
    | Oui 
    | Non
    | Bof 

    // tache 2:
type Cuisine = 
    | Coreen 
    | Turc 

    // tache 3:
type Genre =
    | Crime 
    | Horreur 
    | Romance 
    | Thriller 

    // tache 4:
type Activity = 
    | BoardGame
    | Chill
    | Film of Genre
    | Restaurant of Cuisine
    | Walk of int

    // tache 5:
let rateActivity(act: Activity) : Approbation =
    match act with
    | BoardGame -> Non
    | Chill -> Non
    | Film Romance -> Oui
    | Restaurant Coreen -> Oui
    | Restaurant Turc -> Bof
    | Walk w when w < 3 -> Oui
    | _ -> Non;

rateActivity(Restaurant Turc);