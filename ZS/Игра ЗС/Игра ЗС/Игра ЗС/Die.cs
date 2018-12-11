using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра_ЗС
{
    class Die
    {
        public int Die1;
        public int Die2;

        public Die(int die1, int die2)
        {
            this.Die1 = die1;
            this.Die2 = die2;
        }

        public int SumDie()
        {
            int dr = this.Die1 + this.Die2;
            return dr;
        }
    }
}
