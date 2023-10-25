using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    class SuperHeroList
    {
        public List<SuperHero> HeroList { get; set; }

        public SuperHeroList() 
        { 
            HeroList = new List<SuperHero>();
        }

    }
}
