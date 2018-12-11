using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра_ЗС
{
    class Box
    {
        public bool Color;

        public Box(bool flag)
        {
            this.Color = flag;
        }

        public bool SColor()
        {
            if (this.Color == true)
            {
                this.Color = false;
            }
            return this.Color;
        }
    }
}
