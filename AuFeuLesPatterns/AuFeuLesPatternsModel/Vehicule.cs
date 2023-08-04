using AuFeuLesPatternVisiteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuFeuLesPatternsModel
{
    public abstract class Vehicule : Colleague
    {
        protected static int compteur=0;
        public Vehicule(IMediateur _mediateur, string _nom) : base(_mediateur, _nom)
        {
        }
        public abstract string Accept(IVisiteur _visiteur);
    }
}
