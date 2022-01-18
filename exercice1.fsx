// A: Nombres entiers
let five = 5;
let seven = 7;
    // Créez une liaison appelée « cube » qui prend en paramètre un entier et qui renvoie le cube de la valeur passée en paramètre.
let cube (x) =
    x * x * x;

cube(five);
cube(seven);

// B: Nombres à virgule
let testBalance: decimal = 200.75m;

    // Implémentez la fonction interestRate pour calculer le taux d'intérêt sur la base du solde spécifié
let interestRate (balance: decimal): single =    
    match balance with
    | i when (i < 0m) -> 3.213f
    | i when (i < 1000m) -> 0.5f
    | i when (i < 5000m) -> 1.621f
    | _ -> 2.475f;

interestRate(testBalance);

    //Implémentez la méthode interest pour calculer les intérêts sur la base du solde spécifié
let interest (balance: decimal): decimal =
    balance / 100m * decimal(interestRate(balance));

interest(testBalance);

    // Mettez en œuvre la fonction pour calculer la mise à jour annuelle du solde, en tenant compte du taux d'intérêt
let annualBalanceUpdate(balance: decimal): decimal =
    balance + interest(balance);

annualBalanceUpdate(testBalance);

    // Mettez en œuvre la fonction amountToDonate pour calculer le montant à donner aux associations caritatives 
    // en fonction du solde et du pourcentage d'exonération fiscale autorisé par le gouvernement :
let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
    int(balance / 100m * decimal(taxFreePercentage) * 2.0m);

let balance = 550.5m;
let taxFreePercentage = 2.5;

amountToDonate balance taxFreePercentage;