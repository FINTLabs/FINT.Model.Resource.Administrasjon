// Built from tag v3.1.0

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Administrasjon.Personal;

namespace FINT.Model.Administrasjon.Personal
{

	public class FasttilleggResource : LonnResource 
	{

        
		public long Belop { get; set; }
		
        
        public FasttilleggResource()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        [JsonProperty(PropertyName = "_links")]
        public new Dictionary<string, List<Link>> Links { get; private set; }
        
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
