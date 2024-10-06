

//nbr random
var rand = new Random();
int nbr = rand.Next(0, 10);

//définition victoire
var win = false;

while(win != true ){
    System.Console.WriteLine($"Roulette Russe Activée, donne moi un chiffre: ");

    //Nombre User
    string inputUser;
    inputUser = Console.ReadLine();
    int chiffre = int.Parse(inputUser);

    //Algorythme jeux
    if(chiffre == nbr){
        System.Console.WriteLine($"Bravo pour cette victoire");
        win = true;
    }else if(chiffre < nbr){
        System.Console.WriteLine($"Plus grand !!!");
    }else{
        System.Console.WriteLine($"Plus petit !!!");
    }
}




