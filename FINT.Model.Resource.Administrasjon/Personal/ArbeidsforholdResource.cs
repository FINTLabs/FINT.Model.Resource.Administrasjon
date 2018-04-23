// Built from tag v2.7.0

using System.Collections.Generic;
using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Resource;
using Newtonsoft.Json;

namespace FINT.Model.Administrasjon.Personal
{
    public class ArbeidsforholdResource
    {
        public ArbeidsforholdResource()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        [JsonProperty(PropertyName = "_links")]
        public Dictionary<string, List<Link>> Links { get; private set; }

        public long Ansettelsesprosent { get; set; }
        public long Arslonn { get; set; }
        public Periode Gyldighetsperiode { get; set; }
        public bool Hovedstilling { get; set; }
        public long Lonnsprosent { get; set; }
        public string Stillingsnummer { get; set; }
        public string Stillingstittel { get; set; }
        public Identifikator SystemId { get; set; }
        public long Tilstedeprosent { get; set; }

        private void AddLink(string key, Link link)
        {
            if (Links.ContainsKey(key)) return;

            Links.Add(key, new List<Link>());
            Links[key].Add(link);
        }

        public void AddAnsvar(Link link)
        {
            AddLink("ansvar", link);
        }

        public void AddArbeidsforholdstype(Link link)
        {
            AddLink("arbeidsforholdstype", link);
        }

        public void AddFunksjon(Link link)
        {
            AddLink("funksjon", link);
        }

        public void AddStillingskode(Link link)
        {
            AddLink("stillingskode", link);
        }

        public void AddTimerPerUke(Link link)
        {
            AddLink("timerPerUke", link);
        }

        public void AddArbeidssted(Link link)
        {
            AddLink("arbeidssted", link);
        }

        public void AddPersonalleder(Link link)
        {
            AddLink("personalleder", link);
        }

        public void AddFravar(Link link)
        {
            AddLink("fravar", link);
        }

        public void AddLonn(Link link)
        {
            AddLink("lonn", link);
        }

        public void AddPersonalressurs(Link link)
        {
            AddLink("personalressurs", link);
        }

        public void AddUndervisningsforhold(Link link)
        {
            AddLink("undervisningsforhold", link);
        }
    }
}