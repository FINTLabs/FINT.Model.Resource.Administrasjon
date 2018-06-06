// Built from tag v3.0.0-rc-1

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Personal
{

	public class FravarResource 
	{

        
		public Periode Periode { get; set; }
		public long Prosent { get; set; }
		public Identifikator SystemId { get; set; }
		
        
        public FravarResource()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        [JsonProperty(PropertyName = "_links")]
        public Dictionary<string, List<Link>> Links { get; private set; }
        
        private void AddLink(string key, Link link)
        {
            if (!Links.ContainsKey(key))
            {
                Links.Add(key, new List<Link>());
            }
            Links[key].Add(link);
        }
            

        public void AddFravarsgrunn(Link link)
        {
            AddLink("fravarsgrunn", link);
        }

        public void AddFravarstype(Link link)
        {
            AddLink("fravarstype", link);
        }

        public void AddArbeidsforhold(Link link)
        {
            AddLink("arbeidsforhold", link);
        }

        public void AddFortsettelse(Link link)
        {
            AddLink("fortsettelse", link);
        }

        public void AddFortsetter(Link link)
        {
            AddLink("fortsetter", link);
        }
    }
}
