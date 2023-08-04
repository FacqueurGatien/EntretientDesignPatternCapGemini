using AuFeuLesPatternsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuFeuLesPatternVisiteur
{
    public class VisiteurConsole : IVisiteur
    {
        private IMediateur mediateur;
        private EnumTypeVisiteur type;
        public VisiteurConsole(IMediateur _mediateur,EnumTypeVisiteur _type) 
        {
            mediateur = _mediateur;
            type = _type;
            mediateur.AjouterColleague(this);
        }
        /// <summary>
        /// Renvoie les etape efectuer par les <see cref="Camion"/> pour eteindre l'incendie
        /// </summary>
        public string Visit(Camion _camion)
        {
            if (!_camion.enIntervention)
            {
                //Premier passage
                return $"1: Le {_camion.nom} démare\n" +
                    $"2: Le {_camion.nom} se rendre vers le lieu de l'incendie\n" +
                    $"3: Le {_camion.nom} brancher la lance à incendie dur une Borne pour récupérer de l'eau\n" +
                    $"4: Le {_camion.nom} envoie de l'eau sur le lieu\n";
            }
            return $"4: Le {_camion.nom} envoie de l'eau sur le lieu\n";
        }
        /// <summary>
        /// Renvoie les etape efectuer par le <see cref="Bombardier"/> pour eteindre l'incendie
        /// </summary>
        public string Visit(Bombardier _bombardier)
        {
            if (!_bombardier.enIntervention)
            {
                //Premier passage
                return $"1: Décolage du {_bombardier.nom}\n" +
                    $"2: Le {_bombardier.nom} remplie son réservoir d'eau\n" +
                    $"3: Le {_bombardier.nom} se dirige vers le lieu de l'incendie\n" +
                    $"4: Le {_bombardier.nom} survole le lieu\n" +
                    $"5: Le {_bombardier.nom} vide son reservoir d'eau sur le lieu de l'incendie";
            }
            return $"1: Le {_bombardier.nom} retourne vers la mer\n" +
                    $"2: Remplisage du réservoir d'eau\n" +
                    $"3: Le {_bombardier.nom} se dirige vers le lieu de l'incendie\n" +
                    $"4: Le {_bombardier.nom} survole le lieu\n" +
                    $"5: Le {_bombardier.nom} vide son reservoir d'eau sur le lieu de l'incendie\n";
        }
        /// <summary>
        /// Renvoie le <see cref="EnumTypeVisiteur"/> du <seealso cref="IVisiteur"/>
        /// </summary>
        /// <returns></returns>
        EnumTypeVisiteur IVisiteur.GetType()
        {
            return type;
        }
    }
}
