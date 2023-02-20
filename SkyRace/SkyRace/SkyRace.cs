using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyRace
{
	public class SkyRace
	{
		private int id;

		public int Id
		{
			get { return id; }
			set
			{
				if (this.id<=0)
				{
					throw new ArgumentException("greshka v id");
				}
				this.id = value;
			}
		}
		private string name;

		public string Name
		{
			get { return name; }
			set
			{
				if (value==string.Empty)
				{
					throw new ArgumentException("greshka v imeto");
				}
				{ this.name = value; }
			}
		}
		private string lastname;

		public string Lastname
		{
			get { return lastname; }
			set
			{
                if (value == string.Empty)
                {
                    throw new ArgumentException("greshka v familiqta");
                }
                 this.lastname = value; 
            }
        }
		private int vreme;

		public int Vreme
		{
			get { return vreme; }
			set
			{
				if (this.vreme<=0)
				{
					throw new ArgumentException("greshka vav vremeto");
				}
				this.vreme = value;
			}
		}
		private string darjava;

		public string Darjava
		{
			get { return darjava; }
			set
			{
				if (value==string.Empty)
				{
					throw new ArgumentException("greshkla v darjavata");
				}
				this.darjava = value;
			}
		}

		public void Print()
		{
			Console.WriteLine($"sastezatel{this.Id}sas ime{this.Name}," +
                $"{this.Lastname},e preminal traseto za{this.Vreme},i e ot{this.Darjava}");	
		}
		public SkyRace(int id,string name,string lastname,int vreme,string darjava)
		{
			this.Id = id;
			this.Name = name;
			this.Lastname = lastname;
			this.Vreme = vreme;
			this.Darjava = darjava;
		}
		public SkyRace()
		{
		}
    }
    

}
	

