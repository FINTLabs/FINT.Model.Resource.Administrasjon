// Built from tag v2.7.0

using FINT.Model.Felles.Basisklasser;
using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Organisasjon
{
    public class OrganisasjonselementResource : Enhet
    {
        public Periode Gyldighetsperiode { get; set; }
        public string Kortnavn { get; set; }
        public string Navn { get; set; }
        public Identifikator OrganisasjonsId { get; set; }
        public Identifikator OrganisasjonsKode { get; set; }
    }
}