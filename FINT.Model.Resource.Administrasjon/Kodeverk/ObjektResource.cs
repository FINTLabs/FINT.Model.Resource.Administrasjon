// Built from tag v3.4.0-rc-1

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Administrasjon.Kodeverk;

namespace FINT.Model.Administrasjon.Kodeverk
{

    public class ObjektResource : Kontodimensjon 
    {

    
        public ObjektResource()
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
