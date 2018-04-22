// Built from tag v2.7.0

using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Personal
{
    public class PersonalressursResource
    {
        public Identifikator Ansattnummer { get; set; }
        public Periode Ansettelsesperiode { get; set; }
        public Identifikator Brukernavn { get; set; }
        public Kontaktinformasjon Kontaktinformasjon { get; set; }
        public Identifikator SystemId { get; set; }
    }
}