// Built from tag v3.5.0-rc-2

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Fullmakt
{

    public class RolleResource 
    {

    
        public string Beskrivelse { get; set; }
        public Identifikator Navn { get; set; }
        
        public RolleResource()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        [JsonProperty(PropertyName = "_links")]
        public Dictionary<string, List<Link>> Links { get; private set; }

        protected void AddLink(string key, Link link)
        {
            if (!Links.ContainsKey(key))
            {
                Links.Add(key, new List<Link>());
            }
            Links[key].Add(link);
        }
     
            

        public void AddFullmakt(Link link)
        {
            AddLink("fullmakt", link);
        }
    }
}
