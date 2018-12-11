using Raven.Client.Documents;
using RavenDBWebAPI.Model;
using RavenDBWebAPI.RModel;

namespace RavenDBWebAPI
{
    public interface IQueryRepository
    {
        void GetFrom3Tables();
        void GetFroM2Tables();
        RObject GetFromTable();
        void Update();
        void Delete();
        void Patching();
        void DeleteByQuery();
        void Count();


    }
}