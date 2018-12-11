using Raven.Client.Documents.Indexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDBWebAPI.Model
{
    class SupportCallByCost : AbstractIndexCreationTask<SupportCall>
    {
        public SupportCallByCost()
        {
            this.Map = supportCalls => from supportCall in supportCalls
                                       select new
                                       {
                                           Cost = supportCall.Cost
                                       };
        }
    }
}
