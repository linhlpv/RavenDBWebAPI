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

        [HttpGet("GetFromTable")]
        public RObject  GetFormTable([FromBody] QueryObject q)
        {
            return queryRepository.GetFromTable(q.Id);
        }

        [HttpGet("GetFrom2Table")]
        public RObject GetForm2Table()
        {
            return queryRepository.GetFroM2Tables();
        }
        [HttpGet("GetFrom3Table")]
        public RObject GetForm3Table([FromBody] QueryObject q)
        {
            return queryRepository.GetFrom3Tables(q.cost);
        }
        [HttpGet("Count")]
        public RObject Count()
        {
            return queryRepository.Count();
        }
        [HttpPut("{customerId}")]
        public RObject Update([FromRoute] string customerId)
        {
            return queryRepository.Update(customerId);
        }
        [HttpDelete("{customerId}")]
        public RObject Delete([FromRoute] string customerId)
        {
            return queryRepository.Delete(customerId);
        }
        [HttpPut("Patching")]
        public RObject Pathching()
        {
            return queryRepository.Patching();
        }
        [HttpDelete("DeleteByQuery")]
        public RObject DeleteByQuery([FromBody] QueryObject q)
        {
            return queryRepository.DeleteByQuery(q.cost);
        }
    }
}
