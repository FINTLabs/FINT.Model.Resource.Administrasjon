// Built from tag v3.3.0

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Administrasjon.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Personal
{

    public abstract class LonnResource 
    {

    
        public DateTime? Anvist { get; set; }
        public DateTime? Attestert { get; set; }
        public string Beskrivelse { get; set; }
        public Identifikator KildesystemId { get; set; }
        public DateTime? Kontert { get; set; }
        public KontostrengResource Kontostreng { get; set; }
        public Periode Opptjent { get; set; }
        public Periode Periode { get; set; }
        public Identifikator SystemId { get; set; }
        
        protected LonnResource()
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
     
    }
}
