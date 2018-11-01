using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINT.Model.Administrasjon.Kompleksedatatyper;
using FINT.Model.Administrasjon.Personal;
using FINT.Model.Felles.Kompleksedatatyper;
using Xunit;

namespace FINT.Model.Resource.Administrasjon.Tests
{
    public class GenericLonnresourceUsage
    {
        [Fact]
        public void FastlonnResource_should_be_LonnResource()
        {
            var kontostreng = new KontostrengResource();
            kontostreng.AddAnsvar(Link.with("/administrasjon/kodeverk/ansvar/systemid/2"));
            kontostreng.AddArt(Link.with("/administrasjon/kodeverk/art/systemid/1"));
            kontostreng.AddFunksjon(Link.with("/administrasjon/kodeverk/funksjon/systemid/3"));

            var fastlonn = new FastlonnResource
            {
                SystemId = new Identifikator {Identifikatorverdi = "ABC123"},
                Attestert = new DateTime(),
                Anvist = new DateTime(),
                Periode = new Periode {Start = new DateTime()},
                Prosent = 10000,
                Beskrivelse = "Test",
                Kontostreng = kontostreng
            };


            fastlonn.AddLonnsart(Link.with("/administrasjon/kodeverk/lonnsart/systemid/4"));
            fastlonn.AddArbeidsforhold(Link.with("/administrasjon/personal/arbeidsforhold/systemid/1234"));

            var genericLonnResource = fastlonn as LonnResource;


            Assert.Equal("1234", genericLonnResource.Links.IdOf<Arbeidsforhold>());
            

            
        }
    }


    public static class Extensions
    {
        public static string IdFromLink(this Link link)
        {
            if (link == null || string.IsNullOrEmpty(link.href))
                return string.Empty;

            var val = link.href.Split('/').Last();
            return val;


        }


        public static string IdOf<T>(this Dictionary<string, List<Link>> links)
        {
            if (links == null) return string.Empty;

            List<Link> f = null;

            var name =  typeof(T).Name();
            if (links.TryGetValue(name, out f))
            {
                return f.FirstOrDefault()?.IdFromLink();
            }

            return string.Empty;
        }

        
        public static string Name(this Type type)
        {
            return type.Name.ToLower();

        }
    }


}
