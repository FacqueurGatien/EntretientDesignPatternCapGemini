using AuFeuLesPatternVisiteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuFeuLesPatternsModel
{
    public class Camion : Vehicule
    {

        public Camion(IMediateur _mediateur) : base(_mediateur, $"Camion {++compteur}")
        {
            mediateur.AjouterColleague(this);
        }
        public override string Accept(IVisiteur _visiteur)
        {
            return _visiteur.Visit(this);
        }
    }
}
