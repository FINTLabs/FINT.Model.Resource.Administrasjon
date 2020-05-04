// Built from tag v3.5.0-rc-2

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Personal
{

    public class ArbeidsforholdResource 
    {

    
        public long Ansettelsesprosent { get; set; }
        public Periode Arbeidsforholdsperiode { get; set; }
        public long Arslonn { get; set; }
        public Periode Gyldighetsperiode { get; set; }
        public bool Hovedstilling { get; set; }
        public long Lonnsprosent { get; set; }
        public string Stillingsnummer { get; set; }
        public string Stillingstittel { get; set; }
        public Identifikator SystemId { get; set; }
        public long Tilstedeprosent { get; set; }
        
        public ArbeidsforholdResource()
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
     
            

        public void AddAnsvar(Link link)
        {
            AddLink("ansvar", link);
        }

        public void AddArbeidsforholdstype(Link link)
        {
            AddLink("arbeidsforholdstype", link);
        }

        public void AddArt(Link link)
        {
            AddLink("art", link);
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

        public void AddFastlonn(Link link)
        {
            AddLink("fastlonn", link);
        }

        public void AddFasttillegg(Link link)
        {
            AddLink("fasttillegg", link);
        }

        public void AddFravar(Link link)
        {
            AddLink("fravar", link);
        }

        public void AddLonn(Link link)
        {
            AddLink("lonn", link);
        }

        public void AddVariabellonn(Link link)
        {
            AddLink("variabellonn", link);
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
