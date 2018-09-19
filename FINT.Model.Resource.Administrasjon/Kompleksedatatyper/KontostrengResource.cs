// Built from tag v3.1.0-rc-1

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

namespace FINT.Model.Administrasjon.Kompleksedatatyper
{

	public class KontostrengResource 
	{

        
        
        public KontostrengResource()
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
            

        public void AddAnsvar(Link link)
        {
            AddLink("ansvar", link);
        }

        public void AddArt(Link link)
        {
            AddLink("art", link);
        }

        public void AddFunksjon(Link link)
        {
            AddLink("funksjon", link);
        }

        public void AddProsjekt(Link link)
        {
            AddLink("prosjekt", link);
        }
    }
}
