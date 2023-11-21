<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Teglalap : Sikidom
    {
        readonly double oldalA;
        readonly double oldalB;

        public double OldalA => oldalA;

        public double OldalB => oldalB;

        public Teglalap(double oldalA, double oldalB) :base("téglalalp")
        {
            this.oldalA = oldalA;
            this.oldalB = oldalB;
        }

        public override double Kerulet()
        {
            return (oldalA + oldalB) * 2;
        }

        public override double Terulet()
        {
            return oldalA * oldalB;
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
    internal class Teglalap : Sikidom
    {
        readonly double oldalA;
        readonly double oldalB;

        public double OldalA => oldalA;

        public double OldalB => oldalB;

        public Teglalap(double oldalA, double oldalB) :base("téglalalp")
        {
            this.oldalA = oldalA;
            this.oldalB = oldalB;
        }

        public override double Kerulet()
        {
            return (oldalA + oldalB) * 2;
        }

        public override double Terulet()
        {
            return oldalA * oldalB;
        }
    }
}
>>>>>>> 51da15f225cf15f9e335bd3f2ee5749c48e53b71
