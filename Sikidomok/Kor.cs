<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Kor : Sikidom, IAtmeretez, IRajzolas
    {
        double sugar;
        double atmero;

        public Kor(double sugar) : base("kör")
        {
            this.sugar = sugar;
            this.atmero = 2*sugar;
        }

        public double Sugar { get => sugar; }
        public double Atmero { get => atmero; }

        public override double Kerulet()
        {
            return 2 * sugar * Math.PI;
        }
        public override double Terulet()
        {
            return sugar * sugar * Math.PI;
        }

        public void Kisebb()
        {
            Console.WriteLine("Kisebb:");
        }

        public void Nagyobb()
        {
            Console.WriteLine("Nagyobb:");
        }

        public void Vonalvastagsag()
        {
            throw new NotImplementedException();
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
    class Kor : Sikidom, IAtmeretez, IRajzolas
    {
        double sugar;
        double atmero;

        public Kor(double sugar) : base("kör")
        {
            this.sugar = sugar;
            this.atmero = 2*sugar;
        }

        public double Sugar { get => sugar; }
        public double Atmero { get => atmero; }

        public override double Kerulet()
        {
            return 2 * sugar * Math.PI;
        }
        public override double Terulet()
        {
            return sugar * sugar * Math.PI;
        }

        public void Kisebb()
        {
            Console.WriteLine("Kisebb:");
        }

        public void Nagyobb()
        {
            Console.WriteLine("Nagyobb:");
        }

        public void Vonalvastagsag()
        {
            throw new NotImplementedException();
        }
    }
}
>>>>>>> 51da15f225cf15f9e335bd3f2ee5749c48e53b71
