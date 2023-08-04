using AuFeuLesPatternsModel;
using AuFeuLesPatternVisiteur;

namespace AuFeuLesPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainAuFeuLesPatterns();
        }
        static void MainAuFeuLesPatterns()
        {
            IMediateur mediateur = new CentreAppel();//Instanciation d'un mediateur
            IVisiteur visiteur = new VisiteurConsole(mediateur,EnumTypeVisiteur.Console);//Instanciation d'un Visiteur

            //Instanciation des villes 
            //Par defaut l'attribut procheDeMer est false a la construction
            Ville nice = new(mediateur,"Nice",_procheDeMer: true); 
            Ville canne = new(mediateur, "Canne",  true);
            Ville frejus = new(mediateur, "Fréjus",  true);
            Ville hyeres = new(mediateur, "Hyères",  true);
            Ville toulon = new(mediateur, "Toulon",  true);

            Ville digneLesBains = new(mediateur, "Digne les bains", _procheDeMer: false);
            Ville narbonne = new(mediateur, "Narbonne");
            Ville marseille = new(mediateur, "Marseille");
            Ville soltice = new(mediateur, "Soltice");//Ville fictive
            Ville Serming = new(mediateur, "Serming");//Ville fictive

            //Instanciation des camions
            Camion camion1 = new(mediateur);
            Camion camion2 = new(mediateur);
            Camion camion3 = new(mediateur);

            //Instanciation du bombardier
            Bombardier bombardier1 = new(mediateur);

            //Il y a une methode qui permet d'ajouter les villes, camions avion et visiteur des leur construction au mediateur juste apres la création

            Console.WriteLine(mediateur.DeclencherOperationExtinctionConsole(nice));
            Console.WriteLine(mediateur.DeclencherOperationExtinctionConsole(digneLesBains));
        }
    }
}