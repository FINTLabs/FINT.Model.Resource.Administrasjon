// Built from tag v2.7.0

using System.Collections.Generic;
using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Resource;
using Newtonsoft.Json;

namespace FINT.Model.Administrasjon.Kompleksedatatyper
{
    public class BeskjeftigelseResource
    {
        public BeskjeftigelseResource()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        [JsonProperty(PropertyName = "_links")]
        public Dictionary<string, List<Link>> Links { get; private set; }

        public string Beskrivelse { get; set; }
        public KontostrengResource Kontostreng { get; set; }
        public Periode Periode { get; set; }
        public long Prosent { get; set; }

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