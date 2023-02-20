using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudebnaSlujba
{
    internal class SudebnaSLJ
    {
        private string adres;
        private int age;
        private string rabotnoMqsto;
        private string srokNaPrisadata;

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string RabotnoMqsto
        {
            get { return rabotnoMqsto; }
            set {rabotnoMqsto = value; }
        }
        public string SrokNaPrisadata
        {
            get { return srokNaPrisadata; }
            set {srokNaPrisadata = value;}
        }
        public SudebnaSLJ(string adres, int age, string rabotnoMqsto, string srokNaPrisadata)
        {
            Adres = adres;
            Age = age;
            RabotnoMqsto = rabotnoMqsto;
            SrokNaPrisadata = srokNaPrisadata;
        }
        public SudebnaSLJ(int age)
        {
            Age = age;
        }

        public override string ToString()
        {
            return $"adres {this.adres}, age {this.age}, rabotno mqsto{this.rabotnoMqsto}, srok na prisadata {this.srokNaPrisadata} ";
        }
    }
}
