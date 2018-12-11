using Raven.Client.Documents;
using Raven.Client.Documents.Indexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDBWebAPI
{
    public class DocumentStoreHolder
    {
        private static readonly Lazy<IDocumentStore> store = new Lazy<IDocumentStore>(CreateStore);
        public static string Url { get; set; }
        public static string DatabaseName { get; set; }

        public static IDocumentStore Store
        {
            get { return store.Value; }
        }

        private static IDocumentStore CreateStore()
        {
            var store = new DocumentStore
            {
                Urls = new[] { Url },
                Database = DatabaseName
            }.Initialize();
            IndexCreation.CreateIndexes(typeof(Program).Assembly, store);

            return store;
        }
    }
   
}
