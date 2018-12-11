using Raven.Client.Documents;
using RavenDBWebAPI.Model;

namespace RavenDBWebAPI
{
    public interface IQueryRepository
    {
        void GetFrom3Tables();
        void GetFroM2Tables();
        Customer GetFromTable();
        void Update();
        void Delete();
        void Patching();
        void DeleteByQuery();
        void Count();


    }
}