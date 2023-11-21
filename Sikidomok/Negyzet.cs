<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Negyzet : Sikidom
    {
        double oldal;

        public Negyzet(double oldal) : base("négyzet")
        {
            this.oldal = oldal;
        }

        public double Oldal { get => oldal; }

        public override double Kerulet()
        {
            return oldal * 4;
        }

        public override double Terulet()
        {
            return oldal * oldal;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Negyzet : Sikidom
    {
        double oldal;

        public Negyzet(double oldal) : base("négyzet")
        {
            this.oldal = oldal;
        }

        public double Oldal { get => oldal; }

        public override double Kerulet()
        {
            return oldal * 4;
        }

        public override double Terulet()
        {
            return oldal * oldal;
        }
    }
}
>>>>>>> 51da15f225cf15f9e335bd3f2ee5749c48e53b71
