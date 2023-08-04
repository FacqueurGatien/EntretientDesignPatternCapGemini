using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuFeuLesPatternsModel
{
    public abstract class Colleague
    {
        public string nom { get; protected set; }
        protected IMediateur mediateur;
        public Colleague(IMediateur _mediateur, string _nom)
        {
            mediateur = _mediateur;
            nom = _nom;
        }
    }
}
