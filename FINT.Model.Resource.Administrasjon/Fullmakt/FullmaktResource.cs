// Built from tag v3.5.0

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Fullmakt
{

    public class FullmaktResource 
    {

    
        public Periode Gyldighetsperiode { get; set; }
        public Identifikator SystemId { get; set; }
        
        public FullmaktResource()
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
     
            

        public void AddMyndighet(Link link)
        {
            AddLink("myndighet", link);
        }

        public void AddStedfortreder(Link link)
        {
            AddLink("stedfortreder", link);
        }

        public void AddFullmektig(Link link)
        {
            AddLink("fullmektig", link);
        }

        public void AddRolle(Link link)
        {
            AddLink("rolle", link);
        }
    }
}
