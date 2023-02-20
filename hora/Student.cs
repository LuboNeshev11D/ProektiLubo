using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hora
{
    internal class Student:Person
    {
        private string faklutetennomer;
        private double mat;
        private double bel;
        public string Faklutetennomer
        {
            get { return faklutetennomer; }
            set { faklutetennomer = value; }
        }
        public double Mat
        {
            get { return mat; }
            set { mat = value; }
        }
        public double Bel
        {
            get { return bel; }
            set { bel = value; }
        }
        public Student(string name, string birthday, string faklutetennomer, double mat, double bel) : base(name, birthday)
        {
            this.faklutetennomer = faklutetennomer;
            this.mat= mat;
            this.bel = bel;
        }
        public override double informaciq()
        {
            return (mat + bel) / 2;
        }

    }
}

