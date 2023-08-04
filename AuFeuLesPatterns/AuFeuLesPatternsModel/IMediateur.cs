using AuFeuLesPatternVisiteur;
using System;

namespace AuFeuLesPatternsModel
{
    public interface IMediateur
    {
        /// <summary>
        /// Permet d'ajouter un <see cref="Camion"/> des sa construction
        /// </summary>
        public void AjouterColleague(Camion _camion);
        /// <summary>
        /// Permet d'ajouter un <see cref="Bombardier"/> des sa construction
        /// </summary>
        public void AjouterColleague(Bombardier _Bombardier);
        /// <summary>
        /// Permet d'ajouter un <see cref="Ville"/> des sa construction
        /// </summary>
        public void AjouterColleague(Ville _ville);
        /// <summary>
        /// Permet d'ajouter un <see cref="IVisiteur"/> des sa construction
        /// </summary>
        public void AjouterColleague(IVisiteur _visiteur);
        /// <summary>
        /// Lance les operations d'extinction d'un incendie en fonction d'une <see cref="Ville"/> <br/>
        /// Grace au mediateur on decide si c'est le <seealso cref="Bombardier"/> ou les <seealso cref="Camion"/> qui seront en intervention
        /// </summary>
        public string DeclencherOperationExtinctionConsole(Ville _ville);
        /// <summary>
        /// Surcharge de la methode <see cref="DeclencherOperationExtinctionConsole"/> qui prend le nom d'une ville en paramettre
        /// </summary>
        public string DeclencherOperationExtinctionConsole(string _nomVille);
    }
}