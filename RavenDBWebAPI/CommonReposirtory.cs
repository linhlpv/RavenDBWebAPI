using Raven.Client.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDBWebAPI
{
    public abstract class CommonReposirtory
    {
        private readonly IDocumentStore store;
        public CommonReposirtory (IDocumentStore store)
        {
            this.store = store;
        }
    }
}
