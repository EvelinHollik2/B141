<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    abstract class Sikidom
    {
        public string tipus;

        protected Sikidom(string tipus)
        {
            this.tipus = tipus;
        }

        public abstract double Kerulet();
        public abstract double Terulet();
        public override string ToString()
        {
            return tipus;
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
    abstract class Sikidom
    {
        public string tipus;

        protected Sikidom(string tipus)
        {
            this.tipus = tipus;
        }

        public abstract double Kerulet();
        public abstract double Terulet();
        public override string ToString()
        {
            return tipus;
        }
    }
}
>>>>>>> 51da15f225cf15f9e335bd3f2ee5749c48e53b71
