// Built from tag v2.7.0

using System.Collections.Generic;
using FINT.Model.Resource;
using Newtonsoft.Json;

namespace FINT.Model.Administrasjon.Kodeverk
{
    public class ProsjektResource : Kontodimensjon
    {
        public ProsjektResource()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        [JsonProperty(PropertyName = "_links")]
        public Dictionary<string, List<Link>> Links { get; private set; }

        private void AddLink(string key, Link link)
        {
            if (Links.ContainsKey(key)) return;

            Links.Add(key, new List<Link>());
            Links[key].Add(link);
        }

        public void AddFullmakt(Link link)
        {
            AddLink("fullmakt", link);
        }
    }
}