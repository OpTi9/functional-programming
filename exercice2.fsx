// Implémentez la fonction message pour retourner le message d'une ligne de journal:
let message (str: string): string =
    str.Substring(str.IndexOf(':') + 2);

message "[WARNING] : Disque presque plein";

// Implémentez la fonction qui renvoie le niveau de journalisation d'une ligne de journal, qui doit être renvoyé en minuscules :
let logLevel (str: string): string =
    str.Substring(str.IndexOf('[') + 1, str.IndexOf(']') - 1).ToLower();

logLevel "[ERREUR] : Disque presque plein";

// Implémentez la fonction qui met le message en premier et le niveau de journal après entre parenthèses
let reformat (str: string): string =
    message(str) +  " (" + logLevel(str) + ")";

reformat("[INFO] : Opération terminée");


// Manipuler les caractères
let BobDoSomething (str: string): string =    
    match str with
    | i when (i.Length = 0) -> "Très bien. Sois comme ça";
    | i when (i.Contains("?")) -> "Bien sûr";
    | _ -> "Peu importe";

BobDoSomething("test");