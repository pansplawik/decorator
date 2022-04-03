using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wzorce
{
    class Direction:University
    {
        string nameDirection;

        public Direction(string nameDirection,string nameUniveristy, string cityOrRegion):base(nameUniveristy,cityOrRegion)
        {
            this.nameDirection = nameDirection;
        }

        public string NameDirection { get => nameDirection; set => nameDirection = value; }

    }
}
