using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wzorce
{
    class University
    {
        string nameUniveristy;
        string cityOrRegion;
        public string NameUniveristy { get => nameUniveristy; set => nameUniveristy = value; }
        public string CityOrRegion { get => cityOrRegion; set => cityOrRegion = value; }


        public University(string nameUniveristy, string cityOrRegion)
        {
            this.nameUniveristy = nameUniveristy;
            this.cityOrRegion = cityOrRegion;
        }

    }
}
