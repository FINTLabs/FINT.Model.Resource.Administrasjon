// Built from tag v3.0.0-rc-1

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Administrasjon.Personal;

namespace FINT.Model.Administrasjon.Personal
{

	public class FastlonnResource : LonnResource 
	{

        
		public long Prosent { get; set; }
		
        
        public FastlonnResource()
        {
            //this.Links
            //Links = new Dictionary<string, List<Link>>();
        }

        //[JsonProperty(PropertyName = "_links")]
        //public new Dictionary<string, List<Link>> Links { get; private set; }
        
        private void AddLink(string key, Link link)
        {
            if (!Links.ContainsKey(key))
            {
                Links.Add(key, new List<Link>());
            }
            Links[key].Add(link);
        }
            

        public void AddLonnsart(Link link)
        {
            AddLink("lonnsart", link);
        }

        public void AddAnviser(Link link)
        {
            AddLink("anviser", link);
        }

        public void AddKonterer(Link link)
        {
            AddLink("konterer", link);
        }

        public void AddAttestant(Link link)
        {
            AddLink("attestant", link);
        }

        public void AddArbeidsforhold(Link link)
        {
            AddLink("arbeidsforhold", link);
        }
    }
}
