// Built from tag v2.7.0

using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Personal
{
    public class FravarResource
    {
        public Periode Periode { get; set; }
        public long Prosent { get; set; }
        public Identifikator SystemId { get; set; }
    }
}