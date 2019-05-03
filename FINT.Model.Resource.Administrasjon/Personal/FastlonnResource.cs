// Built from tag v3.2.0

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Administrasjon.Personal;

namespace FINT.Model.Administrasjon.Personal
{

    public class FastlonnResource : LonnResource 
    {

    
        public long Prosent { get; set; }
        
            

        public void AddLonnsart(Link link)
        {
            AddLink("lonnsart", link);
        }

        public void AddArbeidsforhold(Link link)
        {
            AddLink("arbeidsforhold", link);
        }

        public void AddAnviser(Link link)
        {
            AddLink("anviser", link);
        }

        public void AddKonterer(Link link)
        {
            AddLink("konterer", link);
        }

        public void AddAttestant(Link link)
        {
            AddLink("attestant", link);
        }
    }
}
