using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuFeuLesPatternsModel
{
    public class Ville : Colleague
    {
        public bool procheDeMer { get; private set; }
        public Ville(IMediateur _mediateur,string nom,bool _procheDeMer=false) : base(_mediateur,nom)
        {
            procheDeMer = _procheDeMer;
            mediateur.AjouterColleague(this);
        }
    }
}
