using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesya_4
{
    public class Leader
    {
        string sername;
        double self_esteem;
        int evaluation_by_others;
        double Q;

        public Leader(string sername, double self_esteem, int evaluation_by_others)
        {
            this.sername = sername;
            this.self_esteem = self_esteem;
            this.evaluation_by_others = evaluation_by_others;
            this.Q = set_Q(self_esteem, evaluation_by_others);
        }

        public virtual double set_Q(double self_esteem, int amevaluation_by_othersount)
        {
            return amevaluation_by_othersount / self_esteem;
        }

        public double get_Q()
        {
            return Q;
        }
        
    }
}
