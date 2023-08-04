using AuFeuLesPatternVisiteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuFeuLesPatternsModel
{
    public class Bombardier : Vehicule
    {
        public Bombardier(IMediateur _mediateur) : base(_mediateur,"Bombardier")
        {
            mediateur.AjouterColleague(this);
        }
        /// <summary>
        /// Apelle de la methode du <see cref="IVisiteur"/>
        /// </summary>

        public override string Accept(IVisiteur _visiteur)
        {
            return _visiteur.Visit(this);
        }
    }
}
