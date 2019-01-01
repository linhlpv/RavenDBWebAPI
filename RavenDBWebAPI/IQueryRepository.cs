using Raven.Client.Documents;
using RavenDBWebAPI.Model;
using RavenDBWebAPI.RModel;
using System;

namespace RavenDBWebAPI
{
    public interface IQueryRepository
    {
        RObject GetFrom3Tables(int cost);
        RObject GetFroM2Tables();
        RObject GetFromTable(string customerId);
        RObject Update(string customerId);
        RObject Delete(string customerId);
        RObject Patching();
        RObject DeleteByQuery(int cost);
        RObject Count();


    }
}