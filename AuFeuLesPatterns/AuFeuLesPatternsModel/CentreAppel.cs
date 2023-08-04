using AuFeuLesPatternVisiteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuFeuLesPatternsModel
{

    public class CentreAppel : IMediateur
    {
        private List<Camion> camions;
        private Bombardier? bombardier;
        private List<Ville> villes;
        private Dictionary<EnumTypeVisiteur,IVisiteur> visiteurs;
        /// <summary>
        /// Permet de verifier si les <see cref="Camion"/> sont deja en intervention (Version Asynchronne)
        /// </summary>
        public bool operationCamionEnCours { get; private set; }
        /// <summary>
        /// Permet de verifier si le <see cref="Bombardier"/> est deja en intervention (Version Asynchronne)
        /// </summary>
        public bool operationBombardierEnCours { get; private set; }

        public CentreAppel()
        {
            camions = new List<Camion>();
            bombardier = default;
            villes = new List<Ville>();
            visiteurs = new Dictionary<EnumTypeVisiteur,IVisiteur>();
        }
        /// <summary>
        /// Permet d'ajouter un <see cref="Camion"/> des sa construction
        /// </summary>
        public void AjouterColleague(Camion _camion)
        {
            if (camions.Count != 3)
            {
                camions.Add(_camion);
            }
        }
        /// <summary>
        /// Permet d'ajouter un <see cref="Bombardier"/> des sa construction
        /// </summary>
        public void AjouterColleague(Bombardier _Bombardier)
        {
            bombardier= _Bombardier;
        }
        /// <summary>
        /// Permet d'ajouter une <see cref="Ville"/> des sa construction
        /// </summary>
        public void AjouterColleague(Ville _ville)
        {
            villes.Add(_ville);
        }
        /// <summary>
        /// Permet d'ajouter un <see cref="IVisiteur"/> des sa construction
        /// </summary>
        public void AjouterColleague(IVisiteur _visiteur)
        {
            if (!visiteurs.ContainsKey(_visiteur.GetType()))
            {
                visiteurs.Add(_visiteur.GetType(),_visiteur);
            }
        }
        /// <summary>
        /// Lance les operations d'extinction d'un incendie en fonction d'une <see cref="Ville"/> <br/>
        /// Grace au mediateur on decide si c'est le <seealso cref="Bombardier"/> ou les <seealso cref="Camion"/> qui seront en intervention
        /// </summary>
        public string DeclencherOperationExtinctionConsole(Ville _ville)
        {
            string result = "___________________________________________________________\n";
            int compteur = 1;
            if (_ville.procheDeMer && bombardier != default)
            {
                while (compteur <= 4)
                {
                    result += $"{compteur}e passage:\n{bombardier.Accept(visiteurs[EnumTypeVisiteur.Console])}\n";
                    compteur++;
                    if (!operationBombardierEnCours)
                    {
                        operationBombardierEnCours = true;
                    }
                }
                operationBombardierEnCours = false;
            }
            else if (camions.Count > 0)
            {
                while (compteur <= 15)
                {
                    camions.ForEach(c =>
                    {
                        result += $"{compteur}e passage:\n{c.Accept(visiteurs[EnumTypeVisiteur.Console])}\n";
                        if (!operationCamionEnCours)
                        {
                            operationCamionEnCours = true;
                        }
                        compteur++;
                    });
                }
                operationCamionEnCours = false;
            }
            result += $"l'incendie de {_ville.nom} est eteint\n" +
                $"___________________________________________________________\n";
            return result;
        }
        /// <summary>
        /// Surcharge de la methode <see cref="DeclencherOperationExtinctionConsole"/> qui prend le nom d'une ville en paramettre
        /// </summary>
        public string DeclencherOperationExtinctionConsole(string _nomVille)
        {
            Ville? ville = villes.Find(v => v.nom == _nomVille);
            string result = "";
            if (ville != null)
            {
                result = DeclencherOperationExtinctionConsole(ville);
                result += $"l'incendie de {_nomVille} est eteint";
                return result;
            }
            return $"Ce centre d'appel ne gere pas la ville de {_nomVille}";
        }
    }
}
