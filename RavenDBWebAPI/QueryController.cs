using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RavenDBWebAPI.Model;
using RavenDBWebAPI.RModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RavenDBWebAPI
{
    [Route("api/Query")]
    public class QueryController : Controller
    {
        private IQueryRepository queryRepository;
        public QueryController (IQueryRepository queryRepository)
        {
            this.queryRepository = queryRepository;
        }

        [Route("GetFromTable"), HttpGet]
        public RObject  GetFormTable()
        {
            return queryRepository.GetFromTable();
        }

        [Route("GetFrom2Table"), HttpGet]
        public RObject GetForm2Table()
        {
            return queryRepository.GetFroM2Tables();
        }
        [Route("GetFrom3Table"), HttpGet]
        public RObject GetForm3Table()
        {
            return queryRepository.GetFrom3Tables();
        }
        [Route("Count"), HttpGet]
        public RObject Count()
        {
            return queryRepository.Count();
        }
        [Route("Update"), HttpGet]
        public RObject Update()
        {
            return queryRepository.Update();
        }
        [Route("Delete"), HttpGet]
        public RObject Delete()
        {
            return queryRepository.Delete();
        }
        [Route("Patching"), HttpGet]
        public RObject Pathching()
        {
            return queryRepository.Patching();
        }
        [Route("DeleteByQuery"), HttpGet]
        public RObject DeleteByQuery()
        {
            return queryRepository.DeleteByQuery();
        }
    }
}
