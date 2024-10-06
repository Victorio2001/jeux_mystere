//nbr random
var rand = new Random();
int nbr = rand.Next(0, 10);

//définition victoire
var win = false;

//Ajout du nombre de try
List<int> tentatives = new List<int>();

while(win != true ){
    Console.Clear();
    var nombreEssaie = tentatives.Count();

    if (tentatives.Count() > 0)
    {
        System.Console.WriteLine("Nombre jouées : ");
        foreach (var item in tentatives)
        {
            System.Console.Write($"{item},");
        }
        System.Console.WriteLine();
    }

    //Console.Clear();
    System.Console.WriteLine($"tentatives numéro => {nombreEssaie}, Roulette Russe Activée, donne moi un chiffre: ");

    //Nombre User
    string inputUser;
    inputUser = Console.ReadLine();
    int chiffre = int.Parse(inputUser);
    tentatives.Add(chiffre);

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




