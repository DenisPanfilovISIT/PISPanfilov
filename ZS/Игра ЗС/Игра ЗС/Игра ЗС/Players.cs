using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра_ЗС
{
    public class Players
    {
        List<Player> _lplayers = new List<Player>();

        public void AddPlayer(int id, string name, int sum)
        {
            _lplayers.Add(new Player(id, name, sum));
        }
        public Player this[int i]
        {
            get { return _lplayers[i]; }
            set { _lplayers[i] = value; }
        }
        public int Length()
        {
            return _lplayers.Count;
        }

        public int Schet;
        public int td;
        public int SumDie;

        public Players(int ch, int Tb, int die)
        {
            this.Schet = ch;
            this.td = Tb;
            this.SumDie = die;
        }

        public Players()
        {
        }

        public int SumScget()
        {
            int sum = this.td + this.Schet;
            return sum;
        }

        public int OstOchki()
        {
            int s = this.SumDie - this.td;
            return s;
        }
        public int Och()
        {
            int sum = this.Schet - this.td;
            return sum;
        }
    }
}
