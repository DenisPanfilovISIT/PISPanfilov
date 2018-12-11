using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра_ЗС
{
    class Single
    {
        public SingleTon SingleTon { get; set; }
        public Players Players { get; private set; }

        //public Single(Players players)
        //{
        //    this.Players = players;
        //}

        public void Addbd(Players players)
        {
            SingleTon = SingleTon.getInstanse(players);
        }
    }
}
