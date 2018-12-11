using Raven.Client.Documents;
using RavenDBWebAPI.Model;
using RavenDBWebAPI.RModel;

namespace RavenDBWebAPI
{
    public interface IQueryRepository
    {
        RObject GetFrom3Tables();
        RObject GetFroM2Tables();
        RObject GetFromTable();
        RObject Update();
        RObject Delete();
        RObject Patching();
        RObject DeleteByQuery();
        RObject Count();


    }
}