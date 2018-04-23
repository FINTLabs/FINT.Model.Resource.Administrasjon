// Built from tag v2.7.0

using System.Collections.Generic;
using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Resource;
using Newtonsoft.Json;

namespace FINT.Model.Administrasjon.Kompleksedatatyper
{
    public class VariabelttilleggResource
    {
        public VariabelttilleggResource()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        [JsonProperty(PropertyName = "_links")]
        public Dictionary<string, List<Link>> Links { get; private set; }

        public long Antall { get; set; }
        public long? Belop { get; set; }
        public string Beskrivelse { get; set; }
        public KontostrengResource KontostrengResource { get; set; }
        public Periode Periode { get; set; }

        private void AddLink(string key, Link link)
        {
            if (Links.ContainsKey(key)) return;

            Links.Add(key, new List<Link>());
            Links[key].Add(link);
        }

        public void AddLonnsart(Link link)
        {
            AddLink("lonnsart", link);
        }
    }
}