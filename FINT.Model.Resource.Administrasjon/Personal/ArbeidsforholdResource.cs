// Built from tag v2.7.0

using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Personal
{
    public class ArbeidsforholdResource
    {
        public long Ansettelsesprosent { get; set; }
        public long Arslonn { get; set; }
        public Periode Gyldighetsperiode { get; set; }
        public bool Hovedstilling { get; set; }
        public long Lonnsprosent { get; set; }
        public string Stillingsnummer { get; set; }
        public string Stillingstittel { get; set; }
        public Identifikator SystemId { get; set; }
        public long Tilstedeprosent { get; set; }
    }
}