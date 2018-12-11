using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра_ЗС
{
    public class Player
    {
        private int id;
        private string _sname;
        private int _isum;


        public Player(int id, string name, int sum)
        {
            Id = id;
            Name = name;
            Sum = sum;

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return _sname; }
            set { _sname = value; }
        }
        public int Sum
        {
            get { return _isum; }
            set { _isum = value; }
        }

    }
}
